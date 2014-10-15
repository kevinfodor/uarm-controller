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

Imports System.Windows.Forms.ListView

Public Class uArmLogControl

    ' Default path where to store uArm log files
    Private ReadOnly m_default_path As String = _
        My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\" + _
        System.Reflection.Assembly.GetEntryAssembly().GetName().Name

    ' Time when log started reocrding
    Private base_time As DateTime = DateTime.Now

    Public Sub AddLog(ByRef state As uArm.State)

        If EnableCheckBox.Checked Then

            ' Mark beginning of log
            If LogListView.Items.Count = 0 Then
                base_time = Date.Now
            End If

            Dim log_time As TimeSpan = DateTime.Now.Subtract(base_time)
            Dim list As ListViewItemCollection = LogListView.Items
            Dim item As ListViewItem = New ListViewItem

            With item
                .Text = LogListView.Items.Count.ToString
                .SubItems.Add(log_time.TotalSeconds.ToString("0.000"))
                .SubItems.Add(state.Rotation.ToString)
                .SubItems.Add(state.Stretch.ToString)
                .SubItems.Add(state.Height.ToString)
                .SubItems.Add(state.Wrist.ToString)
                .SubItems.Add(CInt(state.Effector.State).ToString)
            End With

            list.Add(item)

            ' make sure last item is always visible
            LogListView.Items(LogListView.Items.Count - 1).EnsureVisible()

            LogListView_UpdateInfo()

        End If
    End Sub

#Region "Entries"

    Private Sub LogListView_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub LogListView_DoubleClick(sender As System.Object, e As System.EventArgs)
        'Dim bytes() as Byte = <ListView>.SelectedItems.Item(0).SubItems(<index>).Text.Split("-").Select(Function(value) Convert.ToByte(value,16)).ToArray()
    End Sub

    Private Sub LogListView_UpdateInfo()
        'LogGroupBox.Text = String.Format("Serial Output Log ({0} of {1} [{2}])", _
        '    LogListView.Items.Count.ToString, LogListView.Items.Count.ToString, _
        '    LogListView.SelectedItems.Count.ToString)
        LogGroupBox.Text = String.Format("Serial Output Log ({0})", _
            LogListView.Items.Count.ToString)
    End Sub

    Private Sub LogClear()
        LogListView.Items.Clear()
        base_time = Date.Now
        LogListView_UpdateInfo()
    End Sub

    Private Sub LogSave(ByVal show_dialog As Boolean)
        Dim fstream As IO.StreamWriter = Nothing

        ' Construct a unique filename
        LogSaveFileDialog.FileName = "uArm_" + base_time.ToString("MMddyyyy_HHmmss")

        ' Decide if dialog should be shown
        Dim result As System.Windows.Forms.DialogResult = DialogResult.OK
        If show_dialog = True Then
            result = LogSaveFileDialog.ShowDialog()
        Else
            LogSaveFileDialog.FileName = LogSaveFileDialog.InitialDirectory + _
                "\" + LogSaveFileDialog.FileName + "." + LogSaveFileDialog.DefaultExt
        End If
        If result = System.Windows.Forms.DialogResult.OK Then
            Try
                fstream = New IO.StreamWriter(LogSaveFileDialog.FileName)
                If (fstream IsNot Nothing) Then
                    For Each entry As ListViewItem In LogListView.Items
                        Dim index As Integer
                        fstream.Write(entry.Text)
                        For index = 1 To entry.SubItems.Count - 1
                            fstream.Write("," & entry.SubItems(index).Text)
                        Next
                        fstream.WriteLine()
                    Next
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open. 
                If (fstream IsNot Nothing) Then
                    fstream.Close()
                End If
            End Try
        End If
    End Sub

#End Region

#Region "Menu"

    Private Sub FileNewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles _
        FileNewToolStripMenuItem.Click
        LogClear()
    End Sub

    Private Sub FileOpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles _
        FileOpenToolStripMenuItem.Click
    End Sub

    Private Sub FileClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles _
        FileClearToolStripMenuItem.Click
        LogClear()
    End Sub

    Private Sub FileSaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles _
        FileSaveToolStripMenuItem.Click
        LogSave(False)
    End Sub

    Private Sub FileSaveAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles _
        FileSaveAsToolStripMenuItem.Click
        LogSave(True)
    End Sub

    Private Sub EnableCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _
        EnableCheckBox.CheckedChanged
        If EnableCheckBox.Checked Then
            EnableCheckBox.Text = "&Disable"
        Else
            EnableCheckBox.Text = "&Enable"
        End If
    End Sub

#End Region

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Create a place to store log files if none already exists
        If (Not System.IO.Directory.Exists(m_default_path)) Then
            System.IO.Directory.CreateDirectory(m_default_path)
        End If
        LogSaveFileDialog.InitialDirectory = m_default_path

    End Sub

End Class

