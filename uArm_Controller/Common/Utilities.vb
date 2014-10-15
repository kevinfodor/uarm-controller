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

Namespace Utilities

    Public Class Ranges

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

        Public Shared Function Within(Of _T As IComparable)(ByVal value As _T, ByVal min As _T, ByVal max As _T) As Boolean
            Return ((value.CompareTo(min) >= 0) AndAlso (value.CompareTo(max) <= 0))
        End Function

        Public Shared Function Trim(Of _T As IComparable)(ByVal value As _T, ByVal min As _T, ByVal max As _T) As _T
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
            Public Function Within(ByVal value As _T) As Boolean
                Return Ranges.Within(value, Min, Max)
            End Function
            Public Function Trim(ByVal value As _T) As _T
                Return Ranges.Trim(value, Min, Max)
            End Function
        End Class

    End Class

End Namespace
