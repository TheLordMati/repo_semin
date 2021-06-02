Public Class Form7
    Dim a, b, c As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label22.Text = a
        Label21.Text = a
        Label20.Text = a
        Label19.Text = a
        Label18.Text = a
        Label17.Text = a
        Label16.Text = a
        Label15.Text = a
        Label14.Text = a
        Label13.Text = a

        Label22.Visible = True
        Label21.Visible = True
        Label20.Visible = True
        Label19.Visible = True
        Label18.Visible = True
        Label17.Visible = True
        Label16.Visible = True
        Label15.Visible = True
        Label14.Visible = True
        Label13.Visible = True
        'Multiplicacion ------

        Label32.Text = a * 1
        Label31.Text = a * 2
        Label30.Text = a * 3
        Label29.Text = a * 4
        Label28.Text = a * 5
        Label27.Text = a * 6
        Label26.Text = a * 7
        Label25.Text = a * 8
        Label24.Text = a * 9
        Label23.Text = a * 10

        Label32.Visible = True
        Label31.Visible = True
        Label30.Visible = True
        Label29.Visible = True
        Label28.Visible = True
        Label27.Visible = True
        Label26.Visible = True
        Label25.Visible = True
        Label24.Visible = True
        Label23.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        a = TextBox1.Text
    End Sub
End Class