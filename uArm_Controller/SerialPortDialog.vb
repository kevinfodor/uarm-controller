Imports System.Windows.Forms

Public Class SerialPortDialog

    Private _portValue As String = ""
    Public Property PortName() As String
        Get
            Return _portValue
        End Get
        Set(ByVal value As String)
            _portValue = value
        End Set
    End Property

    Private _rateValue As Integer = 9600
    Public Property Rate() As Integer
        Get
            Return _rateValue
        End Get
        Set(ByVal value As Integer)
            _rateValue = value
        End Set
    End Property

    Public Sub New(ByVal port As String, ByVal rate As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        'Load values provided as defaults
        _portValue = port
        _rateValue = rate

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub SerialPortDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Populate list of ports
            For Each com As String In System.IO.Ports.SerialPort.GetPortNames()
                _PortName.Items.Add(com)
            Next

            If _PortName.Items.Count() > 0 Then
                Dim index As Integer
                index = _PortName.FindStringExact(_portValue)
                If index <> ListBox.NoMatches Then
                    _PortName.SelectedIndex = index
                Else
                    _PortName.SelectedIndex = 0
                End If
                PortName = _PortName.SelectedItem

                index = _BaudRate.FindStringExact(_rateValue.ToString)
                If index <> ListBox.NoMatches Then
                    _BaudRate.SelectedIndex = index
                Else
                    _BaudRate.SelectedIndex = 0
                End If
                Rate = CInt(_BaudRate.SelectedItem)
            Else
                MessageBox.Show("No ports found!", Me.Text)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
            Me.Close()
        End Try

    End Sub

    Private Sub _PortName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BaudRate.SelectedIndexChanged
        PortName = _PortName.SelectedItem
    End Sub

    Private Sub _BaudRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BaudRate.SelectedIndexChanged
        Rate = CInt(_BaudRate.SelectedItem)
    End Sub

End Class
