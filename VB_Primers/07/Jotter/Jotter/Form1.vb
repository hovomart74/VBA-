Public Class Form1


    ' New file routines.
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewFile()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        NewFile()
    End Sub


    ' Save file routines.
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFile()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveFile()
    End Sub


    ' Open file routines.
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFile()
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFile()
    End Sub


    ' #################################################
    ' Subroutines to call from menu item and menu button.

    Private Sub NewFile()
        RichTextBox1.Text = ""
        ToolStripStatusLabel1.Text = "Готов"
    End Sub

    Private Sub SaveFile()
        SaveFileDialog1.Filter = "Текстовый документ | *.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If

    End Sub


    Private Sub OpenFile()
        OpenFileDialog1.Filter = "Текстовый документ | *.txt"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub


    ' ################################################
    ' Subroutine to display the about dialog.

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ОпрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОпрограммеToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        OpenFile()
    End Sub
End Class
