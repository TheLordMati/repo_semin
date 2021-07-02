Public Class Classsumar
    Dim num(9) As Integer

    Public Sub sumar(ByRef txtList As TextBox)
        Dim i As Integer
        Dim suma As Integer
        suma = 0
        For i = 0 To num.Length - 1

            num(i) = Val(InputBox("Ingrese número en la posicion N° " & i + 1))
            txtList.Text += i + 1 & ")   " & num(i) & vbCrLf
            suma += num(i)

        Next
        txtList.Text += "La suma es: " & suma
    End Sub
End Class
