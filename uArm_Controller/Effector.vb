Namespace uArm

    Public Class Effector
        Implements IComparable

        Public Enum Action
            GRIP
            RELEASE
        End Enum

        Private _action As Action
        Public Property Value() As Action
            Get
                Return _action
            End Get
            Set(ByVal value As Action)
                _action = value
            End Set
        End Property


        Public Property AsBoolean() As Boolean
            Get
                Dim _value As Boolean
                If _action = Effector.Action.GRIP Then
                    _value = True
                Else
                    _value = False
                End If
                Return _value
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    _action = Effector.Action.GRIP
                Else
                    _action = Effector.Action.RELEASE
                End If
            End Set
        End Property

        Public Sub New()
            _action = Range.Gripper.Nominal.Value
        End Sub

        Public Sub New(ByVal p As Action)
            _action = p
        End Sub

        Public Sub New(ByVal p As Boolean)
            If p Then
                _action = Effector.Action.GRIP
            Else
                _action = Effector.Action.RELEASE
            End If
        End Sub

        Public Shared Operator Not(ByVal p As Effector) As Effector
            Dim a As Action
            If p.Value = Effector.Action.GRIP Then
                a = Effector.Action.RELEASE
            ElseIf p.Value = Effector.Action.RELEASE Then
                a = Effector.Action.GRIP
            End If
            Dim r As Effector = New Effector(a)
            Return r
        End Operator

        Public Shared Operator =(ByVal l As Boolean, ByVal r As Effector) As Boolean
            If r.Value = Effector.Action.GRIP Then
                l = True
            ElseIf r.Value = Effector.Action.RELEASE Then
                l = False
            End If
            Return l
        End Operator

        Public Shared Operator <>(ByVal l As Boolean, ByVal r As Effector) As Boolean
            If r.Value <> Effector.Action.GRIP Then
                l = False
            ElseIf r.Value <> Effector.Action.RELEASE Then
                l = True
            End If
            Return l
        End Operator

        Public Shared Operator +(ByVal l As Effector, ByVal r As Effector) As Effector
            Dim v As Effector = New Effector(l.AsBoolean Or r.AsBoolean)
            Return v
        End Operator

        Public Shared Operator -(ByVal l As Effector, ByVal r As Effector) As Effector
            Dim v As Effector = New Effector(l.AsBoolean And r.AsBoolean)
            Return v
        End Operator

        Public Overloads Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
            If obj Is Nothing Then Return 1

            Dim other As Effector = TryCast(obj, Effector)
            If other IsNot Nothing Then
                Return Me.AsBoolean.CompareTo(other.AsBoolean)
            Else
                Throw New ArgumentException("Object is not an action")
            End If
        End Function

        Public Overloads Function ToString() As String
            Dim s As String = "Unknown"
            If _action = Effector.Action.GRIP Then
                s = "Grip"
            ElseIf _action = Effector.Action.RELEASE Then
                s = "Release"
            End If
            Return s
        End Function
    End Class

End Namespace
