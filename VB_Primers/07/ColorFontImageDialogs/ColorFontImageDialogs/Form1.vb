Public Class Form1

    Private Sub ColorBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorBtn.Click

        ' Open a color dialog and evaluate choice. 
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub FontBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontBtn.Click

        ' Open a font dialog and evaluate choice.
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
        End If

    End Sub

    Private Sub ImgBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgBtn.Click

        ' Open an open file dialog and evaluate choice.
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            Catch ex As ArgumentException
                MsgBox("Не изображение")
            End Try
        End If

    End Sub

End Class
