
Namespace Processing

    Public Class OneShot

        Private _previous_input As Boolean = False
        Private _output_state As Boolean = False

        Public WriteOnly Property Input As Boolean
            Set(ByVal input_state As Boolean)
                If input_state And Not _previous_input Then
                    ' Toggle output
                    _output_state = Not _output_state
                Else
                    _output_state = False
                End If
                _previous_input = input_state
            End Set
        End Property

        Public Function Output() As Boolean
            Return _output_state
        End Function

        Public Sub Reset()
            _previous_input = False
            _output_state = False
        End Sub

    End Class

    Public Class Inverter
        Private _output_state As Boolean = False
        Public WriteOnly Property Input As Boolean
            Set(ByVal input_state As Boolean)
                _output_state = Not input_state
            End Set
        End Property

        Public Function Output() As Boolean
            Return _output_state
        End Function
    End Class

End Namespace
