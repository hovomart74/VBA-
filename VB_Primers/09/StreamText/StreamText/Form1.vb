Public Class Form1

    ' Create a global variable to store a streamed string.
    Dim txt As String


    Private Sub OpenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBtn.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' Create a new filestream object and stream reader object.
            Dim stream As New System.IO.FileStream(OpenFileDialog1.FileName, System.IO.FileMode.Open)
            Dim reader As New System.IO.StreamReader(stream)

            ' Read the stream into the global variable.
            txt = reader.ReadToEnd

            ' Release resources.
            reader.Dispose() : stream.Dispose()

            ' Display the streamed string.
            TextBox1.Text = txt

        End If

    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click

        ' Configure some print dialog options.
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True

        ' Fire the print page event.
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If txt <> "" Then
                PrintDocument1.Print()
            End If
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' Print the streamed string.
        e.Graphics.DrawString(txt, Me.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)

    End Sub

End Class
