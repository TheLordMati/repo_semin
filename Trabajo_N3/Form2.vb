Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, r As Integer

        For i = -10 To 10
            r = i ^ 2 + i + 1
            ListBox1.Items.Add("y = " & i & "²  +  " & i & " + 1  = " & r)
        Next

    End Sub
End Class