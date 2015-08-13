'==============================================================================

'BSD License
'-----------

'Copyright (c) 2014, and Kevin Fodor, All rights reserved.

'Redistribution and use in source and binary forms, with or without
'modification, are permitted provided that the following conditions are met:

'- Redistributions of source code must retain the above copyright notice,
'this list of conditions and the following disclaimer.

'- Redistributions in binary form must reproduce the above copyright notice,
'this list of conditions and the following disclaimer in the documentation
'and/or other materials provided with the distribution.

'- Neither the name of Kevin Fodor nor the names of
'its contributors may be used to endorse or promote products derived from
'this software without specific prior written permission.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
'AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
'IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
'ARE DISCLAIMED.  IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
'LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
'CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
'SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
'INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
'CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
'ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
'POSSIBILITY OF SUCH DAMAGE.

'NOTICE:
'SOME OF THIS CODE MAY HAVE ELEMENTS TAKEN FROM OTHER CODE WITHOUT ATTRIBUTION.
'IF THIS IS THE CASE IT WAS DUE TO OVERSIGHT WHILE DEBUGGING AND I APOLOGIZE.
'IF ANYONE HAS ANY REASON TO BELIEVE THAT ANY OF THIS CODE VIOLATES OTHER
'LICENSES PLEASE CONTACT ME WITH DETAILS SO THAT I MAY CORRECT THE SITUATION.

'==============================================================================

Public Class JoystickSelectionControl

    ' make sure that DirectInput has been initialized
    Private _dInput As New DirectInput()

    ' device being viewed
    Private _joystick As SlimDX.DirectInput.Joystick = Nothing

    Private _num_POVs As Integer
    Private _num_sliders As Integer
    Private _num_buttons As Integer

    Private _guid_list As New List(Of System.Guid)

    Private _guid As System.Guid = System.Guid.Empty
    Public Property Guid() As System.Guid
        Get
            Return _guid
        End Get
        Set(value As System.Guid)
            _guid = value
        End Set
    End Property

    Private _device_name As String = "None"
    Public ReadOnly Property DeviceName() As String
        Get
            Return _device_name
        End Get
    End Property

    Private Sub JoystickDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load

        Try
            ' Populate a list of 'Game Controller'
            If _dInput IsNot Nothing Then
                For Each device As DeviceInstance In _dInput.GetDevices( _
                    DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly)
                    ControllerComboBox.Items.Add(device.ProductName)
                    _guid_list.Add(device.ProductGuid)
                Next

                ' If any were found, try to match GUID provided
                If _guid_list.Count() > 0 Then
                    Dim index As Integer
                    index = _guid_list.FindIndex(Function(p) p = _guid)
                    If index < 0 Then ' No match found, use first one
                        index = 0
                    End If
                    'update properties of this control
                    ControllerComboBox.SelectedIndex = index
                    _guid = _guid_list(index)
                    _device_name = ControllerComboBox.SelectedItem
                Else
                    MessageBox.Show("No available " & _
                                    DeviceClass.GameController.ToString & " devices!", Me.Text)
                    ParentForm.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
            ParentForm.Close()
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Private Sub ControllerComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ControllerComboBox.SelectedIndexChanged
        _guid = _guid_list(ControllerComboBox.SelectedIndex)
        _device_name = ControllerComboBox.SelectedItem

        ' Release any existing joystick
        If _joystick IsNot Nothing Then
            _joystick.Unacquire()
            _joystick.Dispose()
            _joystick = Nothing
        End If

        ' Initialize the selected joystick
        _joystick = New SlimDX.DirectInput.Joystick(_dInput, _guid)
        _joystick.Acquire()

        ' Initialize info
        HardwareRevisionLabel.Text = _joystick.Capabilities.HardwareRevision.ToString
        FirmwareVersionLabel.Text = _joystick.Capabilities.FirmwareRevision.ToString
        DriverVersionLabel.Text = _joystick.Capabilities.DriverVersion.ToString

        ' Initialize the number of objects
        NumberOfAxisLabel.Text = _joystick.Capabilities.AxesCount
        NumberButtonsLabel.Text = _joystick.Capabilities.ButtonCount
        NumberOfPovsLabel.Text = _joystick.Capabilities.PovCount
        UsageIdLabel.Text = _joystick.Information.UsageId
        UsagePageLabel.Text = _joystick.Information.UsagePage


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

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        ' Stop time
        PollTimer.Stop()

        ' Release any existing joystick
        If _joystick IsNot Nothing Then
            _joystick.Unacquire()
            _joystick.Dispose()
            _joystick = Nothing
        End If

        _dInput.Dispose()
    End Sub

    Private Sub TestButton_Click(sender As System.Object, e As System.EventArgs) _
        Handles TestButton.Click
        If PollTimer.Enabled Then
            PollTimer.Stop()
            TestButton.Text = "Test"
            ControllerComboBox.Enabled = True
        Else
            PollTimer.Start()
            TestButton.Text = "Stop"
            ControllerComboBox.Enabled = False
        End If
    End Sub

    Private Sub PollTimer_Tick(sender As System.Object, e As System.EventArgs) _
        Handles PollTimer.Tick
        Dim state As JoystickState
        state = _joystick.GetCurrentState

        XAxisLabel.Text = state.X
        YAxisLabel.Text = state.Y
        ZAxisLabel.Text = state.Z

        ButtonsLabel.Text = "<None> "

        Dim str As String = ""
        Dim value As Integer = 0
        Dim count As Integer = 0
        For Each button As Boolean In state.GetButtons()
            If button Then
                str = str & count.ToString & " "
                value = value Or (1 << count)
            End If
            count += 1
        Next
        If value > 0 Then
            ButtonsLabel.Text = "Values: " & str
        End If


    End Sub

End Class
