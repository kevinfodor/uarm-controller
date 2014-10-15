Namespace Utilities

    Public Class Utilities

        Public Shared Function Largest(ByVal ParamArray args() As Double) As Double
            If args.Length < 1 Then Return Double.NaN

            Dim res As Double = args(0)

            For i As Integer = 1 To UBound(args)
                If args(i) > res Then res = args(i)
            Next

            Return res
        End Function

        Public Shared Function Smallest(ByVal ParamArray args() As Double) As Double
            If args.Length < 1 Then Return Double.NaN

            Dim res As Double = args(0)

            For i As Integer = 1 To UBound(args)
                If args(i) < res Then res = args(i)
            Next

            Return res
        End Function

        Public Shared Function InRange(Of _T As IComparable)(ByVal value As _T, ByVal min As _T, ByVal max As _T) As Boolean
            Return ((value.CompareTo(min) >= 0) AndAlso (value.CompareTo(max) <= 0))
        End Function

        Public Shared Function Truncate(Of _T As IComparable)(ByVal value As _T, ByVal min As _T, ByVal max As _T) As _T
            Dim r As _T = value
            If value.CompareTo(min) < 0 Then
                r = min
            ElseIf value.CompareTo(max) > 0 Then
                r = max
            End If
            Return r
        End Function

        Public Class Range(Of _T As IComparable)
            Public Min As _T
            Public Max As _T
            Public Nominal As _T
            Public Sub New(ByVal _Min As _T, ByVal _Max As _T, ByVal _Nominal As _T)
                Min = _Min
                Max = _Max
                Nominal = _Nominal
            End Sub
            Public Sub New(ByVal _Min As _T, ByVal _Max As _T)
                Min = _Min
                Max = _Max
                Nominal = _Min
            End Sub
            Public Function InRange(ByVal value As _T) As Boolean
                Return Utilities.InRange(value, Min, Max)
            End Function
            Public Function Truncate(ByVal value As _T) As _T
                Return Utilities.Truncate(value, Min, Max)
            End Function
        End Class

    End Class

End Namespace
