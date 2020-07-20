Public Class Form2

    Private Sub HideBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideBtn.Click

        ' Hide form2 and show form1.
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click

        ' Close form2 and show form1.
        Me.Close()
        Form1.Show()

    End Sub
End Class