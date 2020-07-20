Public Class Form1
    Private Sub СоздатьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СоздатьToolStripMenuItem.Click
        NewFile()
    End Sub
    Private Sub NewFile()
        RichTextBox1.Text = ""
        ToolStripStatusLabel1.Text = "Готов"
    End Sub

    Private Sub СоздатьToolStripButton_Click(sender As Object, e As EventArgs) Handles СоздатьToolStripButton.Click
        NewFile()
    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        OpenFile()
    End Sub

    Private Sub ОткрытьToolStripButton_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripButton.Click
        OpenFile()
    End Sub
    Private Sub OpenFile()
        OpenFileDialog1.Filter() = "Текстовый документ | * txt"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub СохранитьToolStripButton_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripButton.Click
        SaveFile()
    End Sub

    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub SaveFile()
        SaveFileDialog1.Filter() = "Текстовый документ | * txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ОпрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОпрограммеToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub СправкаToolStripButton_Click(sender As Object, e As EventArgs) Handles СправкаToolStripButton.Click

    End Sub
End Class
