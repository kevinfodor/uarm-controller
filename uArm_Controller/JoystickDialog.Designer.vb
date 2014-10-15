<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JoystickDialog
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
        Me.ControllerComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox_JoystickState = New System.Windows.Forms.GroupBox()
        Me.label_POV3 = New System.Windows.Forms.Label()
        Me.label_POV2 = New System.Windows.Forms.Label()
        Me.label_POV1 = New System.Windows.Forms.Label()
        Me.label_POV0 = New System.Windows.Forms.Label()
        Me.label_Slider1 = New System.Windows.Forms.Label()
        Me.label_Slider0 = New System.Windows.Forms.Label()
        Me.label_ButtonList = New System.Windows.Forms.Label()
        Me.label_Buttons = New System.Windows.Forms.Label()
        Me.label_ZRotation = New System.Windows.Forms.Label()
        Me.label_YRotation = New System.Windows.Forms.Label()
        Me.label_XRotation = New System.Windows.Forms.Label()
        Me.label_ZAxis = New System.Windows.Forms.Label()
        Me.label_YAxis = New System.Windows.Forms.Label()
        Me.label_XAxis = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.groupBox_JoystickState.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(221, 213)
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
        'ControllerComboBox
        '
        Me.ControllerComboBox.FormattingEnabled = True
        Me.ControllerComboBox.Location = New System.Drawing.Point(15, 25)
        Me.ControllerComboBox.Name = "ControllerComboBox"
        Me.ControllerComboBox.Size = New System.Drawing.Size(195, 21)
        Me.ControllerComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Controller:"
        '
        'groupBox_JoystickState
        '
        Me.groupBox_JoystickState.Controls.Add(Me.label_POV3)
        Me.groupBox_JoystickState.Controls.Add(Me.label_POV2)
        Me.groupBox_JoystickState.Controls.Add(Me.label_POV1)
        Me.groupBox_JoystickState.Controls.Add(Me.label_POV0)
        Me.groupBox_JoystickState.Controls.Add(Me.label_Slider1)
        Me.groupBox_JoystickState.Controls.Add(Me.label_Slider0)
        Me.groupBox_JoystickState.Controls.Add(Me.label_ButtonList)
        Me.groupBox_JoystickState.Controls.Add(Me.label_Buttons)
        Me.groupBox_JoystickState.Controls.Add(Me.label_ZRotation)
        Me.groupBox_JoystickState.Controls.Add(Me.label_YRotation)
        Me.groupBox_JoystickState.Controls.Add(Me.label_XRotation)
        Me.groupBox_JoystickState.Controls.Add(Me.label_ZAxis)
        Me.groupBox_JoystickState.Controls.Add(Me.label_YAxis)
        Me.groupBox_JoystickState.Controls.Add(Me.label_XAxis)
        Me.groupBox_JoystickState.Location = New System.Drawing.Point(15, 60)
        Me.groupBox_JoystickState.Name = "groupBox_JoystickState"
        Me.groupBox_JoystickState.Size = New System.Drawing.Size(195, 183)
        Me.groupBox_JoystickState.TabIndex = 5
        Me.groupBox_JoystickState.TabStop = False
        Me.groupBox_JoystickState.Text = "Joystick Features"
        '
        'label_POV3
        '
        Me.label_POV3.AutoSize = True
        Me.label_POV3.Enabled = False
        Me.label_POV3.Location = New System.Drawing.Point(132, 128)
        Me.label_POV3.Name = "label_POV3"
        Me.label_POV3.Size = New System.Drawing.Size(41, 13)
        Me.label_POV3.TabIndex = 45
        Me.label_POV3.Text = "POV 3:"
        '
        'label_POV2
        '
        Me.label_POV2.AutoSize = True
        Me.label_POV2.Enabled = False
        Me.label_POV2.Location = New System.Drawing.Point(132, 109)
        Me.label_POV2.Name = "label_POV2"
        Me.label_POV2.Size = New System.Drawing.Size(41, 13)
        Me.label_POV2.TabIndex = 44
        Me.label_POV2.Text = "POV 2:"
        '
        'label_POV1
        '
        Me.label_POV1.AutoSize = True
        Me.label_POV1.Enabled = False
        Me.label_POV1.Location = New System.Drawing.Point(132, 90)
        Me.label_POV1.Name = "label_POV1"
        Me.label_POV1.Size = New System.Drawing.Size(41, 13)
        Me.label_POV1.TabIndex = 43
        Me.label_POV1.Text = "POV 1:"
        '
        'label_POV0
        '
        Me.label_POV0.AutoSize = True
        Me.label_POV0.Enabled = False
        Me.label_POV0.Location = New System.Drawing.Point(132, 70)
        Me.label_POV0.Name = "label_POV0"
        Me.label_POV0.Size = New System.Drawing.Size(41, 13)
        Me.label_POV0.TabIndex = 42
        Me.label_POV0.Text = "POV 0:"
        '
        'label_Slider1
        '
        Me.label_Slider1.AutoSize = True
        Me.label_Slider1.Enabled = False
        Me.label_Slider1.Location = New System.Drawing.Point(132, 41)
        Me.label_Slider1.Name = "label_Slider1"
        Me.label_Slider1.Size = New System.Drawing.Size(45, 13)
        Me.label_Slider1.TabIndex = 41
        Me.label_Slider1.Text = "Slider 1:"
        '
        'label_Slider0
        '
        Me.label_Slider0.AutoSize = True
        Me.label_Slider0.Enabled = False
        Me.label_Slider0.Location = New System.Drawing.Point(132, 23)
        Me.label_Slider0.Name = "label_Slider0"
        Me.label_Slider0.Size = New System.Drawing.Size(45, 13)
        Me.label_Slider0.TabIndex = 40
        Me.label_Slider0.Text = "Slider 0:"
        '
        'label_ButtonList
        '
        Me.label_ButtonList.Location = New System.Drawing.Point(63, 157)
        Me.label_ButtonList.Name = "label_ButtonList"
        Me.label_ButtonList.Size = New System.Drawing.Size(35, 13)
        Me.label_ButtonList.TabIndex = 33
        '
        'label_Buttons
        '
        Me.label_Buttons.AutoSize = True
        Me.label_Buttons.Location = New System.Drawing.Point(5, 157)
        Me.label_Buttons.Name = "label_Buttons"
        Me.label_Buttons.Size = New System.Drawing.Size(52, 13)
        Me.label_Buttons.TabIndex = 32
        Me.label_Buttons.Text = "Button(s):"
        '
        'label_ZRotation
        '
        Me.label_ZRotation.AutoSize = True
        Me.label_ZRotation.Enabled = False
        Me.label_ZRotation.Location = New System.Drawing.Point(5, 130)
        Me.label_ZRotation.Name = "label_ZRotation"
        Me.label_ZRotation.Size = New System.Drawing.Size(60, 13)
        Me.label_ZRotation.TabIndex = 31
        Me.label_ZRotation.Text = "Z Rotation:"
        '
        'label_YRotation
        '
        Me.label_YRotation.AutoSize = True
        Me.label_YRotation.Enabled = False
        Me.label_YRotation.Location = New System.Drawing.Point(5, 109)
        Me.label_YRotation.Name = "label_YRotation"
        Me.label_YRotation.Size = New System.Drawing.Size(60, 13)
        Me.label_YRotation.TabIndex = 30
        Me.label_YRotation.Text = "Y Rotation:"
        '
        'label_XRotation
        '
        Me.label_XRotation.AutoSize = True
        Me.label_XRotation.Enabled = False
        Me.label_XRotation.Location = New System.Drawing.Point(5, 90)
        Me.label_XRotation.Name = "label_XRotation"
        Me.label_XRotation.Size = New System.Drawing.Size(60, 13)
        Me.label_XRotation.TabIndex = 29
        Me.label_XRotation.Text = "X Rotation:"
        '
        'label_ZAxis
        '
        Me.label_ZAxis.AutoSize = True
        Me.label_ZAxis.Enabled = False
        Me.label_ZAxis.Location = New System.Drawing.Point(5, 60)
        Me.label_ZAxis.Name = "label_ZAxis"
        Me.label_ZAxis.Size = New System.Drawing.Size(39, 13)
        Me.label_ZAxis.TabIndex = 28
        Me.label_ZAxis.Text = "Z Axis:"
        '
        'label_YAxis
        '
        Me.label_YAxis.AutoSize = True
        Me.label_YAxis.Enabled = False
        Me.label_YAxis.Location = New System.Drawing.Point(5, 41)
        Me.label_YAxis.Name = "label_YAxis"
        Me.label_YAxis.Size = New System.Drawing.Size(39, 13)
        Me.label_YAxis.TabIndex = 27
        Me.label_YAxis.Text = "Y Axis:"
        '
        'label_XAxis
        '
        Me.label_XAxis.AutoSize = True
        Me.label_XAxis.Enabled = False
        Me.label_XAxis.Location = New System.Drawing.Point(5, 23)
        Me.label_XAxis.Name = "label_XAxis"
        Me.label_XAxis.Size = New System.Drawing.Size(39, 13)
        Me.label_XAxis.TabIndex = 26
        Me.label_XAxis.Text = "X Axis:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(224, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 66)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Positioning Mode"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(11, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Relative"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(11, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Absolute"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'JoystickDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(379, 254)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox_JoystickState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ControllerComboBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "JoystickDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JoystickDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.groupBox_JoystickState.ResumeLayout(False)
        Me.groupBox_JoystickState.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ControllerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents groupBox_JoystickState As System.Windows.Forms.GroupBox
    Private WithEvents label_POV3 As System.Windows.Forms.Label
    Private WithEvents label_POV2 As System.Windows.Forms.Label
    Private WithEvents label_POV1 As System.Windows.Forms.Label
    Private WithEvents label_POV0 As System.Windows.Forms.Label
    Private WithEvents label_Slider1 As System.Windows.Forms.Label
    Private WithEvents label_Slider0 As System.Windows.Forms.Label
    Private WithEvents label_ButtonList As System.Windows.Forms.Label
    Private WithEvents label_Buttons As System.Windows.Forms.Label
    Private WithEvents label_ZRotation As System.Windows.Forms.Label
    Private WithEvents label_YRotation As System.Windows.Forms.Label
    Private WithEvents label_XRotation As System.Windows.Forms.Label
    Private WithEvents label_ZAxis As System.Windows.Forms.Label
    Private WithEvents label_YAxis As System.Windows.Forms.Label
    Private WithEvents label_XAxis As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

End Class
