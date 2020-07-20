Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub HideBtn_Click(sender As Object, e As EventArgs) Handles HideBtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class