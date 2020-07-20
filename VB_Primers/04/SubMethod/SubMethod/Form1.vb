Public Class Form1

    Private Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Customer(ByVal name As String, ByVal addr As String)
        TextBox1.Text = name
        TextBox2.Text = addr
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ClearForm()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Customer("Михаил Райтман", "Москва, Зорге 1")
    End Sub
End Class
