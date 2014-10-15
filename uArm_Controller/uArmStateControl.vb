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

Imports uArm_Controller.uArm

Public Class uArmStateControl

    ' Events

    ' Fired when control is enabled
    Public Event EnableClick As EventHandler

    ' Fired when state data changes
    Public Event StateChanged As EventHandler

    Private WithEvents m_state As State = Nothing
    Public ReadOnly Property State() As State
        Get
            Return m_state
        End Get
    End Property

    Public Overrides Property Text() As String
        Get
            Return Me.TitleGroupBox.Text
        End Get
        Set(ByVal value As String)
            Me.TitleGroupBox.Text = value
        End Set
    End Property

    Public ReadOnly Property IsEnabled() As Boolean
        Get
            Return Me.EnableCheckBox.CheckState
        End Get
    End Property

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Create a uArm state to attach to this control
        m_state = New State()

        ' Update control with current state values
        UpdateText()
    End Sub

    Public Sub Reset()
        ' Set all state values to nominal
        m_state.Reset()
    End Sub

    Private Sub UpdateText()
        RotationValueLabel.Text = m_state.Rotation.ToString
        StretchValueLabel.Text = m_state.Stretch.ToString
        HeightValueLabel.Text = m_state.Height.ToString
        WristValueLabel.Text = m_state.Wrist.ToString
        EffectorValueLabel.Text = m_state.Effector.ToString
    End Sub

    Private Sub EnableCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        EnableCheckBox.CheckedChanged
        ' Signal event
        RaiseEvent EnableClick(Me, System.EventArgs.Empty)
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        ResetButton.Click
        ' Reset values and update text
        Reset()
    End Sub

#Region "State Change Event Handler"

    Delegate Sub StateChangeCallback()

    Private Sub HandleStateChanged(sender As Object, e As System.EventArgs) Handles _
        m_state.StateChanged
        If Me.InvokeRequired Then
            Dim d As New StateChangeCallback(AddressOf HandleStateChange_Local)
            Me.Invoke(d, New Object() {})
        Else
            HandleStateChange_Local()
        End If
    End Sub

    Private Sub HandleStateChange_Local()
        ' Update text displayed with state values
        UpdateText()

        ' Signal update
        RaiseEvent StateChanged(Me, System.EventArgs.Empty)
    End Sub

#End Region

End Class
