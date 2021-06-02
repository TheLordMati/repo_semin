Public Class Form6
    Dim a, iva, c As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iva = a * 0.21
        c = a + iva
        Label6.Text = a
        Label7.Text = iva
        Label8.Text = c
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        a = TextBox1.Text

    End Sub
End Class