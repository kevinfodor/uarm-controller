Imports System.Windows.Forms
Imports SlimDX
Imports SlimDX.DirectInput
Imports System.Globalization

Public Class JoystickDialog

    ' make sure that DirectInput has been initialized
    Private _dInput As New DirectInput()

    Private _num_POVs As Integer
    Private _num_sliders As Integer
    Private _num_buttons As Integer

    Private _guid_list As New List(Of System.Guid)

    Private _guid As System.Guid = System.Guid.Empty
    Public ReadOnly Property Guid() As System.Guid
        Get
            Return _guid
        End Get
    End Property

    Private _device_name As String = "None"
    Public ReadOnly Property DeviceName() As String
        Get
            Return _device_name
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub JoystickDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ' Populate a list of 'Game Controller'
            For Each device As DeviceInstance In _dInput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly)
                ControllerComboBox.Items.Add(device.ProductName)
                _guid_list.Add(device.ProductGuid)
            Next

            ' If any were found, try to match GUID provided
            If _guid_list.Count() > 0 Then
                Dim index As Integer
                index = _guid_list.FindIndex(Function(p) p.ToString = _guid.ToString)
                If index >= 0 Then ' Match found
                    ControllerComboBox.SelectedIndex = index
                    'update properties of this control
                    _guid = _guid_list(index)
                    _device_name = ControllerComboBox.SelectedItem(index)
                Else ' No match found, use first one
                    ControllerComboBox.SelectedIndex = 0
                    _guid = System.Guid.Empty
                End If
            Else
                MessageBox.Show("No available " & DeviceClass.GameController.ToString & " devices!", Me.Text)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
            Me.Close()
        End Try
    End Sub


    Public Sub New(ByVal guid As System.Guid)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _guid = guid

    End Sub

    Private Sub ControllerComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControllerComboBox.SelectedIndexChanged
        _guid = _guid_list(ControllerComboBox.SelectedIndex)
        _device_name = ControllerComboBox.SelectedItem
        Dim _joystick As SlimDX.DirectInput.Joystick = _
            New SlimDX.DirectInput.Joystick(_dInput, _guid)

        ' Initialize the number of object
        _num_sliders = 0
        _num_POVs = 0
        _num_buttons = 0

        ' Iterate though available device objects
        For Each deviceObject As DeviceObjectInstance In _joystick.GetObjects()
            UpdateControl(deviceObject)
        Next deviceObject
    End Sub

    Private Sub UpdateControl(ByVal d As DeviceObjectInstance)
        ' Axis...
        If ObjectGuid.XAxis = d.ObjectTypeGuid Then
            label_XAxis.Enabled = True
        End If
        If ObjectGuid.YAxis = d.ObjectTypeGuid Then
            label_YAxis.Enabled = True
        End If
        If ObjectGuid.ZAxis = d.ObjectTypeGuid Then
            label_ZAxis.Enabled = True
        End If

        ' Rotation...
        If ObjectGuid.RotationalXAxis = d.ObjectTypeGuid Then
            label_XRotation.Enabled = True
        End If
        If ObjectGuid.RotationalYAxis = d.ObjectTypeGuid Then
            label_YRotation.Enabled = True
        End If
        If ObjectGuid.RotationalZAxis = d.ObjectTypeGuid Then
            label_ZRotation.Enabled = True
        End If

        ' Sliders....
        If ObjectGuid.Slider = d.ObjectTypeGuid Then
            _num_sliders += 1
            Select Case _num_sliders
                Case 0
                    label_Slider0.Enabled = True
                Case 1
                    label_Slider1.Enabled = True
            End Select
        End If

        ' POVs...
        If ObjectGuid.PovController = d.ObjectTypeGuid Then
            _num_POVs += 1
            Select Case _num_POVs
                Case 0
                    label_POV0.Enabled = True

                Case 1
                    label_POV1.Enabled = True

                Case 2
                    label_POV2.Enabled = True

                Case 3
                    label_POV3.Enabled = True
            End Select
        End If

        ' Buttons
        If ObjectGuid.Button = d.ObjectTypeGuid Then
            _num_buttons = _num_buttons + 1
            label_ButtonList.Text = _num_buttons.ToString
        End If
    End Sub
 End Class
