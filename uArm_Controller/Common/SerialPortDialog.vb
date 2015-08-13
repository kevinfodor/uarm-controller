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

Public Class SerialPortDialog

    Private _portValue As String = ""
    Public Property PortName() As String
        Get
            Return _portValue
        End Get
        Set(ByVal value As String)
            _portValue = value
        End Set
    End Property

    Private _rateValue As Integer = 9600
    Public Property Rate() As Integer
        Get
            Return _rateValue
        End Get
        Set(ByVal value As Integer)
            _rateValue = value
        End Set
    End Property

    Public Sub New(ByVal port As String, ByVal rate As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        'Load values provided as defaults
        Me.PortName = port
        Me.Rate = rate

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        PortName = _PortName.SelectedItem
        Rate = CInt(_BaudRate.SelectedItem)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub SerialPortDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Populate list of ports
            For Each com As String In System.IO.Ports.SerialPort.GetPortNames()
                _PortName.Items.Add(com)
            Next

            If _PortName.Items.Count() > 0 Then
                Dim index As Integer
                index = _PortName.FindStringExact(_portValue)
                If index <> ListBox.NoMatches Then
                    _PortName.SelectedIndex = index
                Else
                    _PortName.SelectedIndex = 0
                End If
                PortName = _PortName.SelectedItem

                index = _BaudRate.FindStringExact(_rateValue.ToString)
                If index <> ListBox.NoMatches Then
                    _BaudRate.SelectedIndex = index
                Else
                    _BaudRate.SelectedIndex = 0
                End If
                Rate = CInt(_BaudRate.SelectedItem)
            Else
                MessageBox.Show("No ports found!", Me.Text)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
            Me.Close()
        End Try

    End Sub

End Class
