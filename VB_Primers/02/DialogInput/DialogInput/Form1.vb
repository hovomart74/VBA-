Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Text = InputBox("Введите заголовок...", "Установка заголовка", "Привет! Мне хорошо, а вам?")
    End Sub
End Class
