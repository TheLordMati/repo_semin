Public Class Form3
    Dim tabla(10) As Integer
    Dim numUser As Integer

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        numUser = TextBox1.Text
        Dim i As Integer
        For i = 0 To tabla.Length - 1
            tabla(i) = numUser * i

            ListBox1.Items.Add(numUser & " x " & i & " = " & tabla(i))
        Next
    End Sub
End Class