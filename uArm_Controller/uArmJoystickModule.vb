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

Imports SlimDX.DirectInput
Imports uArm_Controller.uArm
Imports uArm_Controller.Processing
Imports uArm_Controller.Utilities.Ranges
Imports uArm_Controller.uArm.State

Namespace uArm

    Class JoystickModule
        Implements IDisposable

#Region "Joystick Handlers"

        ' Input devices
        Private WithEvents m_joystick As JoystickDevice = Nothing

        ' Input state
        Private WithEvents m_state_control As uArmStateControl = Nothing

        ' One shot state variable
        Private m_trigger As OneShot = Nothing

        ' Axis action ranges (response)
        Shared ReadOnly Axis_Range As Range(Of Integer) = _
            New Range(Of Integer)(-1000, 1000, 0)

        ' Axis fast/slow ranges
        Shared ReadOnly Axis_Fast_Inc As Range(Of Integer) = _
            New Range(Of Integer)(901, 1000, 5)
        Shared ReadOnly Axis_Slow_Inc As Range(Of Integer) = _
            New Range(Of Integer)(300, 900, 1)
        Shared ReadOnly Axis_Slow_Dec As Range(Of Integer) = _
            New Range(Of Integer)(-900, -300, 1)
        Shared ReadOnly Axis_Fast_Dec As Range(Of Integer) = _
            New Range(Of Integer)(-1000, -901, 5)

        Public ReadOnly Property Device() As JoystickDevice
            Get
                Return m_joystick
            End Get
        End Property

        Public ReadOnly Property Name() As String
            Get
                Return m_joystick.Name
            End Get
        End Property

        Public ReadOnly Property Guid() As System.Guid
            Get
                Return m_joystick.Guid
            End Get
        End Property

        Private _absolute_mode As Boolean = False
        Public Property IsAbsolute() As Boolean
            Get
                Return _absolute_mode
            End Get
            Set(ByVal value As Boolean)
                _absolute_mode = value
            End Set
        End Property

        Public Property IsRelative() As Boolean
            Get
                Return Not _absolute_mode
            End Get
            Set(ByVal value As Boolean)
                _absolute_mode = Not value
            End Set
        End Property

        Sub New(ByRef state_control As uArm_Controller.uArmStateControl)
            m_state_control = state_control
            m_joystick = New JoystickDevice
            m_trigger = New OneShot
            Configure()
        End Sub

        Private Sub JoystickHandler(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
            m_joystick.InputChanged

            '*************************************************
            'TODO: Place any specific joystick handling here!
            'In the future this hanlding will be more generic
            'but for now it is pretty much hardcoded
            '*************************************************

            Const TRIGGER As Integer = 0
            Const HAT_DOWN As Integer = 1
            Const HAT_UP As Integer = 2
            Const HAT_LEFT As Integer = 3
            Const HAT_RIGHT As Integer = 4
            Const LEFT_UP As Integer = 5
            Const LEFT_DOWN As Integer = 6
            Const BOTTOM_LEFT As Integer = 7
            Const BOTTOM_RIGHT As Integer = 8
            Const RIGHT_UP As Integer = 9
            Const RIGHT_DOWN As Integer = 10

            ' Process axis...
            ' All joysticks have X and Y axis. some have Z-axis
            ' X-Axis is 'Rotation'
            ' Y-Axis is 'Stretch'
            ' Z-Axis is 'Wrist'

            If _absolute_mode = True Then

                m_state_control.State.Rotation = m_joystick.State.X
                m_state_control.State.Stretch = m_joystick.State.Y
                m_state_control.State.Wrist = m_joystick.State.Z

            Else ' Relative

                ' X-Axis
                If Axis_Fast_Inc.Within(m_joystick.State.X) Then
                    m_state_control.State.Rotation += Axis_Fast_Inc.Nominal
                ElseIf Axis_Slow_Inc.Within(m_joystick.State.X) Then
                    m_state_control.State.Rotation += Axis_Slow_Inc.Nominal
                ElseIf Axis_Slow_Dec.Within(m_joystick.State.X) Then
                    m_state_control.State.Rotation -= Axis_Slow_Dec.Nominal
                ElseIf Axis_Fast_Dec.Within(m_joystick.State.X) Then
                    m_state_control.State.Rotation -= Axis_Fast_Dec.Nominal
                End If

                ' Y-Axis
                If Axis_Fast_Inc.Within(m_joystick.State.Y) Then
                    m_state_control.State.Stretch += Axis_Fast_Inc.Nominal
                ElseIf Axis_Slow_Inc.Within(m_joystick.State.Y) Then
                    m_state_control.State.Stretch += Axis_Slow_Inc.Nominal
                ElseIf Axis_Slow_Dec.Within(m_joystick.State.Y) Then
                    m_state_control.State.Stretch -= Axis_Slow_Dec.Nominal
                ElseIf Axis_Fast_Dec.Within(m_joystick.State.Y) Then
                    m_state_control.State.Stretch -= Axis_Fast_Dec.Nominal
                End If

                'TODO
                '' Z-Axis
                'If Axis_Fast_Inc.Within(m_joystick.State.Z) Then
                '    m_state_control.State.Wrist += Axis_Fast_Inc.Nominal
                'ElseIf Axis_Slow_Inc.Within(m_joystick.State.Z) Then
                '    m_state_control.State.Wrist += Axis_Slow_Inc.Nominal
                'ElseIf Axis_Slow_Dec.Within(m_joystick.State.Z) Then
                '    m_state_control.State.Wrist -= Axis_Slow_Dec.Nominal
                'ElseIf Axis_Fast_Dec.Within(m_joystick.State.Z) Then
                '    m_state_control.State.Wrist -= Axis_Fast_Dec.Nominal
                'End If
            End If

            ' Process buttons

            ' Rotation
            If (m_joystick.State.IsPressed(LEFT_UP) = True) Then
                m_state_control.State.Rotation -= 1
            End If
            If (m_joystick.State.IsPressed(LEFT_DOWN) = True) Then
                m_state_control.State.Rotation += 1
            End If

            ' Rotation (Fast)
            If (m_joystick.State.IsPressed(BOTTOM_LEFT) = True) Then
                m_state_control.State.Rotation -= 5
            End If
            If (m_joystick.State.IsPressed(BOTTOM_RIGHT) = True) Then
                m_state_control.State.Rotation += 5
            End If

            ' Stretch
            If (m_joystick.State.IsPressed(RIGHT_UP) = True) Then
                m_state_control.State.Stretch -= 1
            End If
            If (m_joystick.State.IsPressed(RIGHT_DOWN) = True) Then
                m_state_control.State.Stretch += 1
            End If

            ' Height
            If (m_joystick.State.IsPressed(HAT_DOWN) = True) Then
                m_state_control.State.Height -= 1
            End If
            If (m_joystick.State.IsPressed(HAT_UP) = True) Then
                m_state_control.State.Height += 1
            End If

            ' Wrist
            If (m_joystick.State.IsPressed(HAT_LEFT) = True) Then
                m_state_control.State.Wrist -= 1
            End If
            If (m_joystick.State.IsPressed(HAT_RIGHT) = True) Then
                m_state_control.State.Wrist += 1
            End If

            ' Effector
            m_trigger.Input = m_joystick.State.IsPressed(TRIGGER)
            If m_trigger.Output Then
                ' Toggle the effector state
                m_state_control.State.Effector = Not m_state_control.State.Effector
            End If

        End Sub

        Public Function Setup(ByVal guid As System.Guid)
            Dim success As Boolean = False

            ' Assign a new joystick from settings
            m_joystick.Guid = guid

            If m_state_control.IsEnabled Then
                Try
                    ' Check if successful
                    If m_joystick.Device IsNot Nothing Then

                        ' Reset values
                        m_state_control.Reset()

                        ' Configure the joystick
                        Configure()

                        ' Begin receiving events
                        m_joystick.EnableEvents()

                        success = True
                    Else
                        ' disable joystick input
                        m_state_control.EnableCheckBox.Checked = False
                    End If
                Catch ex As DirectInputException
                    ' disable joystick input
                    m_state_control.EnableCheckBox.Checked = False
                Catch ex As Exception
                    ' disable joystick input
                    m_state_control.EnableCheckBox.Checked = False
                End Try
            Else 'disabled
                m_joystick.DisableEvents()
                success = True
            End If
            Return success
        End Function

        Public Sub Configure()
            Dim _device As Device = Me.m_joystick.Device
            If _device IsNot Nothing Then
                For Each deviceObject As DeviceObjectInstance In _device.GetObjects()
                    Dim id As Integer = CInt(Fix(deviceObject.ObjectType))
                    Dim props As ObjectProperties = _device.GetObjectPropertiesById(id)
                    Dim rotation_range As Range(Of Integer)
                    Dim stretch_range As Range(Of Integer)
                    Dim wrist_range As Range(Of Integer)
                    ' setup axis ranges
                    If _absolute_mode = True Then
                        rotation_range = Range.Rotation
                        stretch_range = Range.Stretch
                        wrist_range = Range.Wrist
                    Else
                        rotation_range = Axis_Range
                        stretch_range = Axis_Range
                        wrist_range = Axis_Range
                    End If
                    If ObjectGuid.XAxis = deviceObject.ObjectTypeGuid Then
                        props.SetRange(rotation_range.Min, rotation_range.Max)
                    End If
                    If ObjectGuid.YAxis = deviceObject.ObjectTypeGuid Then
                        props.SetRange(stretch_range.Min, stretch_range.Max)
                    End If
                    If ObjectGuid.ZAxis = deviceObject.ObjectTypeGuid Then
                        props.SetRange(wrist_range.Min, wrist_range.Max)
                    End If
                Next deviceObject
            End If
        End Sub

#End Region

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
                If m_joystick.IsEnabled Then
                    m_joystick.DisableEvents()
                End If
                m_joystick.Dispose()
                m_joystick = Nothing
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        Protected Overrides Sub Finalize()
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(False)
            MyBase.Finalize()
        End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Namespace
