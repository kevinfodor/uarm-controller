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

Imports SlimDX.DirectInput
Imports uArm_Controller.uArm
Imports uArm_Controller.Processing
Imports uArm_Controller.Utilities.Ranges
Imports System.Windows.Forms.ListView
Imports System.IO
Imports System.Windows.Forms.ListViewItem

Public Class uArmForm

    ' Output device
    Private WithEvents _myArmComm As Comm = New Comm

    ' input Device
    Private WithEvents _myJoystick As JoystickModule = Nothing

#Region "Keyboard"

    Sub uArmForm_KeyPress(ByVal sender As Object, _
        ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        Dim bHandled As Boolean = True

        Select Case e.KeyChar
            Case "a"c, "A"c
                TrimmerIn.State.Rotation -= 1
            Case "d"c, "D"c
                TrimmerIn.State.Rotation += 1
            Case "w"c, "W"c
                TrimmerIn.State.Stretch += 1
            Case "s"c, "S"c
                TrimmerIn.State.Stretch -= 1
            Case "e"c, "E"c
                TrimmerIn.State.Height += 1
            Case "q"c, "Q"c
                TrimmerIn.State.Height -= 1
            Case "z"c, "Z"c
                TrimmerIn.State.Wrist -= 1
            Case "x"c, "X"c
                TrimmerIn.State.Wrist += 1
            Case " "c, "p"c, "P"c
                TrimmerIn.State.Effector = Not TrimmerIn.State.Effector
            Case Else
                bHandled = False
        End Select
        e.Handled = bHandled
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
      ByVal keyData As Keys) As Boolean
        Dim bHandled As Boolean = True
        Select Case keyData
            Case Keys.Up
                TrimmerIn.State.Height += 1
            Case Keys.Down
                TrimmerIn.State.Height -= 1
            Case Keys.Left
                TrimmerIn.State.Wrist -= 1
            Case Keys.Right
                TrimmerIn.State.Wrist += 1
            Case Else
                bHandled = False
        End Select
        Return bHandled
    End Function

#End Region

#Region "Trimmer Controls"

    Private Sub StretchTrackBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        StretchTrackBar.ValueChanged
        TrimmerIn.State.Stretch = StretchTrackBar.Value
        StretchLabel.Text = StretchTrackBar.Value
    End Sub

    Private Sub RotationTrackBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        RotationTrackBar.ValueChanged
        TrimmerIn.State.Rotation = RotationTrackBar.Value
        RotationLabel.Text = RotationTrackBar.Value
    End Sub

    Private Sub HeightTrackBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        HeightTrackBar.ValueChanged
        TrimmerIn.State.Height = HeightTrackBar.Value
        HeightLabel.Text = HeightTrackBar.Value
    End Sub

    Private Sub WristTrackBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        WristTrackBar.ValueChanged
        TrimmerIn.State.Wrist = WristTrackBar.Value
        WristLabel.Text = WristTrackBar.Value
    End Sub

    Private Sub EffectorCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        EffectorCheckBox.CheckedChanged
        TrimmerIn.State.Effector = EffectorCheckBox.Checked
        EffectorLabel.Text = TrimmerIn.State.Effector.ToString
    End Sub

#End Region

#Region "Trimmer Control Updaters"

    Private Sub UpdateTrimmersFromState()
        RotationTrackBar.Value = TrimmerIn.State.Rotation
        StretchTrackBar.Value = TrimmerIn.State.Stretch
        HeightTrackBar.Value = TrimmerIn.State.Height
        WristTrackBar.Value = TrimmerIn.State.Wrist
        EffectorCheckBox.Checked = TrimmerIn.State.Effector
    End Sub

    Private Sub UpdateStateFromTrimmers()
        TrimmerIn.State.Stretch = StretchTrackBar.Value
        TrimmerIn.State.Rotation = RotationTrackBar.Value
        TrimmerIn.State.Height = HeightTrackBar.Value
        TrimmerIn.State.Wrist = WristTrackBar.Value
        TrimmerIn.State.Effector = EffectorCheckBox.Checked
    End Sub

    Private Sub InitializeTrimmers()

        ' Set up Trimmer Track Bar ranges and tick freq
        RotationTrackBar.Maximum = Range.Rotation.Max
        RotationTrackBar.Minimum = Range.Rotation.Min
        RotationTrackBar.TickFrequency = 10

        HeightTrackBar.Maximum = Range.Height.Max
        HeightTrackBar.Minimum = Range.Height.Min
        HeightTrackBar.TickFrequency = 20

        StretchTrackBar.Maximum = Range.Stretch.Max
        StretchTrackBar.Minimum = Range.Stretch.Min
        StretchTrackBar.TickFrequency = 10

        WristTrackBar.Maximum = Range.Wrist.Max
        WristTrackBar.Minimum = Range.Wrist.Min
        WristTrackBar.TickFrequency = 10

    End Sub

#End Region

#Region "Button Controls"

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "ToolStripMenuItem"

    Private Sub SerialPortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        SerialPortToolStripMenuItem.Click
        Dim sp As SerialPortDialog = New SerialPortDialog(My.Settings.SerialPortName, My.Settings.SerialBaud)

        If sp.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Load new settings
            My.Settings.SerialPortName = sp.PortName
            My.Settings.SerialBaud = sp.Rate
            SerialToolStripStatusLabel.Text = My.Settings.SerialPortName

            ' Disconnect existing object and reconnect it
            If _myArmComm.IsConnected Then
                _myArmComm.Disconnect()
                _myArmComm.Connect(My.Settings.SerialPortName, My.Settings.SerialBaud)
            End If
        End If
    End Sub

    Private Sub JoystickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        JoystickToolStripMenuItem.Click
        Dim jd As JoystickDialog = New JoystickDialog(My.Settings.JoystickGUID) ' TODO: uArmJoystickDialog
        If jd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Load new settings selected from dialog
            My.Settings.JoystickGUID = jd.Guid
            JoystickToolStripStatusLabel.Text = jd.DeviceName
            ' start/configure joystick
            _myJoystick.IsAbsolute = My.Settings.AbsoluteMode
            If _myJoystick.Setup(My.Settings.JoystickGUID) = True Then
                ' Load new settings (may have changed due to previous assignment)
                My.Settings.JoystickGUID = _myJoystick.Guid
                JoystickToolStripStatusLabel.Text = _myJoystick.Name
            Else
                ' Pull up joystick selection dialog
                JoystickToolStripMenuItem.PerformClick()
            End If
        End If
    End Sub

    Private Sub UpdateRateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles _
        UpdateRateToolStripMenuItem.Click
        Dim dlg As UpdateRateDialog = New UpdateRateDialog()
        TimerStop()
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CommandTimer.Interval = dlg.RateTrackBar.Value
            My.Settings.UpdateRate = dlg.RateTrackBar.Value
            My.Settings.UpdateOnChange = dlg.OnChangeRadioButton.Checked
        End If
        If Not My.Settings.UpdateOnChange Then
            TimerStart()
        End If
    End Sub

    Private Sub SaveSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        SaveSettingsToolStripMenuItem.Click
        My.Settings.Save()
    End Sub

    Private Sub ResetSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        ResetSettingsToolStripMenuItem.Click
        SettingsReset()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        ExitToolStripMenuItem.Click
        CleanUp()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles _
        AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

#End Region

#Region "State Handlers"

    Sub TrimmerIn_StateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        TrimmerIn.StateChanged
        UpdateTrimmersFromState()
        SerialOutUpdate()
    End Sub

    Sub TrimmerIn_EnableClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        TrimmerIn.EnableClick
        SerialOutUpdate()
    End Sub

    Sub JstickIn_EnableClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        JstickIn.EnableClick
        ' start/configure currently selected joystick
        _myJoystick.Setup(My.Settings.JoystickGUID)
        ' Load new settings (may have changed due to previous assignment)
        My.Settings.JoystickGUID = _myJoystick.Guid
        JoystickToolStripStatusLabel.Text = _myJoystick.Name
        SerialOutUpdate()
    End Sub

    Sub JstickIn_StateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        JstickIn.StateChanged
        SerialOutUpdate()
    End Sub

    Sub SerialOut_EnableClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        SerialOut.EnableClick
        If SerialOut.IsEnabled Then
            Dim connected As Boolean
            connected = _myArmComm.Connect(My.Settings.SerialPortName, My.Settings.SerialBaud)
            If connected = False Then
                ' disable serial ouput
                SerialOut.EnableCheckBox.Checked = False
                SerialPortToolStripMenuItem.PerformClick()
            End If
            SerialOutUpdate()
        Else
            _myArmComm.Disconnect()
        End If
    End Sub

    Sub SerialOut_StateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        SerialOut.StateChanged

        If My.Settings.UpdateOnChange Then
            SerialOutSend()
        End If

    End Sub

    Sub SerialOutUpdate()
        Static sum As State = New State

        ' Start fresh
        sum.Reset()

        ' Apply inputs...
        If TrimmerIn.IsEnabled Then
            sum += TrimmerIn.State
        End If

        If JstickIn.IsEnabled Then
            sum += JstickIn.State
        End If

        ' Update ouput state with the sum of the states
        SerialOut.State.Copy(sum)

    End Sub

    Sub SerialOutSend()
        ' Check if uArm is connected
        If _myArmComm.IsConnected Then
            ' Send to uArm
            _myArmComm.Send(SerialOut.State)
            ' Add to log (if enabled)
            uArmLogControl.AddLog(SerialOut.State)
        End If
    End Sub

#End Region

#Region "Class ctors and dtors"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        InitializeTrimmers()

        ' Set up state control titles of I/O channels
        SerialOut.Text = "Serial Out:"
        TrimmerIn.Text = "Trimmer In:"
        JstickIn.Text = "Joystick In:"

        ' Load Settings
        SettingsLoad()

        ' Declare and configure the joystick (if available)
        _myJoystick = New JoystickModule(JstickIn)
        JoystickToolStripStatusLabel.Text = _myJoystick.Name

        If Not My.Settings.UpdateOnChange Then
            ' Start Timer
            TimerStart()
        End If

    End Sub

    Protected Sub CleanUp()
        My.Settings.Save()

        TimerStop()

        _myJoystick.Dispose()
        _myJoystick = Nothing

        If _myArmComm.IsConnected Then
            _myArmComm.Disconnect()
        End If

    End Sub

#End Region

#Region "Settings"

    Sub SettingsLoad()
        ' Load
        SerialToolStripStatusLabel.Text = My.Settings.SerialPortName
        JoystickToolStripStatusLabel.Text = "None"
        CommandTimer.Interval = My.Settings.UpdateRate

        ' Update trimmer values
        TrimmerIn.Reset()
        TrimmerIn.EnableCheckBox.Checked = My.Settings.TrimmerInEnable
        UpdateTrimmersFromState()
    End Sub

    Sub SettingsReset()

        ' Reset all settings
        My.Settings.Reset()

        ' Rest all controls
        TrimmerIn.Reset()
        JstickIn.Reset()
        SerialOut.Reset()

        ' Load them again
        SettingsLoad()
    End Sub

#End Region

#Region "Timer"

    Private Sub TimerStart()
        If Not CommandTimer.Enabled Then
            CommandTimer.Start()
        End If
    End Sub

    Private Sub TimerStop()
        If CommandTimer.Enabled Then
            CommandTimer.Stop()
        End If
    End Sub

    Private Sub TimerTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        CommandTimer.Tick
        SerialOutSend()
    End Sub

#End Region

End Class
