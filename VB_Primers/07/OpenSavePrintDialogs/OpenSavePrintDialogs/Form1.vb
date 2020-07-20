Public Class Form1

    Private Sub OpenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBtn.Click

        ' Configure the open file dialog.
        With OpenFileDialog1
            .Title = "Открыть файл"
            .Filter = "Rich Text Files | *.rtf"
            .FileName = ""
            .CheckFileExists = True
        End With

        ' Load a rich text file into the interface.
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If

    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click

        ' Choose printer options.
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Insert code here to process and print.
        End If

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click

        ' Configure the save file dialog.
        With SaveFileDialog1
            .Title = "Сохранить файл"
            .Filter = "Rich Text Files | *.rtf"
            .DefaultExt = ".rtf"
            .OverwritePrompt = True
        End With

        ' Save a rich text file.
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1 .SaveFile (SaveFileDialog1 .FileName , RichTextBoxStreamType.RichText )
        End If

    End Sub

End Class
