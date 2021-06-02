Public Class Form4
    Dim c, f, z As Double

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        f = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        z = (f - 32) * (5 / 9)
        Label8.Text = z
        Label8.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        z = c * (9 / 5) + 32
        Label5.Text = z
        Label5.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        c = TextBox1.Text
    End Sub
End Class