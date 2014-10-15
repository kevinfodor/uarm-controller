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

Namespace uArm

    Public Class EffectorState

        Implements IComparable, IEquatable(Of EffectorState)

        Public Const RELEASE As Boolean = False
        Public Const GRIP As Boolean = True

        Private m_state As Boolean

        Public Sub New(ByVal state As Boolean)
            m_state = state
        End Sub

        Public ReadOnly Property State() As Boolean
            Get
                Return m_state
            End Get
        End Property

        Public Overrides Function ToString() As String
            Dim s As String
            If m_state = RELEASE Then
                s = "Release"
            Else
                s = "Grip"
            End If
            Return s
        End Function

        Public Function CompareTo(obj As Object) As Integer Implements System.IComparable.CompareTo
            If obj Is Nothing Then Return 1

            Dim other As EffectorState = TryCast(obj, EffectorState)
            If other IsNot Nothing Then
                Return Me.m_state.CompareTo(other.m_state)
            Else
                Throw New ArgumentException(String.Format("Object is not a {0}", Me.GetType.Name))
            End If
        End Function

        Public Overloads Function Equals(ByVal other As EffectorState) As Boolean _
            Implements System.IEquatable(Of EffectorState).Equals
            Return m_state = other.m_state
        End Function

        Public NotOverridable Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim temp = TryCast(obj, EffectorState)
            If temp IsNot Nothing Then Return Me.Equals(temp)
            Return False
        End Function

        Public Overloads Shared Operator =(ByVal lhs As EffectorState, ByVal rhs As EffectorState) As Boolean
            Return Object.Equals(lhs, rhs)
        End Operator

        Public Overloads Shared Operator <>(ByVal lhs As EffectorState, ByVal rhs As EffectorState) As Boolean
            Return Not (lhs = rhs)
        End Operator

        Public Overloads Shared Operator Not(ByVal effector As EffectorState) As EffectorState
            effector.m_state = Not effector.m_state
            Return effector
        End Operator

        Public Overloads Shared Widening Operator CType(ByVal state As Boolean) As EffectorState
            Return New EffectorState(state)
        End Operator

        Public Overloads Shared Narrowing Operator CType(ByVal obj As EffectorState) As Boolean
            Return obj.m_state
        End Operator

    End Class

    Public Class Parameter

        'Event to fire when the value has been changed
        Public Event ValueChanged As EventHandler

        Protected m_name As String = Nothing
        Public Property Name() As String
            Get
                Return m_name
            End Get
            Set(ByVal value As String)
                m_name = value
            End Set
        End Property

        Protected m_tag As Object = Nothing
        Public Property Tag() As Object
            Get
                Return m_tag
            End Get
            Set(ByVal value As Object)
                m_tag = value
            End Set
        End Property

        Protected m_value As Integer = 0
        Public Property Value() As Integer
            Get
                Return m_value
            End Get
            Set(ByVal value As Integer)
                ' Fit to range
                Dim previous As Integer = m_value
                m_value = m_range.Trim(value)
                m_changed = previous <> m_value
                If m_changed Then
                    RaiseEvent ValueChanged(Me, System.EventArgs.Empty)
                End If
            End Set
        End Property

        Public Sub ResetValue()
            Me.Value = m_range.Nominal
        End Sub

        Protected m_range As Range(Of Integer) = _
            New Range(Of Integer)(-100, 100, 0)

        Public Sub SetRange(ByVal min As Integer, ByVal max As Integer, ByVal nominal As Integer)
            m_range.Min = min
            m_range.Max = max
            m_range.Nominal = nominal
            ' Fit to range
            Me.Value = m_range.Trim(m_value)
        End Sub

        Private m_changed As Boolean = True
        Public ReadOnly Property IsChanged(Optional ByVal clear As Boolean = True) As Boolean
            Get
                Dim changed As Boolean = m_changed
                If clear Then
                    m_changed = False
                End If
                Return changed
            End Get
        End Property

        Sub New(Optional ByVal value As Integer = 0)
            m_name = TypeName(GetType(uArm.Parameter))
            Me.Value = value
        End Sub

    End Class

    Public Class Servo

        Inherits Parameter

        Sub New(Optional ByVal value As Integer = 0)
            m_name = TypeName(GetType(uArm.Servo))
            Me.Value = value
        End Sub

    End Class

    Public Class Effector

        Inherits Parameter

        Sub New(Optional ByVal value As Boolean = False)
            m_name = TypeName(GetType(uArm.Effector))
            Me.Value = CType(value, Integer)
        End Sub

    End Class

End Namespace
