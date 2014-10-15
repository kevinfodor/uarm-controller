Imports SlimDX
Imports SlimDX.DirectInput
Imports System.Threading

Public MustInherit Class InputDevice(Of _T As SlimDX.DirectInput.Device)
    Implements IDisposable

    ' Class identifier (DEBUG)
    Private _classId As String = _
        System.Reflection.MethodBase.GetCurrentMethod.DeclaringType.FullName

    Public MustOverride Sub CreateDevice(ByVal guid As System.Guid)
    Public MustOverride Sub GetCurrentState()

    ' Event
    Public Event ValuesUpdated As EventHandler

    ' A direct input object
    Protected _dinput As DirectInput = New DirectInput()

    ' Thread object for polling and control parameter for
    ' killing the thread.
    Private _poll_thread As Thread = Nothing
    Private _stop_requested As Boolean = False
    Private _thread_sleep_msec As Integer = 50 ' msec
    Private Shared _event_state As AutoResetEvent = Nothing
    Private _wait_handle As WaitHandle = _event_state

    ' Buffered device data
    Private _buffered_data(8) As RawBufferedData

    ' This instance's device class
    Protected _device_class As DeviceClass = Nothing

    ' Constructed cooperative flags
    Private Const cooperativeLevel As CooperativeLevel = _
       (cooperativeLevel.Exclusive Or cooperativeLevel.Foreground)

    ' The device object
    Protected _device As _T = Nothing
    Public ReadOnly Property Device() As _T
        Get
            Return _device
        End Get
    End Property

    ' GUID for the device
    Public Property GUID As System.Guid
        Set(ByVal g As System.Guid)
            If (GUID <> g) Or (g = System.Guid.Empty) Then
                ' Initialize it
                InitializeDevice(g)
            End If
        End Set
        Get
            Dim g As System.Guid = System.Guid.Empty
            If _device IsNot Nothing Then
                ' Retrieve the device's GUID
                g = _device.Properties.ClassGuid
            End If
            Return g
        End Get
    End Property

    ' The device name
    Public ReadOnly Property Name() As String
        Get
            Dim n As String = "None"
            If _device IsNot Nothing Then
                ' Retrieve the product name
                n = _device.Properties.ProductName
            End If
            Return n
        End Get
    End Property

    Private Sub ReadStateData()
        ' Check for device errors
        If _device.Poll().IsFailure Then
            Return
        End If

        ' Read device state
        GetCurrentState()

        ' Check for read errors
        If Result.Last.IsFailure Then
            Return
        End If
    End Sub

    Private Sub ReadBufferedData()
        While _device.Poll().IsSuccess
            Dim len As Integer
            len = _device.GetDeviceData(_buffered_data, False)
            'TODO: Do something with it?
        End While
        ' Check for read errors
        If Result.Last.IsFailure Then
            Return
        End If
    End Sub

    Public Sub EnableEvents(Optional ByVal guid As System.Guid = Nothing)
        ' Check for a valid device
        If _device IsNot Nothing Then
            ' Check if the thread has already been created
            If _poll_thread Is Nothing Then
                ' Create a device poll thread
                _poll_thread = New Thread(AddressOf PollThread)
                ' Start thread
                _poll_thread.Start()
            End If
        End If
    End Sub

    Public Sub DisableEvents()
        If _poll_thread IsNot Nothing Then
            ' Stop poll thread
            _stop_requested = True
            ' If device is self-polled, signal event
            If _event_state IsNot Nothing Then
                ' signal event to run thread
                _event_state.Set()
            End If
            Do
                Thread.Sleep(100)
            Loop While ((_poll_thread.ThreadState And _
                         (ThreadState.Unstarted Or _
                          ThreadState.Aborted Or _
                          ThreadState.Stopped)) = 0)
            _poll_thread.Abort()
            _stop_requested = False
            _poll_thread = Nothing
        End If
    End Sub

    Public Function IsEnabled() As Boolean
        Dim enabled = False
        If _poll_thread IsNot Nothing Then
            If _poll_thread.ThreadState = ThreadState.Running Then
                enabled = True
            End If
        End If
        Return enabled
    End Function

    Public Function IsDisabled() As Boolean
        Dim disabled = False
        If _poll_thread IsNot Nothing Then
            If _poll_thread.ThreadState <> ThreadState.Running Then
                disabled = True
            End If
        End If
        Return disabled
    End Function

    ' The method that will be called when the thread is run. 
    Public Sub PollThread()
        Dim _methodId As String = _
        System.Reflection.MethodBase.GetCurrentMethod.ToString ' DEBUG

        While (Not _stop_requested)

            If _device.Poll().IsSuccess Then

                ' Wait for something to happen
                If _event_state IsNot Nothing Then
                    _event_state.WaitOne()
                Else
                    ' wait to poll
                    Thread.Sleep(_thread_sleep_msec)
                End If

                Console.WriteLine(_classId & "." & _methodId & ": Run") ' DEBUG

                ' Read device state
                ReadStateData()

                ' Signal listeners
                RaiseEvent ValuesUpdated(Me, System.EventArgs.Empty)

            End If
        End While

        Console.WriteLine(_classId & "." & _methodId & _
                          ": The instance method called by the worker thread has ended.")
    End Sub

    Protected Function GetDevice(ByVal guid As System.Guid) As System.Guid
        Dim new_guid As System.Guid = System.Guid.Empty
        Dim device As DeviceInstance = Nothing
        Dim index As Integer = -1
        ' Check if we have any devices of this class at all
        If _dinput.GetDevices(_device_class, DeviceEnumerationFlags.AttachedOnly).ToList.Count > 0 Then
            ' Check if we were provided a guid
            If guid <> System.Guid.Empty Then
                ' Search list of devices for this guid
                index = _dinput.GetDevices(_device_class, DeviceEnumerationFlags.AttachedOnly).ToList.FindIndex(Function(p) p.ToString = guid.ToString)
            Else
                ' Just use the fist avalable device
                index = 0
            End If
            If index >= 0 Then ' Match found
                device = _dinput.GetDevices(_device_class, _
                                           DeviceEnumerationFlags.AttachedOnly)(index)
                If device IsNot Nothing Then
                    new_guid = device.InstanceGuid
                Else
                    MessageBox.Show("Failed to get device " & _device_class.ToString & ".", _classId)
                End If
            Else ' No match found
                MessageBox.Show("Invalid " & _device_class.ToString & ". Selected device was not found.", _classId)
            End If
        Else
            MessageBox.Show("No available " & _device_class.ToString & " devices!", _classId)
        End If
        Return new_guid
    End Function

    Private Sub InitializeDevice(ByVal guid As System.Guid)
        ' Stop all events that may be active
        DisableEvents()

        ' Uninitialize any existing device
        UninitializeDevice()

        ' Using the guid provided, attempt to create the device
        ' using the provided guid, if the guid is empty try to
        ' use the first available device.
        CreateDevice(guid)

        ' Check if we have a device first
        If _device IsNot Nothing Then
            ' Since we want to use buffered data, we need to tell DirectInput
            ' to set up a buffer for the data.
            _device.Properties.BufferSize = _buffered_data.Length

            ' acquire the device
            _device.Acquire()
        End If
    End Sub

    Private Sub UninitializeDevice()
        ' Release device
        If _device IsNot Nothing Then
            _device.Unacquire()
            _device.Dispose()
            _device = Nothing
        End If
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If
            ' Stop all events that may be active
            DisableEvents()

            ' Uninitialize any existing device
            UninitializeDevice()
        End If
        Me.disposedValue = True
    End Sub

    ' override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class


Public Class JoystickDevice
    Inherits InputDevice(Of Joystick)

    ' Class identifier
    Private Const _classId As String = "JoystickDevice"

    Public Overrides Sub CreateDevice(ByVal guid As System.Guid)
        Dim new_guid As System.Guid
        ' Set device class
        _device_class = DeviceClass.GameController
        ' Obtain the device object for this GUID, if not a valid GUID
        ' attempt to get the first available one.
        new_guid = GetDevice(guid)
        ' At this point we either have the guid provided or we found one
        If new_guid <> System.Guid.Empty Then
            _device = New Joystick(_dinput, new_guid)
        End If
    End Sub

    ' The device state
    Private _state As New JoystickState()
    Public ReadOnly Property State() As JoystickState
        Get
            Return _state
        End Get
    End Property

    Public Overrides Sub GetCurrentState()
        _state = _device.GetCurrentState()
    End Sub

End Class

Public Class KeyboardDevice
    Inherits InputDevice(Of Keyboard)

    ' Class identifier
    Private Const _classId As String = "KeyboardDevice"

    Public Overrides Sub CreateDevice(ByVal guid As System.Guid)
        ' Set device class
        _device_class = DeviceClass.Keyboard
        ' Obtain device
        _device = New Keyboard(_dinput)
        If _device Is Nothing Then
            Throw New Exception(_device_class.ToString & " does not exist.")
        End If
    End Sub

    ' The device state
    Private _state As New KeyboardState()
    Public ReadOnly Property State() As KeyboardState
        Get
            Return _state
        End Get
    End Property

    Public Overrides Sub GetCurrentState()
        _state = _device.GetCurrentState()
    End Sub

End Class

Public Class MouseDevice
    Inherits InputDevice(Of Mouse)

    ' Class identifier
    Private Const _classId As String = "MouseDevice"

    Public Overrides Sub CreateDevice(ByVal guid As System.Guid)
        ' Set device class
        _device_class = DeviceClass.Pointer
        ' Obtain device
        _device = New Mouse(_dinput)
        If _device Is Nothing Then
            Throw New Exception(_device_class.ToString & " does not exist.")
        End If
    End Sub

    ' The device state
    Private _state As New MouseState()
    Public ReadOnly Property State() As MouseState
        Get
            Return _state
        End Get
    End Property

    Public Overrides Sub GetCurrentState()
        _state = _device.GetCurrentState()
    End Sub

End Class
