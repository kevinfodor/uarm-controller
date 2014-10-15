<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uArmStateControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RotationValueLabel = New System.Windows.Forms.Label()
        Me.StretchValueLabel = New System.Windows.Forms.Label()
        Me.HeightValueLabel = New System.Windows.Forms.Label()
        Me.WristValueLabel = New System.Windows.Forms.Label()
        Me.EffectorValueLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EnableCheckBox = New System.Windows.Forms.CheckBox()
        Me.TitleGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TitleGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rotation:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stretch:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Height:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Wrist:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Effector:"
        '
        'RotationValueLabel
        '
        Me.RotationValueLabel.AutoSize = True
        Me.RotationValueLabel.Location = New System.Drawing.Point(68, 2)
        Me.RotationValueLabel.Name = "RotationValueLabel"
        Me.RotationValueLabel.Size = New System.Drawing.Size(25, 13)
        Me.RotationValueLabel.TabIndex = 5
        Me.RotationValueLabel.Text = "999"
        '
        'StretchValueLabel
        '
        Me.StretchValueLabel.AutoSize = True
        Me.StretchValueLabel.Location = New System.Drawing.Point(68, 21)
        Me.StretchValueLabel.Name = "StretchValueLabel"
        Me.StretchValueLabel.Size = New System.Drawing.Size(25, 13)
        Me.StretchValueLabel.TabIndex = 6
        Me.StretchValueLabel.Text = "999"
        '
        'HeightValueLabel
        '
        Me.HeightValueLabel.AutoSize = True
        Me.HeightValueLabel.Location = New System.Drawing.Point(68, 40)
        Me.HeightValueLabel.Name = "HeightValueLabel"
        Me.HeightValueLabel.Size = New System.Drawing.Size(25, 13)
        Me.HeightValueLabel.TabIndex = 7
        Me.HeightValueLabel.Text = "999"
        '
        'WristValueLabel
        '
        Me.WristValueLabel.AutoSize = True
        Me.WristValueLabel.Location = New System.Drawing.Point(68, 59)
        Me.WristValueLabel.Name = "WristValueLabel"
        Me.WristValueLabel.Size = New System.Drawing.Size(25, 13)
        Me.WristValueLabel.TabIndex = 8
        Me.WristValueLabel.Text = "999"
        '
        'EffectorValueLabel
        '
        Me.EffectorValueLabel.AutoSize = True
        Me.EffectorValueLabel.Location = New System.Drawing.Point(68, 78)
        Me.EffectorValueLabel.Name = "EffectorValueLabel"
        Me.EffectorValueLabel.Size = New System.Drawing.Size(46, 13)
        Me.EffectorValueLabel.TabIndex = 9
        Me.EffectorValueLabel.Text = "Release"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EffectorValueLabel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.WristValueLabel, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.HeightValueLabel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.StretchValueLabel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RotationValueLabel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(128, 100)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'EnableCheckBox
        '
        Me.EnableCheckBox.AutoSize = True
        Me.EnableCheckBox.Location = New System.Drawing.Point(16, 129)
        Me.EnableCheckBox.Name = "EnableCheckBox"
        Me.EnableCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.EnableCheckBox.TabIndex = 11
        Me.EnableCheckBox.Text = "Enable"
        Me.EnableCheckBox.UseVisualStyleBackColor = True
        '
        'TitleGroupBox
        '
        Me.TitleGroupBox.Controls.Add(Me.ResetButton)
        Me.TitleGroupBox.Controls.Add(Me.EnableCheckBox)
        Me.TitleGroupBox.Controls.Add(Me.TableLayoutPanel1)
        Me.TitleGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.TitleGroupBox.Name = "TitleGroupBox"
        Me.TitleGroupBox.Size = New System.Drawing.Size(160, 160)
        Me.TitleGroupBox.TabIndex = 12
        Me.TitleGroupBox.TabStop = False
        Me.TitleGroupBox.Text = "Title"
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(82, 125)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(62, 23)
        Me.ResetButton.TabIndex = 12
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'uArmStateControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TitleGroupBox)
        Me.Name = "uArmStateControl"
        Me.Size = New System.Drawing.Size(160, 160)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TitleGroupBox.ResumeLayout(False)
        Me.TitleGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RotationValueLabel As System.Windows.Forms.Label
    Friend WithEvents StretchValueLabel As System.Windows.Forms.Label
    Friend WithEvents HeightValueLabel As System.Windows.Forms.Label
    Friend WithEvents WristValueLabel As System.Windows.Forms.Label
    Friend WithEvents EffectorValueLabel As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EnableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ResetButton As System.Windows.Forms.Button

End Class
