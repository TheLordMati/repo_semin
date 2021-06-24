Public Class Form1
    Dim i, suma As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f2 As New Form2

        f2.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f3 As New Form3

        f3.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num As Integer
        num = Val(TextBox1.Text)
        For i = 1 To num
            If (i Mod 2 = 0) Then
                suma = suma + i ^ 2
            End If
        Next
        TextBox2.Text = suma
        suma = 0
    End Sub

End Class
