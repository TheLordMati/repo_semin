Public Class Form1
    'Crear un array de números con la longitud que quiera e introducir en cada elemento el valor de su posición. Luego Muestra el contenido en un Control.

    Dim num(9) As Integer
    Dim i As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 0 To (num.Length - 1)
            num(i) = i
            ListBox1.Items.Add("Posición: " & num(i))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f2 As New Form2

        f2.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f3 As New Form3

        f3.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f4 As New Form4

        f4.ShowDialog()
    End Sub
End Class
