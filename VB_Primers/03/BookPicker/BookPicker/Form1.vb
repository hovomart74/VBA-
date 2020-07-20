Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BookList.Items.Add("Программирование на Python для начинающих")
        BookList.Items.Add("Программирование на Java для начинающих")
        BookList.Items.Add("Программирование на C для начинающих")
        BookList.Items.Add("Создание приложений на Android для начинающих")
        BookList.Items.Add("PHP. Быстрый старт")
        BookList.Items.Add("CSS. Быстрый старт")
        BookList.Sorted = True
        BookList.SelectedIndex = 0
        Me.Text = "Доступно книг: " &
BookList.Items.Count

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(BookList.Text)
    End Sub
End Class
