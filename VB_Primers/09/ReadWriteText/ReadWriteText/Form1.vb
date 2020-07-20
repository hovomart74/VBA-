Public Class Form1

    Dim myFile As String = "log.txt"

    Private Sub WriteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteBtn.Click

        ' Write the contents of textbox to a file.
        My.Computer.FileSystem.WriteAllText(myFile, TextBox1.Text & vbCrLf, True)

        ' Clear the textbox.
        TextBox1.Text = ""

    End Sub

    Private Sub ReadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadBtn.Click

        Try
            ' Attempt to read from a file.
            TextBox2.Text = My.Computer.FileSystem.ReadAllText(myFile)
        Catch ex As Exception
            TextBox2.Text = "Невозможно прочитать текст из файла " & myFile
        End Try

    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click

        ' Clear both textboxes.
        TextBox1.Text = ""
        TextBox2.Text = ""

        ' Delete the file.
        If My.Computer.FileSystem.FileExists(myFile) Then
            My.Computer.FileSystem.DeleteFile(myFile)
        End If

    End Sub

End Class
