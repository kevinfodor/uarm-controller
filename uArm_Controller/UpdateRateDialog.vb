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

Imports System.Windows.Forms
Imports uArm_Controller.Utilities.Ranges

Public Class UpdateRateDialog

    ' Rate (update) is provided in msec
    Public Shared ReadOnly Rate As Range(Of Integer) = New Range(Of Integer)(1, 1000, 25)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RateTrackBar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateTrackBar.ValueChanged
        RateNumericUpDown.Value = RateTrackBar.Value
    End Sub

    Private Sub RateNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateNumericUpDown.ValueChanged
        RateTrackBar.Value = RateNumericUpDown.Value
    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OnChangeRadioButton.Checked = My.Settings.UpdateOnChange
        PeriodicRateRadioButton.Checked = Not My.Settings.UpdateOnChange
        UpdateRateGroupBox.Enabled = Not OnChangeRadioButton.Checked

        RateTrackBar.Maximum = Rate.Max
        RateTrackBar.Minimum = Rate.Min
        RateTrackBar.TickFrequency = 50

        RateNumericUpDown.Maximum = Rate.Max
        RateNumericUpDown.Minimum = Rate.Min

        RateTrackBar.Value = My.Settings.UpdateRate

    End Sub


    Private Sub OnChangeRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OnChangeRadioButton.CheckedChanged
        UpdateRateGroupBox.Enabled = Not OnChangeRadioButton.Checked
    End Sub

    Private Sub PeriodicRateRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles PeriodicRateRadioButton.CheckedChanged
        UpdateRateGroupBox.Enabled = PeriodicRateRadioButton.Checked
    End Sub

End Class
