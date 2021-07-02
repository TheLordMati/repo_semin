Public Class Form2

    Dim listainsertar As New ClassInsertar()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listainsertar.Insertar(TextBox2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class