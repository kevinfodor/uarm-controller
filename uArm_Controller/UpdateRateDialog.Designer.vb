<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateRateDialog
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
        Me.UpdateRateGroupBox = New System.Windows.Forms.GroupBox()
        Me.RateNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.RateTrackBar = New System.Windows.Forms.TrackBar()
        Me.label10 = New System.Windows.Forms.Label()
        Me.OnChangeRadioButton = New System.Windows.Forms.RadioButton()
        Me.PeriodicRateRadioButton = New System.Windows.Forms.RadioButton()
        Me.UpdateTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.UpdateRateGroupBox.SuspendLayout()
        CType(Me.RateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateTypeGroupBox.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(44, 199)
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
        'UpdateRateGroupBox
        '
        Me.UpdateRateGroupBox.Controls.Add(Me.RateNumericUpDown)
        Me.UpdateRateGroupBox.Controls.Add(Me.RateTrackBar)
        Me.UpdateRateGroupBox.Controls.Add(Me.label10)
        Me.UpdateRateGroupBox.Enabled = False
        Me.UpdateRateGroupBox.Location = New System.Drawing.Point(6, 75)
        Me.UpdateRateGroupBox.Name = "UpdateRateGroupBox"
        Me.UpdateRateGroupBox.Size = New System.Drawing.Size(166, 100)
        Me.UpdateRateGroupBox.TabIndex = 43
        Me.UpdateRateGroupBox.TabStop = False
        Me.UpdateRateGroupBox.Text = "Update Rate"
        '
        'RateNumericUpDown
        '
        Me.RateNumericUpDown.Location = New System.Drawing.Point(88, 29)
        Me.RateNumericUpDown.Name = "RateNumericUpDown"
        Me.RateNumericUpDown.Size = New System.Drawing.Size(64, 20)
        Me.RateNumericUpDown.TabIndex = 41
        '
        'RateTrackBar
        '
        Me.RateTrackBar.Location = New System.Drawing.Point(12, 53)
        Me.RateTrackBar.Maximum = 100
        Me.RateTrackBar.Minimum = 1
        Me.RateTrackBar.Name = "RateTrackBar"
        Me.RateTrackBar.Size = New System.Drawing.Size(140, 45)
        Me.RateTrackBar.TabIndex = 40
        Me.RateTrackBar.TickFrequency = 10
        Me.RateTrackBar.Value = 100
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Calibri", 10.5!)
        Me.label10.Location = New System.Drawing.Point(6, 29)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(79, 17)
        Me.label10.TabIndex = 39
        Me.label10.Text = "Rate (msec):"
        '
        'OnChangeRadioButton
        '
        Me.OnChangeRadioButton.AutoSize = True
        Me.OnChangeRadioButton.Checked = True
        Me.OnChangeRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.OnChangeRadioButton.Name = "OnChangeRadioButton"
        Me.OnChangeRadioButton.Size = New System.Drawing.Size(103, 17)
        Me.OnChangeRadioButton.TabIndex = 44
        Me.OnChangeRadioButton.TabStop = True
        Me.OnChangeRadioButton.Text = "On Change Only"
        Me.OnChangeRadioButton.UseVisualStyleBackColor = True
        '
        'PeriodicRateRadioButton
        '
        Me.PeriodicRateRadioButton.AutoSize = True
        Me.PeriodicRateRadioButton.Location = New System.Drawing.Point(6, 41)
        Me.PeriodicRateRadioButton.Name = "PeriodicRateRadioButton"
        Me.PeriodicRateRadioButton.Size = New System.Drawing.Size(89, 17)
        Me.PeriodicRateRadioButton.TabIndex = 45
        Me.PeriodicRateRadioButton.Text = "Periodic Rate"
        Me.PeriodicRateRadioButton.UseVisualStyleBackColor = True
        '
        'UpdateTypeGroupBox
        '
        Me.UpdateTypeGroupBox.Controls.Add(Me.OnChangeRadioButton)
        Me.UpdateTypeGroupBox.Controls.Add(Me.UpdateRateGroupBox)
        Me.UpdateTypeGroupBox.Controls.Add(Me.PeriodicRateRadioButton)
        Me.UpdateTypeGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.UpdateTypeGroupBox.Name = "UpdateTypeGroupBox"
        Me.UpdateTypeGroupBox.Size = New System.Drawing.Size(179, 181)
        Me.UpdateTypeGroupBox.TabIndex = 46
        Me.UpdateTypeGroupBox.TabStop = False
        Me.UpdateTypeGroupBox.Text = "Update Type"
        '
        'UpdateRateDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(202, 240)
        Me.Controls.Add(Me.UpdateTypeGroupBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateRateDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configure Update Rate"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.UpdateRateGroupBox.ResumeLayout(False)
        Me.UpdateRateGroupBox.PerformLayout()
        CType(Me.RateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateTypeGroupBox.ResumeLayout(False)
        Me.UpdateTypeGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents UpdateRateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents RateTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents OnChangeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PeriodicRateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents UpdateTypeGroupBox As System.Windows.Forms.GroupBox

End Class
