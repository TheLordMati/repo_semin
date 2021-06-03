
Imports System.Math


Public Class Form1

    Public Class GlobalVariables
        Public Shared numero1 As Double = 0
        Public Shared numero2 As Double = 0
        Public Shared selector As Integer = 0
    End Class


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "1"
        ElseIf (Textbox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "1"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "2"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "2"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "3"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "3"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "4"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "4"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "5"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "5"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "6"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "6"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "7"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "7"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "8"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "8"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "9"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "9"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "0."
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & "0"
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Select Case GlobalVariables.selector
            Case 1
                GlobalVariables.numero2 = GlobalVariables.numero1 + TextBox1.Text
                TextBox1.Text = GlobalVariables.numero2
                Label1.Visible = False
                Label2.Visible = False
            Case 2
                GlobalVariables.numero2 = GlobalVariables.numero1 - TextBox1.Text
                TextBox1.Text = GlobalVariables.numero2
                Label1.Visible = False
                Label2.Visible = False
            Case 3
                GlobalVariables.numero2 = GlobalVariables.numero1 * TextBox1.Text
                TextBox1.Text = GlobalVariables.numero2
                Label1.Visible = False
                Label2.Visible = False
            Case 4
                GlobalVariables.numero2 = GlobalVariables.numero1 / TextBox1.Text
                TextBox1.Text = GlobalVariables.numero2
                Label1.Visible = False
                Label2.Visible = False
            Case 5
                GlobalVariables.numero2 = GlobalVariables.numero1 ^ TextBox1.Text
                TextBox1.Text = GlobalVariables.numero2
                Label1.Visible = False
                Label2.Visible = False

        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (TextBox1.Text.Contains(",")) Then
            TextBox1 = TextBox1
        ElseIf (TextBox1.Text = "0") Then
            TextBox1.Text = "0,"
        ElseIf (TextBox1.Text <> "0") Then
            TextBox1.Text = TextBox1.Text & ","
        Else

        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If (GlobalVariables.selector = 0) Then
            GlobalVariables.numero1 = TextBox1.Text
            TextBox1.Text = "0"
            GlobalVariables.selector = 1
            Label1.Text = "+"
            Label2.Text = GlobalVariables.numero1
            Label1.Visible = True
            Label2.Visible = True
        Else
            GlobalVariables.selector = 1
            Label1.Text = "+"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If (GlobalVariables.selector = 0) Then
            GlobalVariables.numero1 = TextBox1.Text
            TextBox1.Text = "0"
            GlobalVariables.selector = 2
            Label1.Text = "-"
            Label2.Text = GlobalVariables.numero1
            Label1.Visible = True
            Label2.Visible = True
        Else
            GlobalVariables.selector = 2
            Label1.Text = "-"
        End If

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If (GlobalVariables.selector = 0) Then
            GlobalVariables.numero1 = TextBox1.Text
            TextBox1.Text = "0"
            GlobalVariables.selector = 3
            Label1.Text = "×"
            Label2.Text = GlobalVariables.numero1
            Label1.Visible = True
            Label2.Visible = True
        Else
            GlobalVariables.selector = 3
            Label1.Text = "×"
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (GlobalVariables.selector = 0) Then
            GlobalVariables.numero1 = TextBox1.Text
            TextBox1.Text = "0"
            GlobalVariables.selector = 4
            Label1.Text = "÷"
            Label2.Text = GlobalVariables.numero1
            Label1.Visible = True
            Label2.Visible = True
        Else GlobalVariables.selector = 4
            Label1.Text = "÷"
        End If


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        GlobalVariables.numero1 = 0
        GlobalVariables.numero2 = 0
        GlobalVariables.selector = 0
        TextBox1.Text = "0"
        Label1.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        If (GlobalVariables.selector = 0) Then
            GlobalVariables.numero1 = TextBox1.Text
            TextBox1.Text = "0"
            GlobalVariables.selector = 5
            Label1.Text = "^"
            Label2.Text = GlobalVariables.numero1
            Label1.Visible = True
            Label2.Visible = True
        Else
            GlobalVariables.selector = 5
            Label1.Text = "^"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = System.Math.Pow(TextBox1.Text, 2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (TextBox1.Text = "0") Then
            TextBox1.Text = "0"
        ElseIf (Textbox1.Text <> "0") Then
            TextBox1.Text = Convert.ToDouble(TextBox1.Text) * -1
        Else
            TextBox1.Text = TextBox1.Text
        End If
    End Sub
End Class
