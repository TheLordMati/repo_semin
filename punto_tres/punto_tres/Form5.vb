Public Class Form5
    Dim a As Double
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        a = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Pesos(ARS)" And ComboBox2.Text = "Pesos(ARS)" Then
            Label4.Text = a
            Label5.Text = "(ARS)"
            Label4.Visible = True
            Label5.Visible = True
        ElseIf ComboBox1.Text = "Pesos(ARS)" And ComboBox2.Text = "Dólares(USD)" Then
            Label4.Text = a / 94.65
            Label5.Text = "(USD)"
            Label4.Visible = True
            Label5.Visible = True
        ElseIf ComboBox1.Text = "Pesos(ARS)" And ComboBox2.Text = "Euros(EUR)" Then
            Label4.Text = a / 115
            Label5.Text = "(EUR)"
            Label4.Visible = True
            Label5.Visible = True

            'Dolares -----------------------------------------------

        ElseIf ComboBox1.Text = "Dólares(USD)" And ComboBox2.Text = "Dólares(USD)" Then
            Label4.Text = a
            Label5.Text = "(USD)"
            Label4.Visible = True
            Label5.Visible = True
        ElseIf ComboBox1.Text = "Dólares(USD)" And ComboBox2.Text = "Pesos(ARS)" Then
            Label4.Text = a * 94.65
            Label5.Text = "(ARS)"
            Label4.Visible = True
            Label5.Visible = True
        ElseIf ComboBox1.Text = "Dólares(USD)" And ComboBox2.Text = "Euros(EUR)" Then
            Label4.Text = a * 0.82
            Label5.Text = "(EUR)"
            Label4.Visible = True
            Label5.Visible = True

            'Euros -----------------------------------------------

        ElseIf ComboBox1.Text = "Euros(EUR)" And ComboBox2.Text = "Euros(EUR)" Then
            Label4.Text = a
            Label5.Text = "(EUR)"
            Label4.Visible = True
            Label5.Visible = True
        ElseIf ComboBox1.Text = "Euros(EUR)" And ComboBox2.Text = "Pesos(ARS)" Then
            Label4.Text = a * 115
            Label5.Text = "(ARS)"
            Label4.Visible = True
            Label5.Visible = True
        ElseIf ComboBox1.Text = "Euros(EUR)" And ComboBox2.Text = "Dólares(USD)" Then
            Label4.Text = a * 1.22
            Label5.Text = "(USD)"
            Label4.Visible = True
            Label5.Visible = True

        End If
    End Sub
End Class