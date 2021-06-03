Imports System.DateTime
Public Class Form1
    Dim dDate, dTime As Date


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dDate = TextBox1.Text
        Label6.Text = Format(dDate, "dddd, dd De MMMM De yyyy")
        Label6.Visible = True

        dTime = TextBox2.Text
        Label7.Text = Format(dTime, "hhhh")
        Label8.Text = Format(dTime, "mm")
        Label9.Text = Format(dTime, "ss")
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

End Class
