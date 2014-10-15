<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uArmLogControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uArmLogControl))
        Me.LogGroupBox = New System.Windows.Forms.GroupBox()
        Me.EnableCheckBox = New System.Windows.Forms.CheckBox()
        Me.LogListView = New System.Windows.Forms.ListView()
        Me.EntryColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimeColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RotationColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StretchColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HeightColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WristColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EffectorColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LogMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.LogOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.LogGroupBox.SuspendLayout()
        Me.LogMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogGroupBox
        '
        Me.LogGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LogGroupBox.Controls.Add(Me.EnableCheckBox)
        Me.LogGroupBox.Controls.Add(Me.LogListView)
        Me.LogGroupBox.Controls.Add(Me.LogMenuStrip)
        Me.LogGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.LogGroupBox.Name = "LogGroupBox"
        Me.LogGroupBox.Size = New System.Drawing.Size(542, 158)
        Me.LogGroupBox.TabIndex = 45
        Me.LogGroupBox.TabStop = False
        Me.LogGroupBox.Text = "Serial Output Log"
        '
        'EnableCheckBox
        '
        Me.EnableCheckBox.AutoSize = True
        Me.EnableCheckBox.Location = New System.Drawing.Point(477, 23)
        Me.EnableCheckBox.Name = "EnableCheckBox"
        Me.EnableCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.EnableCheckBox.TabIndex = 4
        Me.EnableCheckBox.Text = "&Enable"
        Me.EnableCheckBox.UseVisualStyleBackColor = True
        '
        'LogListView
        '
        Me.LogListView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LogListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EntryColumnHeader, Me.TimeColumnHeader, Me.RotationColumnHeader, Me.StretchColumnHeader, Me.HeightColumnHeader, Me.WristColumnHeader, Me.EffectorColumnHeader})
        Me.LogListView.FullRowSelect = True
        Me.LogListView.HideSelection = False
        Me.LogListView.Location = New System.Drawing.Point(3, 40)
        Me.LogListView.Name = "LogListView"
        Me.LogListView.Size = New System.Drawing.Size(536, 112)
        Me.LogListView.TabIndex = 2
        Me.LogListView.UseCompatibleStateImageBehavior = False
        Me.LogListView.View = System.Windows.Forms.View.Details
        '
        'EntryColumnHeader
        '
        Me.EntryColumnHeader.Text = "Entry"
        '
        'TimeColumnHeader
        '
        Me.TimeColumnHeader.Text = "Time"
        Me.TimeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TimeColumnHeader.Width = 95
        '
        'RotationColumnHeader
        '
        Me.RotationColumnHeader.Text = "Rotation"
        Me.RotationColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StretchColumnHeader
        '
        Me.StretchColumnHeader.Text = "Stretch"
        Me.StretchColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeightColumnHeader
        '
        Me.HeightColumnHeader.Text = "Height"
        Me.HeightColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WristColumnHeader
        '
        Me.WristColumnHeader.Text = "Wrist"
        Me.WristColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EffectorColumnHeader
        '
        Me.EffectorColumnHeader.Text = "Effector"
        Me.EffectorColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogMenuStrip
        '
        Me.LogMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.LogMenuStrip.Location = New System.Drawing.Point(3, 16)
        Me.LogMenuStrip.Name = "LogMenuStrip"
        Me.LogMenuStrip.Size = New System.Drawing.Size(536, 24)
        Me.LogMenuStrip.TabIndex = 3
        Me.LogMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileNewToolStripMenuItem, Me.FileOpenToolStripMenuItem, Me.FileClearToolStripMenuItem, Me.toolStripSeparator2, Me.FileSaveToolStripMenuItem, Me.FileSaveAsToolStripMenuItem, Me.toolStripSeparator3})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'FileNewToolStripMenuItem
        '
        Me.FileNewToolStripMenuItem.Image = CType(resources.GetObject("FileNewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileNewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileNewToolStripMenuItem.Name = "FileNewToolStripMenuItem"
        Me.FileNewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.FileNewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FileNewToolStripMenuItem.Text = "&New"
        '
        'FileOpenToolStripMenuItem
        '
        Me.FileOpenToolStripMenuItem.Enabled = False
        Me.FileOpenToolStripMenuItem.Image = CType(resources.GetObject("FileOpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileOpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileOpenToolStripMenuItem.Name = "FileOpenToolStripMenuItem"
        Me.FileOpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.FileOpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FileOpenToolStripMenuItem.Text = "&Open"
        '
        'FileClearToolStripMenuItem
        '
        Me.FileClearToolStripMenuItem.Name = "FileClearToolStripMenuItem"
        Me.FileClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FileClearToolStripMenuItem.Text = "&Clear"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'FileSaveToolStripMenuItem
        '
        Me.FileSaveToolStripMenuItem.Image = CType(resources.GetObject("FileSaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileSaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileSaveToolStripMenuItem.Name = "FileSaveToolStripMenuItem"
        Me.FileSaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.FileSaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FileSaveToolStripMenuItem.Text = "&Save"
        '
        'FileSaveAsToolStripMenuItem
        '
        Me.FileSaveAsToolStripMenuItem.Name = "FileSaveAsToolStripMenuItem"
        Me.FileSaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FileSaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'LogSaveFileDialog
        '
        Me.LogSaveFileDialog.DefaultExt = "csv"
        Me.LogSaveFileDialog.FileName = "uArm"
        Me.LogSaveFileDialog.Filter = "uArm log files (*.csv)|*.csv|All files (*.*)|*.*"
        Me.LogSaveFileDialog.RestoreDirectory = True
        Me.LogSaveFileDialog.Title = "Save uArm Log"
        '
        'LogOpenFileDialog
        '
        Me.LogOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'uArmLogControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LogGroupBox)
        Me.Name = "uArmLogControl"
        Me.Size = New System.Drawing.Size(543, 158)
        Me.LogGroupBox.ResumeLayout(False)
        Me.LogGroupBox.PerformLayout()
        Me.LogMenuStrip.ResumeLayout(False)
        Me.LogMenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LogListView As System.Windows.Forms.ListView
    Friend WithEvents EntryColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents RotationColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents StretchColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents HeightColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents WristColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents EffectorColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents LogSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LogOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LogMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileSaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnableCheckBox As System.Windows.Forms.CheckBox

End Class
