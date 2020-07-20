Public Class Form1
    Dim myFile As String = "log.txt"

    Private Sub WriteBtn_Click(sender As Object, e As EventArgs) Handles WriteBtn.Click
        Try
            My.Computer.FileSystem.WriteAllText(myFile, TextBox1.Text & vbCrLf, True)

            ' Clear the textbox.
            TextBox1.Text = ""
        Catch ex As Exception
            TextBox2.Text = "Невозможно найта папку " & myFile
        End Try

    End Sub

    Private Sub ReadBtn_Click(sender As Object, e As EventArgs) Handles ReadBtn.Click
        Try
            ' Attempt to read from a file.
            TextBox2.Text = My.Computer.FileSystem.ReadAllText(myFile)
        Catch ex As Exception
            TextBox2.Text = "Невозможно прочитать текст из файла " & myFile
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        ' Clear both textboxes.
        TextBox1.Text = ""
        TextBox2.Text = ""

        ' Delete the file.
        If My.Computer.FileSystem.FileExists(myFile) Then
            My.Computer.FileSystem.DeleteFile(myFile)
        End If
    End Sub
End Class
