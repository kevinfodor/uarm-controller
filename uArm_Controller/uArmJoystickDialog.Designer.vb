<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uArmJoystickDialog
    Inherits uArm_Controller.JoystickDialog

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.ControlContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StretchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WristToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PositioningModeGroupBox = New System.Windows.Forms.GroupBox()
        Me.RelativeModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.AbsoluteModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.uArmTreeView = New System.Windows.Forms.TreeView()
        Me.ControlEditContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlContextMenuStrip.SuspendLayout()
        Me.PositioningModeGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ControlEditContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlContextMenuStrip
        '
        Me.ControlContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddControlToolStripMenuItem, Me.RemoveAllToolStripMenuItem})
        Me.ControlContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ControlContextMenuStrip.Size = New System.Drawing.Size(140, 48)
        '
        'AddControlToolStripMenuItem
        '
        Me.AddControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RotationToolStripMenuItem, Me.StretchToolStripMenuItem, Me.HeightToolStripMenuItem, Me.WristToolStripMenuItem, Me.EffectorToolStripMenuItem})
        Me.AddControlToolStripMenuItem.Name = "AddControlToolStripMenuItem"
        Me.AddControlToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AddControlToolStripMenuItem.Text = "Add Control"
        '
        'RotationToolStripMenuItem
        '
        Me.RotationToolStripMenuItem.Name = "RotationToolStripMenuItem"
        Me.RotationToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RotationToolStripMenuItem.Text = "Rotation"
        '
        'StretchToolStripMenuItem
        '
        Me.StretchToolStripMenuItem.Name = "StretchToolStripMenuItem"
        Me.StretchToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.StretchToolStripMenuItem.Text = "Stretch"
        '
        'HeightToolStripMenuItem
        '
        Me.HeightToolStripMenuItem.Name = "HeightToolStripMenuItem"
        Me.HeightToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.HeightToolStripMenuItem.Text = "Height"
        '
        'WristToolStripMenuItem
        '
        Me.WristToolStripMenuItem.Name = "WristToolStripMenuItem"
        Me.WristToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.WristToolStripMenuItem.Text = "Wrist"
        '
        'EffectorToolStripMenuItem
        '
        Me.EffectorToolStripMenuItem.Name = "EffectorToolStripMenuItem"
        Me.EffectorToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EffectorToolStripMenuItem.Text = "Effector"
        '
        'RemoveAllToolStripMenuItem
        '
        Me.RemoveAllToolStripMenuItem.Name = "RemoveAllToolStripMenuItem"
        Me.RemoveAllToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RemoveAllToolStripMenuItem.Text = "Remove All"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'PositioningModeGroupBox
        '
        Me.PositioningModeGroupBox.Controls.Add(Me.RelativeModeRadioButton)
        Me.PositioningModeGroupBox.Controls.Add(Me.AbsoluteModeRadioButton)
        Me.PositioningModeGroupBox.Location = New System.Drawing.Point(8, 19)
        Me.PositioningModeGroupBox.Name = "PositioningModeGroupBox"
        Me.PositioningModeGroupBox.Size = New System.Drawing.Size(111, 70)
        Me.PositioningModeGroupBox.TabIndex = 45
        Me.PositioningModeGroupBox.TabStop = False
        Me.PositioningModeGroupBox.Text = "Positioning Mode"
        '
        'RelativeModeRadioButton
        '
        Me.RelativeModeRadioButton.AutoSize = True
        Me.RelativeModeRadioButton.Checked = True
        Me.RelativeModeRadioButton.Location = New System.Drawing.Point(11, 42)
        Me.RelativeModeRadioButton.Name = "RelativeModeRadioButton"
        Me.RelativeModeRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.RelativeModeRadioButton.TabIndex = 1
        Me.RelativeModeRadioButton.TabStop = True
        Me.RelativeModeRadioButton.Text = "Relative"
        Me.RelativeModeRadioButton.UseVisualStyleBackColor = True
        '
        'AbsoluteModeRadioButton
        '
        Me.AbsoluteModeRadioButton.AutoSize = True
        Me.AbsoluteModeRadioButton.Location = New System.Drawing.Point(11, 19)
        Me.AbsoluteModeRadioButton.Name = "AbsoluteModeRadioButton"
        Me.AbsoluteModeRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.AbsoluteModeRadioButton.TabIndex = 0
        Me.AbsoluteModeRadioButton.Text = "Absolute"
        Me.AbsoluteModeRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.uArmTreeView)
        Me.GroupBox1.Controls.Add(Me.PositioningModeGroupBox)
        Me.GroupBox1.Location = New System.Drawing.Point(355, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 343)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "uArm Configuration"
        '
        'uArmTreeView
        '
        Me.uArmTreeView.Location = New System.Drawing.Point(7, 96)
        Me.uArmTreeView.Name = "uArmTreeView"
        Me.uArmTreeView.Size = New System.Drawing.Size(197, 241)
        Me.uArmTreeView.TabIndex = 46
        '
        'ControlEditContextMenuStrip
        '
        Me.ControlEditContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.ControlEditContextMenuStrip.Name = "ButtonContextMenuStrip"
        Me.ControlEditContextMenuStrip.Size = New System.Drawing.Size(118, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Label1"
        '
        'uArmJoystickDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(577, 476)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "uArmJoystickDialog"
        Me.Text = "uArmJoystickDialog"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ControlContextMenuStrip.ResumeLayout(False)
        Me.PositioningModeGroupBox.ResumeLayout(False)
        Me.PositioningModeGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ControlEditContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend Shadows WithEvents OK_Button As System.Windows.Forms.Button
    Friend Shadows WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PositioningModeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RelativeModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AbsoluteModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents uArmTreeView As System.Windows.Forms.TreeView
    Friend WithEvents ControlContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RotationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StretchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlEditContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WristToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EffectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
