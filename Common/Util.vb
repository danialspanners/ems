Namespace CommonConn

    Public Class Util

        Public Function DoubleToString(ByVal pnum As Double, ByVal mindec As Integer) As String
            Dim stmp As String
            Dim i As Integer

            stmp = pnum.ToString()
            stmp = stmp.Replace("0", " ")

            'split if it has decimal value
            Dim noarray() As String = Split(stmp, ".")

            'peform trimming to dec value if neccessary
            If UBound(noarray) > 1 Then
                noarray(1) = RTrim(noarray(1))

                If Len(noarray(i)) < mindec Then
                    For i = Len(noarray(1)) To mindec
                        noarray(1) = noarray(1) + " "
                    Next
                End If

            End If

            stmp = Join(noarray, ".")
            stmp = stmp.Replace(" ", "0")

            DoubleToString = stmp

        End Function

        Public Function DoubleToString(ByVal pnum As String, ByVal mindec As Integer) As String
            Dim stmp As String
            Dim i As Integer

            stmp = pnum.ToString()
            stmp = stmp.Replace("0", " ")

            'split if it has decimal value
            Dim noarray() As String = Split(stmp, ".")

            'peform trimming to dec value if neccessary
            If UBound(noarray) > 0 Then
                noarray(1) = RTrim(noarray(1))

                If Len(noarray(1)) < mindec Then
                    For i = Len(noarray(1)) To mindec
                        noarray(1) = noarray(1) + " "
                        i = i + 1
                    Next
                End If

                stmp = Join(noarray, ".")

            Else
                If mindec > 0 Then
                    stmp = stmp + "."
                    For i = 1 To mindec
                        stmp = stmp + "0"
                    Next
                End If
            End If

            stmp = stmp.Replace(" ", "0")

            DoubleToString = stmp

        End Function


    End Class

End Namespace
