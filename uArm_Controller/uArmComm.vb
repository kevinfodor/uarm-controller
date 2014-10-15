'==============================================================================

'BSD License
'-----------

'Copyright (c) 2014, and Kevin Fodor, All rights reserved.

'Redistribution and use in source and binary forms, with or without
'modification, are permitted provided that the following conditions are met:

'- Redistributions of source code must retain the above copyright notice,
'this list of conditions and the following disclaimer.

'- Redistributions in binary form must reproduce the above copyright notice,
'this list of conditions and the following disclaimer in the documentation
'and/or other materials provided with the distribution.

'- Neither the name of Kevin Fodor nor the names of
'its contributors may be used to endorse or promote products derived from
'this software without specific prior written permission.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
'AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
'IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
'ARE DISCLAIMED.  IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
'LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
'CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
'SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
'INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
'CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
'ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
'POSSIBILITY OF SUCH DAMAGE.

'NOTICE:
'SOME OF THIS CODE MAY HAVE ELEMENTS TAKEN FROM OTHER CODE WITHOUT ATTRIBUTION.
'IF THIS IS THE CASE IT WAS DUE TO OVERSIGHT WHILE DEBUGGING AND I APOLOGIZE.
'IF ANYONE HAS ANY REASON TO BELIEVE THAT ANY OF THIS CODE VIOLATES OTHER
'LICENSES PLEASE CONTACT ME WITH DETAILS SO THAT I MAY CORRECT THE SITUATION.

'==============================================================================

Imports System.IO.Ports.SerialPort
Imports System.IO.Ports
Imports System.Threading
Imports uArm_Controller.Utilities.Ranges

Namespace uArm

    ' This is a simple uArm class which is used to interface
    ' directly with a uArm.
    Public Class Comm

#Region "Public Region"

        ' New method
        Sub New()

            ' Zero initialize frame
            For Each data As Byte In _frame
                data = 0
            Next

            ' Populate frame header
            _frame(0) = Convert.ToByte(&HFF)
            _frame(1) = Convert.ToByte(&HAA)

        End Sub

        Public Function Connect(ByVal port As String, ByVal rate As Integer) As Boolean
            Dim connected As Boolean = False
            Try
                If port Is Nothing OrElse rate = 0 Then
                    Throw New Exception("Invalid parameters.")
                End If

                If _serialPort Is Nothing Then
                    _serialPort = New SerialPort()
                End If

                If _serialPort.IsOpen = False Then
                    ' Apply user provided properties.
                    _serialPort.PortName = port
                    _serialPort.BaudRate = rate

                    ' Apply fixed properties
                    _serialPort.Parity = System.IO.Ports.Parity.None
                    _serialPort.DataBits = 8
                    _serialPort.StopBits = System.IO.Ports.StopBits.One
                    _serialPort.Handshake = System.IO.Ports.Handshake.None

                    ' Set the read/write timeouts
                    _serialPort.ReadTimeout = 1000
                    _serialPort.WriteTimeout = 1000

                    ' Open serial port
                    _serialPort.Open()

                    ' Send frame
                    _serialPort.Write(_frame, 0, _frame.Length)
                End If
                connected = True
            Catch err As Exception
                MessageBox.Show(err.Message, _classId)
            End Try
            Return connected
        End Function

        Public Sub Disconnect()
            If _serialPort IsNot Nothing Then
                If _serialPort.IsOpen = True Then
                    ' Close the serial port
                    _serialPort.Close()
                End If
            End If
        End Sub

        Public Function IsConnected() As Boolean
            Dim connected As Boolean = False
            If _serialPort IsNot Nothing Then
                connected = _serialPort.IsOpen
            End If
            Return connected
        End Function

        Public Sub Send(ByRef state As State)
            If IsConnected() Then
                ' Update latest position demand
                UpdateFrame(state)

                ' Send frame
                _serialPort.Write(_frame, 0, _frame.Length)
            End If
        End Sub

        Public Sub Run(ByVal rate_msec As Integer)
            ' Set the rate
            _rate_msec = rate_msec
            If _serialTxthread Is Nothing Then
                ' Create serial tx thread.
                _serialTxthread = New Thread(AddressOf SerialTxThread)
                ' Start the serial tx thread
                _serialTxthread.Start()
            End If
        End Sub

        Public Sub Kill()
            If _serialTxthread IsNot Nothing Then
                ' Cancel the asynchronous operation.
                _stop_requested = True
                _serialTxthread.Abort()
                Do
                    Thread.Sleep(_rate_msec)
                Loop While ((_serialTxthread.ThreadState And _
                             (ThreadState.Unstarted Or ThreadState.Aborted Or ThreadState.Stopped)) = 0)
                _stop_requested = False
                _serialTxthread = Nothing
            End If
        End Sub

#End Region

#Region "Private Region"

        ' Class identifier
        Private Const _classId As String = "Comm"

        Private Enum ControlByte
            NO_CHANGE = 0
            GRIP = 1 << 0
            RELEASE = 1 << 1
            SPARE2 = 1 << 2
            SPARE3 = 1 << 3
            RIGHT_BUTTON_HOLD = 1 << 4
            SPARE5 = 1 << 5
            MOUSE_PLUS = 1 << 6
            MOUSE_MINUS = 1 << 7
        End Enum

        ' Initialize the uArm control byte
        Private _control As ControlByte = ControlByte.NO_CHANGE

        ' Create a serial port object with events
        Private WithEvents _serialPort As SerialPort = Nothing

        ' Create the thread object for handling uArm updates
        ' and posting them to the uArm via the serial port.
        Private _serialTxthread As Thread = Nothing
        Private _stop_requested As Boolean = False
        Private _rate_msec As Integer = My.Settings.UpdateRate

        ' Tx Frame memory
        Private _frame(10) As Byte ' 11 bytes

        Private Sub UpdateFrame(ByRef state As State)
            ' There are 11 bytes that make up each data frame (5 values).
            ' Note: Frame header has already been populated.

            ' base rotation
            _frame(2) = Bytes.MSB(state.Rotation)
            _frame(3) = Bytes.LSB(state.Rotation)
            ' arm stretch
            _frame(4) = Bytes.MSB(state.Stretch)
            _frame(5) = Bytes.LSB(state.Stretch)
            ' arm height
            _frame(6) = Bytes.MSB(state.Height)
            _frame(7) = Bytes.LSB(state.Height)
            ' wrist rotation
            _frame(8) = Bytes.MSB(state.Wrist)
            _frame(9) = Bytes.LSB(state.Wrist)
            ' grip and mouse control
            If state.Effector Then
                _control = ControlByte.GRIP
            Else
                _control = ControlByte.RELEASE
            End If
            _frame(10) = Convert.ToByte(_control)

        End Sub

        ' The method that will be called when the thread is started. 
        Private Sub SerialTxThread()

            Do
                ' Send frame containing lastest position demand
                _serialPort.Write(_frame, 0, _frame.Length)

                ' Pause for a moment to provide a delay.
                Thread.Sleep(_rate_msec)

            Loop While (Not _stop_requested)

        End Sub

#End Region

    End Class
End Namespace
