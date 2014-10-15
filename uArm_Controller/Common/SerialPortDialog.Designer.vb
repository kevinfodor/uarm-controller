<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialPortDialog
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me._PortName = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me._BaudRate = New System.Windows.Forms.ComboBox()
        Me.comPort = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(34, 137)
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
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me._PortName)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me._BaudRate)
        Me.groupBox1.Controls.Add(Me.comPort)
        Me.groupBox1.Font = New System.Drawing.Font("Calibri", 10.5!)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(172, 111)
        Me.groupBox1.TabIndex = 38
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Port Setting"
        '
        '_PortName
        '
        Me._PortName.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me._PortName.FormattingEnabled = True
        Me._PortName.Location = New System.Drawing.Point(76, 27)
        Me._PortName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me._PortName.Name = "_PortName"
        Me._PortName.Size = New System.Drawing.Size(79, 26)
        Me._PortName.TabIndex = 28
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.label2.Location = New System.Drawing.Point(11, 71)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 18)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Baudrate"
        '
        '_BaudRate
        '
        Me._BaudRate.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me._BaudRate.FormattingEnabled = True
        Me._BaudRate.Items.AddRange(New Object() {"75", "110", "134", "150", "300", "600", "1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "38400", "57600", "115200", "128000"})
        Me._BaudRate.Location = New System.Drawing.Point(76, 68)
        Me._BaudRate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me._BaudRate.Name = "_BaudRate"
        Me._BaudRate.Size = New System.Drawing.Size(79, 26)
        Me._BaudRate.TabIndex = 29
        Me._BaudRate.Text = "9600"
        '
        'comPort
        '
        Me.comPort.AutoSize = True
        Me.comPort.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.comPort.Location = New System.Drawing.Point(11, 30)
        Me.comPort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.comPort.Name = "comPort"
        Me.comPort.Size = New System.Drawing.Size(34, 18)
        Me.comPort.TabIndex = 1
        Me.comPort.Text = "Port"
        '
        'SerialPortDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(192, 178)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SerialPortDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Serial Port Configuration"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents _PortName As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents _BaudRate As System.Windows.Forms.ComboBox
    Private WithEvents comPort As System.Windows.Forms.Label

End Class
