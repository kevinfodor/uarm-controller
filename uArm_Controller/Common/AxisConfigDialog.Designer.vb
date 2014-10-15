<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AxisConfigDialog
    Inherits System.Windows.Forms.Form

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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RangeMaximumNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProportionalGroupBox = New System.Windows.Forms.GroupBox()
        Me.RangeMinimumNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PositioningModeGroupBox = New System.Windows.Forms.GroupBox()
        Me.RelativeModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.AbsoluteModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeMaximumNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProportionalGroupBox.SuspendLayout()
        CType(Me.RangeMinimumNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PositioningModeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(228, 286)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 166)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Relative"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Threshold (%)"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(80, 130)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown3.TabIndex = 24
        Me.NumericUpDown3.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Threshold (%)"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(80, 77)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown2.TabIndex = 22
        Me.NumericUpDown2.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(80, 103)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown5.TabIndex = 15
        Me.NumericUpDown5.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Fast Step"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Range:"
        '
        'RangeMaximumNumericUpDown
        '
        Me.RangeMaximumNumericUpDown.Location = New System.Drawing.Point(85, 72)
        Me.RangeMaximumNumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.RangeMaximumNumericUpDown.Name = "RangeMaximumNumericUpDown"
        Me.RangeMaximumNumericUpDown.Size = New System.Drawing.Size(54, 20)
        Me.RangeMaximumNumericUpDown.TabIndex = 20
        Me.RangeMaximumNumericUpDown.TabStop = False
        Me.RangeMaximumNumericUpDown.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(80, 51)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown6.TabIndex = 14
        Me.NumericUpDown6.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Slow Step"
        '
        'ProportionalGroupBox
        '
        Me.ProportionalGroupBox.Controls.Add(Me.Label2)
        Me.ProportionalGroupBox.Controls.Add(Me.Label1)
        Me.ProportionalGroupBox.Controls.Add(Me.RangeMinimumNumericUpDown)
        Me.ProportionalGroupBox.Controls.Add(Me.Label6)
        Me.ProportionalGroupBox.Controls.Add(Me.RangeMaximumNumericUpDown)
        Me.ProportionalGroupBox.Location = New System.Drawing.Point(176, 88)
        Me.ProportionalGroupBox.Name = "ProportionalGroupBox"
        Me.ProportionalGroupBox.Size = New System.Drawing.Size(200, 166)
        Me.ProportionalGroupBox.TabIndex = 20
        Me.ProportionalGroupBox.TabStop = False
        Me.ProportionalGroupBox.Text = "Proportional"
        '
        'RangeMinimumNumericUpDown
        '
        Me.RangeMinimumNumericUpDown.Location = New System.Drawing.Point(85, 46)
        Me.RangeMinimumNumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.RangeMinimumNumericUpDown.Name = "RangeMinimumNumericUpDown"
        Me.RangeMinimumNumericUpDown.Size = New System.Drawing.Size(54, 20)
        Me.RangeMinimumNumericUpDown.TabIndex = 22
        Me.RangeMinimumNumericUpDown.TabStop = False
        Me.RangeMinimumNumericUpDown.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Minimum:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Maximum:"
        '
        'PositioningModeGroupBox
        '
        Me.PositioningModeGroupBox.Controls.Add(Me.RelativeModeRadioButton)
        Me.PositioningModeGroupBox.Controls.Add(Me.AbsoluteModeRadioButton)
        Me.PositioningModeGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.PositioningModeGroupBox.Name = "PositioningModeGroupBox"
        Me.PositioningModeGroupBox.Size = New System.Drawing.Size(364, 70)
        Me.PositioningModeGroupBox.TabIndex = 46
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
        'AxisControlDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(386, 327)
        Me.Controls.Add(Me.PositioningModeGroupBox)
        Me.Controls.Add(Me.ProportionalGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AxisControlDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AxisControlDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeMaximumNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProportionalGroupBox.ResumeLayout(False)
        Me.ProportionalGroupBox.PerformLayout()
        CType(Me.RangeMinimumNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PositioningModeGroupBox.ResumeLayout(False)
        Me.PositioningModeGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RangeMaximumNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProportionalGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RangeMinimumNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents PositioningModeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RelativeModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AbsoluteModeRadioButton As System.Windows.Forms.RadioButton

End Class
