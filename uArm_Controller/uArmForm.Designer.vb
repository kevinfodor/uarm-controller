<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uArmForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uArmForm))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.EffectorLabel = New System.Windows.Forms.Label()
        Me.r_label = New System.Windows.Forms.Label()
        Me.StretchLabel = New System.Windows.Forms.Label()
        Me.EffectorCheckBox = New System.Windows.Forms.CheckBox()
        Me.RotationLabel = New System.Windows.Forms.Label()
        Me.WristLabel = New System.Windows.Forms.Label()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.WristTrackBar = New System.Windows.Forms.TrackBar()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.RotationTrackBar = New System.Windows.Forms.TrackBar()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JoystickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StretchTrackBar = New System.Windows.Forms.TrackBar()
        Me.HeightTrackBar = New System.Windows.Forms.TrackBar()
        Me.CommandTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.JoystickToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.uArmLogControl = New uArm_Controller.uArmLogControl()
        Me.SerialOut = New uArm_Controller.uArmStateControl()
        Me.TrimmerIn = New uArm_Controller.uArmStateControl()
        Me.JstickIn = New uArm_Controller.uArmStateControl()
        Me.groupBox1.SuspendLayout()
        CType(Me.WristTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotationTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.StretchTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.InputsGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.EffectorLabel)
        Me.groupBox1.Controls.Add(Me.r_label)
        Me.groupBox1.Controls.Add(Me.StretchLabel)
        Me.groupBox1.Controls.Add(Me.EffectorCheckBox)
        Me.groupBox1.Controls.Add(Me.RotationLabel)
        Me.groupBox1.Controls.Add(Me.WristLabel)
        Me.groupBox1.Controls.Add(Me.HeightLabel)
        Me.groupBox1.Controls.Add(Me.WristTrackBar)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.label19)
        Me.groupBox1.Controls.Add(Me.RotationTrackBar)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.groupBox1.Location = New System.Drawing.Point(13, 27)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(178, 362)
        Me.groupBox1.TabIndex = 25
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Trimmers"
        '
        'EffectorLabel
        '
        Me.EffectorLabel.AutoSize = True
        Me.EffectorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EffectorLabel.Location = New System.Drawing.Point(94, 336)
        Me.EffectorLabel.Name = "EffectorLabel"
        Me.EffectorLabel.Size = New System.Drawing.Size(46, 13)
        Me.EffectorLabel.TabIndex = 12
        Me.EffectorLabel.Text = "Release"
        '
        'r_label
        '
        Me.r_label.AutoSize = True
        Me.r_label.Font = New System.Drawing.Font("Calibri", 10.5!)
        Me.r_label.Location = New System.Drawing.Point(60, 65)
        Me.r_label.Name = "r_label"
        Me.r_label.Size = New System.Drawing.Size(0, 17)
        Me.r_label.TabIndex = 18
        '
        'StretchLabel
        '
        Me.StretchLabel.AutoSize = True
        Me.StretchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StretchLabel.Location = New System.Drawing.Point(60, 26)
        Me.StretchLabel.Name = "StretchLabel"
        Me.StretchLabel.Size = New System.Drawing.Size(13, 13)
        Me.StretchLabel.TabIndex = 14
        Me.StretchLabel.Text = "0"
        '
        'EffectorCheckBox
        '
        Me.EffectorCheckBox.AutoSize = True
        Me.EffectorCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EffectorCheckBox.Location = New System.Drawing.Point(12, 335)
        Me.EffectorCheckBox.Name = "EffectorCheckBox"
        Me.EffectorCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.EffectorCheckBox.TabIndex = 33
        Me.EffectorCheckBox.Text = "Effector:"
        Me.EffectorCheckBox.UseVisualStyleBackColor = True
        '
        'RotationLabel
        '
        Me.RotationLabel.AutoSize = True
        Me.RotationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RotationLabel.Location = New System.Drawing.Point(81, 198)
        Me.RotationLabel.Name = "RotationLabel"
        Me.RotationLabel.Size = New System.Drawing.Size(13, 13)
        Me.RotationLabel.TabIndex = 13
        Me.RotationLabel.Text = "0"
        '
        'WristLabel
        '
        Me.WristLabel.AutoSize = True
        Me.WristLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WristLabel.Location = New System.Drawing.Point(62, 261)
        Me.WristLabel.Name = "WristLabel"
        Me.WristLabel.Size = New System.Drawing.Size(13, 13)
        Me.WristLabel.TabIndex = 35
        Me.WristLabel.Text = "0"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.HeightLabel.Location = New System.Drawing.Point(143, 25)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(13, 13)
        Me.HeightLabel.TabIndex = 17
        Me.HeightLabel.Text = "0"
        '
        'WristTrackBar
        '
        Me.WristTrackBar.Location = New System.Drawing.Point(11, 281)
        Me.WristTrackBar.Maximum = 100
        Me.WristTrackBar.Name = "WristTrackBar"
        Me.WristTrackBar.Size = New System.Drawing.Size(140, 45)
        Me.WristTrackBar.TabIndex = 30
        Me.WristTrackBar.Tag = "WristLable"
        Me.WristTrackBar.TickFrequency = 10
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label7.Location = New System.Drawing.Point(14, 198)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(50, 13)
        Me.label7.TabIndex = 16
        Me.label7.Text = "Rotation:"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label19.Location = New System.Drawing.Point(14, 261)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(34, 13)
        Me.label19.TabIndex = 34
        Me.label19.Text = "Wrist:"
        '
        'RotationTrackBar
        '
        Me.RotationTrackBar.Location = New System.Drawing.Point(11, 218)
        Me.RotationTrackBar.Maximum = 100
        Me.RotationTrackBar.Name = "RotationTrackBar"
        Me.RotationTrackBar.Size = New System.Drawing.Size(140, 45)
        Me.RotationTrackBar.TabIndex = 29
        Me.RotationTrackBar.TickFrequency = 10
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label6.Location = New System.Drawing.Point(22, 53)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(44, 13)
        Me.label6.TabIndex = 15
        Me.label6.Text = "Stretch:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label2.Location = New System.Drawing.Point(105, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(41, 13)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Height:"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConfigureToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip.TabIndex = 26
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveSettingsToolStripMenuItem, Me.ResetSettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveSettingsToolStripMenuItem
        '
        Me.SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'ResetSettingsToolStripMenuItem
        '
        Me.ResetSettingsToolStripMenuItem.Name = "ResetSettingsToolStripMenuItem"
        Me.ResetSettingsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ResetSettingsToolStripMenuItem.Text = "Reset Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ConfigureToolStripMenuItem
        '
        Me.ConfigureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialPortToolStripMenuItem, Me.JoystickToolStripMenuItem, Me.UpdateRateToolStripMenuItem})
        Me.ConfigureToolStripMenuItem.Name = "ConfigureToolStripMenuItem"
        Me.ConfigureToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ConfigureToolStripMenuItem.Text = "&Configure"
        '
        'SerialPortToolStripMenuItem
        '
        Me.SerialPortToolStripMenuItem.Name = "SerialPortToolStripMenuItem"
        Me.SerialPortToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SerialPortToolStripMenuItem.Text = "Serial Port"
        '
        'JoystickToolStripMenuItem
        '
        Me.JoystickToolStripMenuItem.Name = "JoystickToolStripMenuItem"
        Me.JoystickToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.JoystickToolStripMenuItem.Text = "Joystick"
        '
        'UpdateRateToolStripMenuItem
        '
        Me.UpdateRateToolStripMenuItem.Name = "UpdateRateToolStripMenuItem"
        Me.UpdateRateToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.UpdateRateToolStripMenuItem.Text = "Update Rate"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'StretchTrackBar
        '
        Me.StretchTrackBar.Location = New System.Drawing.Point(42, 73)
        Me.StretchTrackBar.Maximum = 100
        Me.StretchTrackBar.Name = "StretchTrackBar"
        Me.StretchTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.StretchTrackBar.Size = New System.Drawing.Size(45, 140)
        Me.StretchTrackBar.TabIndex = 27
        Me.StretchTrackBar.TickFrequency = 10
        '
        'HeightTrackBar
        '
        Me.HeightTrackBar.Location = New System.Drawing.Point(126, 73)
        Me.HeightTrackBar.Maximum = 100
        Me.HeightTrackBar.Name = "HeightTrackBar"
        Me.HeightTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.HeightTrackBar.Size = New System.Drawing.Size(45, 140)
        Me.HeightTrackBar.TabIndex = 28
        Me.HeightTrackBar.TickFrequency = 10
        '
        'CommandTimer
        '
        Me.CommandTimer.Interval = 20
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.SerialToolStripStatusLabel, Me.ToolStripStatusLabel2, Me.JoystickToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 395)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(754, 22)
        Me.StatusStrip.TabIndex = 43
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel1.Text = "Serial Port: "
        '
        'SerialToolStripStatusLabel
        '
        Me.SerialToolStripStatusLabel.Name = "SerialToolStripStatusLabel"
        Me.SerialToolStripStatusLabel.Size = New System.Drawing.Size(36, 17)
        Me.SerialToolStripStatusLabel.Text = "None"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(89, 17)
        Me.ToolStripStatusLabel2.Text = "Joystick Device:"
        '
        'JoystickToolStripStatusLabel
        '
        Me.JoystickToolStripStatusLabel.Name = "JoystickToolStripStatusLabel"
        Me.JoystickToolStripStatusLabel.Size = New System.Drawing.Size(36, 17)
        Me.JoystickToolStripStatusLabel.Text = "None"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(64, 23)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 23)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(60, 23)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(104, 23)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'InputsGroupBox
        '
        Me.InputsGroupBox.Controls.Add(Me.TrimmerIn)
        Me.InputsGroupBox.Controls.Add(Me.JstickIn)
        Me.InputsGroupBox.Location = New System.Drawing.Point(197, 28)
        Me.InputsGroupBox.Name = "InputsGroupBox"
        Me.InputsGroupBox.Size = New System.Drawing.Size(353, 192)
        Me.InputsGroupBox.TabIndex = 45
        Me.InputsGroupBox.TabStop = False
        Me.InputsGroupBox.Text = "Inputs"
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.SerialOut)
        Me.OutputGroupBox.Location = New System.Drawing.Point(556, 27)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(182, 193)
        Me.OutputGroupBox.TabIndex = 46
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Output"
        '
        'uArmLogControl
        '
        Me.uArmLogControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uArmLogControl.Location = New System.Drawing.Point(197, 227)
        Me.uArmLogControl.Name = "uArmLogControl"
        Me.uArmLogControl.Size = New System.Drawing.Size(541, 162)
        Me.uArmLogControl.TabIndex = 47
        '
        'SerialOut
        '
        Me.SerialOut.Location = New System.Drawing.Point(12, 21)
        Me.SerialOut.Name = "SerialOut"
        Me.SerialOut.Size = New System.Drawing.Size(164, 160)
        Me.SerialOut.TabIndex = 36
        '
        'TrimmerIn
        '
        Me.TrimmerIn.Location = New System.Drawing.Point(7, 20)
        Me.TrimmerIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TrimmerIn.Name = "TrimmerIn"
        Me.TrimmerIn.Size = New System.Drawing.Size(164, 160)
        Me.TrimmerIn.TabIndex = 38
        '
        'JstickIn
        '
        Me.JstickIn.Location = New System.Drawing.Point(177, 20)
        Me.JstickIn.Name = "JstickIn"
        Me.JstickIn.Size = New System.Drawing.Size(167, 163)
        Me.JstickIn.TabIndex = 37
        '
        'uArmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 417)
        Me.Controls.Add(Me.uArmLogControl)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputsGroupBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.HeightTrackBar)
        Me.Controls.Add(Me.StretchTrackBar)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(770, 455)
        Me.Name = "uArmForm"
        Me.Text = "uArm Controller"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.WristTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotationTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.StretchTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.InputsGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents WristLabel As System.Windows.Forms.Label
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents RotationLabel As System.Windows.Forms.Label
    Public WithEvents r_label As System.Windows.Forms.Label
    Private WithEvents EffectorLabel As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents StretchLabel As System.Windows.Forms.Label
    Private WithEvents HeightLabel As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StretchTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents HeightTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents RotationTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents WristTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents CommandTimer As System.Windows.Forms.Timer
    Friend WithEvents SerialPortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EffectorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JoystickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialOut As uArm_Controller.uArmStateControl
    Friend WithEvents JstickIn As uArm_Controller.uArmStateControl
    Friend WithEvents TrimmerIn As uArm_Controller.uArmStateControl
    Friend WithEvents ResetSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents JoystickToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SerialToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UpdateRateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents OutputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents uArmLogControl As uArm_Controller.uArmLogControl

End Class
