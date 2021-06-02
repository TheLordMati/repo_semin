Imports System.Math
Public Class Form1

    Dim x, y, z As Double

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        x = TextBox1.Text

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        y = TextBox2.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        z = Math.Pow(x, 2)
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label4.Text = TextBox1.Text
        Label5.Text = "^"
        Label6.Text = "2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        z = Math.Pow(x, y)
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label4.Text = TextBox1.Text
        Label5.Text = "^"
        Label6.Text = TextBox2.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
        Label1.Text = 0
        x = 0
        y = 0
        z = 0
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label4.Text = "0"
        Label5.Text = "^"
        Label6.Text = "0"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim f2 As New Form2

        f2.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim f3 As New Form3

        f3.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim f4 As New Form4

        f4.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim f5 As New Form5

        f5.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim f6 As New Form6

        f6.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim f7 As New Form7

        f7.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        z = Math.Pow(x, 3)
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label4.Text = TextBox1.Text
        Label5.Text = "^"
        Label6.Text = "3"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = z
    End Sub

End Class
