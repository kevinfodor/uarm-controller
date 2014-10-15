' This is a simple utility class for manipulating multi-byte types

Public Class Bytes

    Public Shared Function LSB(ByVal _value As Integer) As Byte
        Return LSB(Convert.ToInt16(_value))
    End Function

    Public Shared Function LSB(ByVal _value As Short) As Byte
        Dim _msb As Byte
        If BitConverter.IsLittleEndian = True Then
            _msb = BitConverter.GetBytes(_value)(0)
        Else
            _msb = BitConverter.GetBytes(_value)(1)
        End If
        Return _msb
    End Function

    Public Shared Function MSB(ByVal _value As Integer) As Byte
        Return MSB(Convert.ToInt16(_value))
    End Function

    Public Shared Function MSB(ByVal _value As Short) As Byte
        Dim _msb As Byte
        If BitConverter.IsLittleEndian = True Then
            _msb = BitConverter.GetBytes(_value)(1)
        Else
            _msb = BitConverter.GetBytes(_value)(0)
        End If
        Return _msb
    End Function

End Class
