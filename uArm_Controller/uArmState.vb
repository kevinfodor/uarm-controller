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

Imports uArm_Controller.Utilities.Ranges
Imports uArm_Controller.uArm
Imports uArm_Controller.uArm.Parameter

Namespace uArm

    Public Class State

        'Implements IComparable, IEquatable(Of uArm.State)

        Private Enum TypeEnum
            Roation
            Stretch
            Height
            Wrist
            Effector
        End Enum

        'State Changed Event
        Public Event StateChanged As EventHandler

        'uArm object array
        Private m_obj_array([Enum].GetNames(GetType(TypeEnum)).Length - 1) As Parameter
        Public ReadOnly Property Parts() As Parameter()
            Get
                Return m_obj_array
            End Get
        End Property

        Public Property Rotation() As Integer
            Get
                Return m_obj_array(TypeEnum.Roation).Value
            End Get
            Set(ByVal value As Integer)
                m_obj_array(TypeEnum.Roation).Value = value
            End Set
        End Property

        Public Property Stretch() As Integer
            Get
                Return m_obj_array(TypeEnum.Stretch).Value
            End Get
            Set(ByVal value As Integer)
                m_obj_array(TypeEnum.Stretch).Value = value
            End Set
        End Property

        Public Property Height() As Integer
            Get
                Return m_obj_array(TypeEnum.Height).Value
            End Get
            Set(ByVal value As Integer)
                m_obj_array(TypeEnum.Height).Value = value
            End Set
        End Property

        Public Property Wrist() As Integer
            Get
                Return m_obj_array(TypeEnum.Wrist).Value
            End Get
            Set(ByVal value As Integer)
                m_obj_array(TypeEnum.Wrist).Value = value
            End Set
        End Property

        Public Property Effector() As EffectorState
            Get
                Return m_obj_array(TypeEnum.Effector).Value
            End Get
            Set(ByVal value As EffectorState)
                m_obj_array(TypeEnum.Effector).Value = value
            End Set
        End Property

        Public ReadOnly Property IsChanged(Optional ByVal clear As Boolean = True) As Boolean
            Get
                Dim changed As Boolean = False
                Dim index As Integer = 0
                For Each obj As Parameter In m_obj_array
                    changed = changed Or m_obj_array(index).IsChanged(clear)
                    index += 1
                Next
                Return changed
            End Get
        End Property

        Public Sub New()

            Dim names() As String = [Enum].GetNames(GetType(TypeEnum))

            ' Populate the arrray of uArm objects

            'Rotation
            If m_obj_array(TypeEnum.Roation) Is Nothing Then
                m_obj_array(TypeEnum.Roation) = New Servo
            End If
            m_obj_array(TypeEnum.Roation).Name = names(TypeEnum.Roation)
            m_obj_array(TypeEnum.Roation).SetRange(uArm.Range.Rotation.Min, _
                uArm.Range.Rotation.Max, uArm.Range.Rotation.Nominal)
            AddHandler m_obj_array(TypeEnum.Roation).ValueChanged, AddressOf HandleStateChanged

            If m_obj_array(TypeEnum.Stretch) Is Nothing Then
                m_obj_array(TypeEnum.Stretch) = New Servo()
            End If
            m_obj_array(TypeEnum.Stretch).Name = names(TypeEnum.Stretch)
            m_obj_array(TypeEnum.Stretch).SetRange(uArm.Range.Stretch.Min, _
                uArm.Range.Stretch.Max, uArm.Range.Stretch.Nominal)
            AddHandler m_obj_array(TypeEnum.Stretch).ValueChanged, AddressOf HandleStateChanged

            If m_obj_array(TypeEnum.Height) Is Nothing Then
                m_obj_array(TypeEnum.Height) = New Servo()
            End If
            m_obj_array(TypeEnum.Height).Name = names(TypeEnum.Height)
            m_obj_array(TypeEnum.Height).SetRange(uArm.Range.Height.Min, _
                uArm.Range.Height.Max, uArm.Range.Height.Nominal)
            AddHandler m_obj_array(TypeEnum.Height).ValueChanged, AddressOf HandleStateChanged

            If m_obj_array(TypeEnum.Wrist) Is Nothing Then
                m_obj_array(TypeEnum.Wrist) = New Servo()
            End If
            m_obj_array(TypeEnum.Wrist).Name = names(TypeEnum.Wrist)
            m_obj_array(TypeEnum.Wrist).SetRange(uArm.Range.Wrist.Min, _
                uArm.Range.Wrist.Max, uArm.Range.Wrist.Nominal)
            AddHandler m_obj_array(TypeEnum.Wrist).ValueChanged, AddressOf HandleStateChanged

            If m_obj_array(TypeEnum.Effector) Is Nothing Then
                m_obj_array(TypeEnum.Effector) = New Effector()
            End If
            m_obj_array(TypeEnum.Effector).Name = names(TypeEnum.Effector)
            m_obj_array(TypeEnum.Effector).SetRange(uArm.Range.EffectorState.Min, _
                uArm.Range.EffectorState.Max, uArm.Range.EffectorState.Nominal)
            AddHandler m_obj_array(TypeEnum.Effector).ValueChanged, AddressOf HandleStateChanged

            ' Reset all values to nominal
            Reset()

        End Sub

        Public Sub New(ByVal rotation As Integer, ByVal stretch As Integer, _
                       ByVal height As Integer, ByVal wrist As Integer, _
                       ByVal effector As EffectorState)
            Dim state As New State()

            'Initialize all the states per inputs
            state.Rotation = rotation
            state.Stretch = stretch
            state.Height = height
            state.Wrist = wrist
            state.Effector = effector
        End Sub

        Public Overloads Sub Copy(ByRef state As State)
            ' Copy state values
            Dim index As Integer = 0
            For Each obj As Parameter In state.m_obj_array
                m_obj_array(index).Value = state.m_obj_array(index).Value
                index += 1
            Next
        End Sub

        Public Shared Operator +(ByVal l As State, ByVal r As State) As State
            Dim v As State = New State
            ' Add state values
            Dim index As Integer = 0
            For Each obj As Parameter In v.m_obj_array
                v.m_obj_array(index).Value = l.m_obj_array(index).Value + r.m_obj_array(index).Value
                index += 1
            Next
            Return v
        End Operator

        Public Shared Operator -(ByVal l As State, ByVal r As State) As State
            Dim v As State = New State
            ' Subtract state values
            Dim index As Integer = 0
            For Each obj As Parameter In v.m_obj_array
                v.m_obj_array(index).Value = l.m_obj_array(index).Value - r.m_obj_array(index).Value
                index += 1
            Next
            Return v
        End Operator

        Public Overloads Shared Operator <>(ByVal lhs As State, ByVal rhs As State) As Boolean
            Return Not (lhs = rhs)
        End Operator

        Public Overloads Shared Operator =(ByVal lhs As State, ByVal rhs As State) As Boolean
            Dim equal As Boolean = True
            Dim index As Integer = 0
            For Each obj As Parameter In lhs.m_obj_array
                equal = equal And (lhs.m_obj_array(index).Value = rhs.m_obj_array(index).Value)
                index += 1
            Next
            Return equal
        End Operator

        Public Sub Reset()
            ' Set all state values to nominal
            Dim index As Integer = 0
            For Each obj As Parameter In m_obj_array
                obj.ResetValue()
                index += 1
            Next
        End Sub

        Private Sub HandleStateChanged(sender As Object, e As System.EventArgs)
            RaiseEvent StateChanged(Me, System.EventArgs.Empty)
        End Sub

    End Class

End Namespace
