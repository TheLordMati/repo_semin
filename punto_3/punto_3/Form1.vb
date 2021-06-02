Imports System.DateTime
Public Class Form1
    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        lblhora.Text = DateTime.Now.ToLongTimeString()
        lblfecha.Text = DateTime.Now.ToLongDateString()
    End Sub
End Class
