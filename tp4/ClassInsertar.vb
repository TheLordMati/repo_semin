Public Class ClassInsertar
    Dim num(9) As Integer
    Public Sub Insertar(ByRef txtList As TextBox)
        Dim i As Integer
        For i = 0 To num.Length - 1

            num(i) = Val(InputBox("Ingrese número en la posicion N° " & i + 1))
            txtList.Text += i + 1 & ")   " & num(i) & vbCrLf
        Next
    End Sub
End Class
