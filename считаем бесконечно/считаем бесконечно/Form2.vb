Public Class Form2
    Public Tormoz As Integer = 3


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Form1.ToNum & "-ը,"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tormoz = 3
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tormoz = 5
        Me.Hide()
        Form1.Show()
    End Sub
End Class