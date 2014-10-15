<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonConfigDialog
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
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.DirectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.DecrementRadioButton = New System.Windows.Forms.RadioButton()
        Me.IncrementRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StepSizeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.DirectionGroupBox.SuspendLayout()
        CType(Me.StepSizeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(17, 165)
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
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.DirectionGroupBox)
        Me.ButtonGroupBox.Controls.Add(Me.Label4)
        Me.ButtonGroupBox.Controls.Add(Me.StepSizeNumericUpDown)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(150, 136)
        Me.ButtonGroupBox.TabIndex = 15
        Me.ButtonGroupBox.TabStop = False
        Me.ButtonGroupBox.Text = "Button"
        '
        'DirectionGroupBox
        '
        Me.DirectionGroupBox.Controls.Add(Me.DecrementRadioButton)
        Me.DirectionGroupBox.Controls.Add(Me.IncrementRadioButton)
        Me.DirectionGroupBox.Location = New System.Drawing.Point(14, 51)
        Me.DirectionGroupBox.Name = "DirectionGroupBox"
        Me.DirectionGroupBox.Size = New System.Drawing.Size(105, 75)
        Me.DirectionGroupBox.TabIndex = 11
        Me.DirectionGroupBox.TabStop = False
        Me.DirectionGroupBox.Text = "Direction"
        '
        'DecrementRadioButton
        '
        Me.DecrementRadioButton.AutoSize = True
        Me.DecrementRadioButton.Location = New System.Drawing.Point(6, 45)
        Me.DecrementRadioButton.Name = "DecrementRadioButton"
        Me.DecrementRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.DecrementRadioButton.TabIndex = 1
        Me.DecrementRadioButton.TabStop = True
        Me.DecrementRadioButton.Text = "Decrement"
        Me.DecrementRadioButton.UseVisualStyleBackColor = True
        '
        'IncrementRadioButton
        '
        Me.IncrementRadioButton.AutoSize = True
        Me.IncrementRadioButton.Checked = True
        Me.IncrementRadioButton.Location = New System.Drawing.Point(6, 22)
        Me.IncrementRadioButton.Name = "IncrementRadioButton"
        Me.IncrementRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.IncrementRadioButton.TabIndex = 0
        Me.IncrementRadioButton.TabStop = True
        Me.IncrementRadioButton.Text = "Increment"
        Me.IncrementRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Step Size:"
        '
        'StepSizeNumericUpDown
        '
        Me.StepSizeNumericUpDown.Location = New System.Drawing.Point(78, 25)
        Me.StepSizeNumericUpDown.Name = "StepSizeNumericUpDown"
        Me.StepSizeNumericUpDown.Size = New System.Drawing.Size(41, 20)
        Me.StepSizeNumericUpDown.TabIndex = 3
        Me.StepSizeNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ButtonConfigDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(175, 206)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ButtonConfigDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ButtonConfigDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ButtonGroupBox.PerformLayout()
        Me.DirectionGroupBox.ResumeLayout(False)
        Me.DirectionGroupBox.PerformLayout()
        CType(Me.StepSizeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ButtonGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DirectionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DecrementRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IncrementRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StepSizeNumericUpDown As System.Windows.Forms.NumericUpDown

End Class
