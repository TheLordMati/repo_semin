Public Class Form3
    Dim c, f, k As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f = (9 / 5) * c + 32
        k = c + 273
        ListBox1.Items.Add(c & " °C")
        ListBox2.Items.Add(f & " °F")
        ListBox3.Items.Add(k & " °K")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        c = TextBox1.Text
    End Sub
End Class