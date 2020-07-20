Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Title = "Media File Browser"
            .Filter = "Файлы мультимедиа (*.wmv;*.mp3)|*.wmv;*.mp3"
            .FileName = ""
            .CheckFileExists = True
        End With

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
        put()
    End Sub

    Private Sub put()
        ToolStripStatusLabel1.Text = OpenFileDialog1.FileName

    End Sub
End Class
