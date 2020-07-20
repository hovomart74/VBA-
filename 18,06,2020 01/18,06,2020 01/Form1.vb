Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ColorBtn_Click(sender As Object, e As EventArgs) Handles ColorBtn.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FontBtn_Click(sender As Object, e As EventArgs) Handles FontBtn.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ImgBtn_Click(sender As Object, e As EventArgs) Handles ImgBtn.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            Catch ex As ArgumentException
                MsgBox("Не изображение")
            End Try
        End If
    End Sub
End Class
