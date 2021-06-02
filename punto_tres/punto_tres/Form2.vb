Imports System.Math
Public Class Form2
    Dim b, h, z As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        z = 2 * (b + h)
        Label7.Text = z
        Label7.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        z = b * h
        Label6.Text = z
        Label6.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        b = TextBox1.Text
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        h = TextBox2.Text
    End Sub

End Class