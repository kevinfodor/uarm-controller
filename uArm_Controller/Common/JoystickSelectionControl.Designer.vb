<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JoystickSelectionControl
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
        Me.components = New System.ComponentModel.Container()
        Me.label_POV3 = New System.Windows.Forms.Label()
        Me.label_POV2 = New System.Windows.Forms.Label()
        Me.label_POV1 = New System.Windows.Forms.Label()
        Me.label_POV0 = New System.Windows.Forms.Label()
        Me.label_Slider1 = New System.Windows.Forms.Label()
        Me.label_Slider0 = New System.Windows.Forms.Label()
        Me.label_ButtonList = New System.Windows.Forms.Label()
        Me.label_ZRotation = New System.Windows.Forms.Label()
        Me.label_XRotation = New System.Windows.Forms.Label()
        Me.label_Buttons = New System.Windows.Forms.Label()
        Me.label_YRotation = New System.Windows.Forms.Label()
        Me.label_ZAxis = New System.Windows.Forms.Label()
        Me.label_YAxis = New System.Windows.Forms.Label()
        Me.label_XAxis = New System.Windows.Forms.Label()
        Me.groupBox_JoystickState = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumberOfAxisLabel = New System.Windows.Forms.Label()
        Me.NumberButtonsLabel = New System.Windows.Forms.Label()
        Me.NumberOfPovsLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UsageIdLabel = New System.Windows.Forms.Label()
        Me.UsagePageLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HardwareRevisionLabel = New System.Windows.Forms.Label()
        Me.FirmwareVersionLabel = New System.Windows.Forms.Label()
        Me.DriverVersionLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ZAxisLabel = New System.Windows.Forms.Label()
        Me.YAxisLabel = New System.Windows.Forms.Label()
        Me.XAxisLabel = New System.Windows.Forms.Label()
        Me.ButtonsLabel = New System.Windows.Forms.Label()
        Me.TestButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControllerComboBox = New System.Windows.Forms.ComboBox()
        Me.PollTimer = New System.Windows.Forms.Timer(Me.components)
        Me.groupBox_JoystickState.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_POV3
        '
        Me.label_POV3.AutoSize = True
        Me.label_POV3.Enabled = False
        Me.label_POV3.Location = New System.Drawing.Point(133, 121)
        Me.label_POV3.Name = "label_POV3"
        Me.label_POV3.Size = New System.Drawing.Size(41, 13)
        Me.label_POV3.TabIndex = 45
        Me.label_POV3.Text = "POV 3:"
        '
        'label_POV2
        '
        Me.label_POV2.AutoSize = True
        Me.label_POV2.Enabled = False
        Me.label_POV2.Location = New System.Drawing.Point(133, 102)
        Me.label_POV2.Name = "label_POV2"
        Me.label_POV2.Size = New System.Drawing.Size(41, 13)
        Me.label_POV2.TabIndex = 44
        Me.label_POV2.Text = "POV 2:"
        '
        'label_POV1
        '
        Me.label_POV1.AutoSize = True
        Me.label_POV1.Enabled = False
        Me.label_POV1.Location = New System.Drawing.Point(133, 83)
        Me.label_POV1.Name = "label_POV1"
        Me.label_POV1.Size = New System.Drawing.Size(41, 13)
        Me.label_POV1.TabIndex = 43
        Me.label_POV1.Text = "POV 1:"
        '
        'label_POV0
        '
        Me.label_POV0.AutoSize = True
        Me.label_POV0.Enabled = False
        Me.label_POV0.Location = New System.Drawing.Point(133, 63)
        Me.label_POV0.Name = "label_POV0"
        Me.label_POV0.Size = New System.Drawing.Size(41, 13)
        Me.label_POV0.TabIndex = 42
        Me.label_POV0.Text = "POV 0:"
        '
        'label_Slider1
        '
        Me.label_Slider1.AutoSize = True
        Me.label_Slider1.Enabled = False
        Me.label_Slider1.Location = New System.Drawing.Point(133, 34)
        Me.label_Slider1.Name = "label_Slider1"
        Me.label_Slider1.Size = New System.Drawing.Size(45, 13)
        Me.label_Slider1.TabIndex = 41
        Me.label_Slider1.Text = "Slider 1:"
        '
        'label_Slider0
        '
        Me.label_Slider0.AutoSize = True
        Me.label_Slider0.Enabled = False
        Me.label_Slider0.Location = New System.Drawing.Point(133, 16)
        Me.label_Slider0.Name = "label_Slider0"
        Me.label_Slider0.Size = New System.Drawing.Size(45, 13)
        Me.label_Slider0.TabIndex = 40
        Me.label_Slider0.Text = "Slider 0:"
        '
        'label_ButtonList
        '
        Me.label_ButtonList.Location = New System.Drawing.Point(64, 150)
        Me.label_ButtonList.Name = "label_ButtonList"
        Me.label_ButtonList.Size = New System.Drawing.Size(35, 13)
        Me.label_ButtonList.TabIndex = 33
        '
        'label_ZRotation
        '
        Me.label_ZRotation.AutoSize = True
        Me.label_ZRotation.Enabled = False
        Me.label_ZRotation.Location = New System.Drawing.Point(6, 123)
        Me.label_ZRotation.Name = "label_ZRotation"
        Me.label_ZRotation.Size = New System.Drawing.Size(60, 13)
        Me.label_ZRotation.TabIndex = 31
        Me.label_ZRotation.Text = "Z Rotation:"
        '
        'label_XRotation
        '
        Me.label_XRotation.AutoSize = True
        Me.label_XRotation.Enabled = False
        Me.label_XRotation.Location = New System.Drawing.Point(6, 83)
        Me.label_XRotation.Name = "label_XRotation"
        Me.label_XRotation.Size = New System.Drawing.Size(60, 13)
        Me.label_XRotation.TabIndex = 29
        Me.label_XRotation.Text = "X Rotation:"
        '
        'label_Buttons
        '
        Me.label_Buttons.AutoSize = True
        Me.label_Buttons.Location = New System.Drawing.Point(6, 150)
        Me.label_Buttons.Name = "label_Buttons"
        Me.label_Buttons.Size = New System.Drawing.Size(52, 13)
        Me.label_Buttons.TabIndex = 32
        Me.label_Buttons.Text = "Button(s):"
        '
        'label_YRotation
        '
        Me.label_YRotation.AutoSize = True
        Me.label_YRotation.Enabled = False
        Me.label_YRotation.Location = New System.Drawing.Point(6, 102)
        Me.label_YRotation.Name = "label_YRotation"
        Me.label_YRotation.Size = New System.Drawing.Size(60, 13)
        Me.label_YRotation.TabIndex = 30
        Me.label_YRotation.Text = "Y Rotation:"
        '
        'label_ZAxis
        '
        Me.label_ZAxis.AutoSize = True
        Me.label_ZAxis.Enabled = False
        Me.label_ZAxis.Location = New System.Drawing.Point(6, 53)
        Me.label_ZAxis.Name = "label_ZAxis"
        Me.label_ZAxis.Size = New System.Drawing.Size(39, 13)
        Me.label_ZAxis.TabIndex = 28
        Me.label_ZAxis.Text = "Z Axis:"
        '
        'label_YAxis
        '
        Me.label_YAxis.AutoSize = True
        Me.label_YAxis.Enabled = False
        Me.label_YAxis.Location = New System.Drawing.Point(6, 34)
        Me.label_YAxis.Name = "label_YAxis"
        Me.label_YAxis.Size = New System.Drawing.Size(39, 13)
        Me.label_YAxis.TabIndex = 27
        Me.label_YAxis.Text = "Y Axis:"
        '
        'label_XAxis
        '
        Me.label_XAxis.AutoSize = True
        Me.label_XAxis.Enabled = False
        Me.label_XAxis.Location = New System.Drawing.Point(6, 16)
        Me.label_XAxis.Name = "label_XAxis"
        Me.label_XAxis.Size = New System.Drawing.Size(39, 13)
        Me.label_XAxis.TabIndex = 26
        Me.label_XAxis.Text = "X Axis:"
        '
        'groupBox_JoystickState
        '
        Me.groupBox_JoystickState.Controls.Add(Me.GroupBox1)
        Me.groupBox_JoystickState.Controls.Add(Me.GroupBox2)
        Me.groupBox_JoystickState.Location = New System.Drawing.Point(6, 51)
        Me.groupBox_JoystickState.Name = "groupBox_JoystickState"
        Me.groupBox_JoystickState.Size = New System.Drawing.Size(325, 340)
        Me.groupBox_JoystickState.TabIndex = 9
        Me.groupBox_JoystickState.TabStop = False
        Me.groupBox_JoystickState.Text = "Controller Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 131)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capabilities"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.69925!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.30075!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.NumberOfAxisLabel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumberButtonsLabel, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.NumberOfPovsLabel, 1, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(169, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(133, 43)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Number of Axis:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Number of Buttons:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Number of POVs"
        '
        'NumberOfAxisLabel
        '
        Me.NumberOfAxisLabel.AutoSize = True
        Me.NumberOfAxisLabel.Location = New System.Drawing.Point(109, 0)
        Me.NumberOfAxisLabel.Name = "NumberOfAxisLabel"
        Me.NumberOfAxisLabel.Size = New System.Drawing.Size(10, 13)
        Me.NumberOfAxisLabel.TabIndex = 53
        Me.NumberOfAxisLabel.Text = "-"
        '
        'NumberButtonsLabel
        '
        Me.NumberButtonsLabel.AutoSize = True
        Me.NumberButtonsLabel.Location = New System.Drawing.Point(109, 13)
        Me.NumberButtonsLabel.Name = "NumberButtonsLabel"
        Me.NumberButtonsLabel.Size = New System.Drawing.Size(10, 13)
        Me.NumberButtonsLabel.TabIndex = 47
        Me.NumberButtonsLabel.Text = "-"
        '
        'NumberOfPovsLabel
        '
        Me.NumberOfPovsLabel.AutoSize = True
        Me.NumberOfPovsLabel.Location = New System.Drawing.Point(109, 26)
        Me.NumberOfPovsLabel.Name = "NumberOfPovsLabel"
        Me.NumberOfPovsLabel.Size = New System.Drawing.Size(10, 13)
        Me.NumberOfPovsLabel.TabIndex = 54
        Me.NumberOfPovsLabel.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Usage:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.85714!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.14286!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.UsageIdLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.UsagePageLabel, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 89)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(140, 31)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Usage-Id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Usage Page"
        '
        'UsageIdLabel
        '
        Me.UsageIdLabel.AutoSize = True
        Me.UsageIdLabel.Location = New System.Drawing.Point(83, 0)
        Me.UsageIdLabel.Name = "UsageIdLabel"
        Me.UsageIdLabel.Size = New System.Drawing.Size(10, 13)
        Me.UsageIdLabel.TabIndex = 58
        Me.UsageIdLabel.Text = "-"
        '
        'UsagePageLabel
        '
        Me.UsagePageLabel.AutoSize = True
        Me.UsagePageLabel.Location = New System.Drawing.Point(83, 13)
        Me.UsagePageLabel.Name = "UsagePageLabel"
        Me.UsagePageLabel.Size = New System.Drawing.Size(10, 13)
        Me.UsagePageLabel.TabIndex = 59
        Me.UsagePageLabel.Text = "-"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.9726!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0274!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.HardwareRevisionLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FirmwareVersionLabel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DriverVersionLabel, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 44)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Hardware Revision:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Firmware Version"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Driver Version"
        '
        'HardwareRevisionLabel
        '
        Me.HardwareRevisionLabel.AutoSize = True
        Me.HardwareRevisionLabel.Location = New System.Drawing.Point(111, 0)
        Me.HardwareRevisionLabel.Name = "HardwareRevisionLabel"
        Me.HardwareRevisionLabel.Size = New System.Drawing.Size(10, 13)
        Me.HardwareRevisionLabel.TabIndex = 50
        Me.HardwareRevisionLabel.Text = "-"
        '
        'FirmwareVersionLabel
        '
        Me.FirmwareVersionLabel.AutoSize = True
        Me.FirmwareVersionLabel.Location = New System.Drawing.Point(111, 13)
        Me.FirmwareVersionLabel.Name = "FirmwareVersionLabel"
        Me.FirmwareVersionLabel.Size = New System.Drawing.Size(10, 13)
        Me.FirmwareVersionLabel.TabIndex = 51
        Me.FirmwareVersionLabel.Text = "-"
        '
        'DriverVersionLabel
        '
        Me.DriverVersionLabel.AutoSize = True
        Me.DriverVersionLabel.Location = New System.Drawing.Point(111, 26)
        Me.DriverVersionLabel.Name = "DriverVersionLabel"
        Me.DriverVersionLabel.Size = New System.Drawing.Size(10, 13)
        Me.DriverVersionLabel.TabIndex = 52
        Me.DriverVersionLabel.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ZAxisLabel)
        Me.GroupBox2.Controls.Add(Me.label_XAxis)
        Me.GroupBox2.Controls.Add(Me.label_YAxis)
        Me.GroupBox2.Controls.Add(Me.YAxisLabel)
        Me.GroupBox2.Controls.Add(Me.label_ZAxis)
        Me.GroupBox2.Controls.Add(Me.XAxisLabel)
        Me.GroupBox2.Controls.Add(Me.label_XRotation)
        Me.GroupBox2.Controls.Add(Me.ButtonsLabel)
        Me.GroupBox2.Controls.Add(Me.label_YRotation)
        Me.GroupBox2.Controls.Add(Me.label_POV3)
        Me.GroupBox2.Controls.Add(Me.label_ZRotation)
        Me.GroupBox2.Controls.Add(Me.label_POV2)
        Me.GroupBox2.Controls.Add(Me.label_Buttons)
        Me.GroupBox2.Controls.Add(Me.label_POV1)
        Me.GroupBox2.Controls.Add(Me.label_ButtonList)
        Me.GroupBox2.Controls.Add(Me.label_POV0)
        Me.GroupBox2.Controls.Add(Me.label_Slider0)
        Me.GroupBox2.Controls.Add(Me.label_Slider1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 170)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Real-Time"
        '
        'ZAxisLabel
        '
        Me.ZAxisLabel.AutoSize = True
        Me.ZAxisLabel.Location = New System.Drawing.Point(54, 53)
        Me.ZAxisLabel.Name = "ZAxisLabel"
        Me.ZAxisLabel.Size = New System.Drawing.Size(10, 13)
        Me.ZAxisLabel.TabIndex = 12
        Me.ZAxisLabel.Text = "-"
        '
        'YAxisLabel
        '
        Me.YAxisLabel.AutoSize = True
        Me.YAxisLabel.Location = New System.Drawing.Point(54, 34)
        Me.YAxisLabel.Name = "YAxisLabel"
        Me.YAxisLabel.Size = New System.Drawing.Size(10, 13)
        Me.YAxisLabel.TabIndex = 11
        Me.YAxisLabel.Text = "-"
        '
        'XAxisLabel
        '
        Me.XAxisLabel.AutoSize = True
        Me.XAxisLabel.Location = New System.Drawing.Point(54, 16)
        Me.XAxisLabel.Name = "XAxisLabel"
        Me.XAxisLabel.Size = New System.Drawing.Size(10, 13)
        Me.XAxisLabel.TabIndex = 10
        Me.XAxisLabel.Text = "-"
        '
        'ButtonsLabel
        '
        Me.ButtonsLabel.AutoSize = True
        Me.ButtonsLabel.Location = New System.Drawing.Point(60, 150)
        Me.ButtonsLabel.Name = "ButtonsLabel"
        Me.ButtonsLabel.Size = New System.Drawing.Size(45, 13)
        Me.ButtonsLabel.TabIndex = 55
        Me.ButtonsLabel.Text = "<None>"
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(239, 16)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(75, 23)
        Me.TestButton.TabIndex = 60
        Me.TestButton.Text = "Test"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Controller:"
        '
        'ControllerComboBox
        '
        Me.ControllerComboBox.FormattingEnabled = True
        Me.ControllerComboBox.Location = New System.Drawing.Point(6, 16)
        Me.ControllerComboBox.Name = "ControllerComboBox"
        Me.ControllerComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ControllerComboBox.TabIndex = 7
        '
        'PollTimer
        '
        '
        'JoystickSelectionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.groupBox_JoystickState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.ControllerComboBox)
        Me.Name = "JoystickSelectionControl"
        Me.Size = New System.Drawing.Size(334, 391)
        Me.groupBox_JoystickState.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label_POV3 As System.Windows.Forms.Label
    Private WithEvents label_POV2 As System.Windows.Forms.Label
    Private WithEvents label_POV1 As System.Windows.Forms.Label
    Private WithEvents label_POV0 As System.Windows.Forms.Label
    Private WithEvents label_Slider1 As System.Windows.Forms.Label
    Private WithEvents label_Slider0 As System.Windows.Forms.Label
    Private WithEvents label_ButtonList As System.Windows.Forms.Label
    Private WithEvents label_ZRotation As System.Windows.Forms.Label
    Private WithEvents label_XRotation As System.Windows.Forms.Label
    Private WithEvents label_Buttons As System.Windows.Forms.Label
    Private WithEvents label_YRotation As System.Windows.Forms.Label
    Private WithEvents label_ZAxis As System.Windows.Forms.Label
    Private WithEvents label_YAxis As System.Windows.Forms.Label
    Private WithEvents label_XAxis As System.Windows.Forms.Label
    Private WithEvents groupBox_JoystickState As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ControllerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumberButtonsLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DriverVersionLabel As System.Windows.Forms.Label
    Friend WithEvents FirmwareVersionLabel As System.Windows.Forms.Label
    Friend WithEvents HardwareRevisionLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfPovsLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfAxisLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonsLabel As System.Windows.Forms.Label
    Friend WithEvents UsagePageLabel As System.Windows.Forms.Label
    Friend WithEvents UsageIdLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TestButton As System.Windows.Forms.Button
    Friend WithEvents PollTimer As System.Windows.Forms.Timer
    Friend WithEvents ZAxisLabel As System.Windows.Forms.Label
    Friend WithEvents YAxisLabel As System.Windows.Forms.Label
    Friend WithEvents XAxisLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
