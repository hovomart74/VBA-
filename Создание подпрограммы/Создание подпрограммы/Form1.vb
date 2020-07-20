Public Class Form1
    Private Sub Pokupatel(name As String, addr As String, tel As String)
        TextBox1.Text = name
        TextBox2.Text = addr
        TextBox3.Text = tel
    End Sub
    Private Sub Clear_Form()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear_Form()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pokupatel("Михаил раЙмншт", "москва, новосиб 4", "+7-999-123-45-67")
    End Sub
End Class
