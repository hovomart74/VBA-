Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' Hide form1 and open form2.
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Display input text from hidden form2 only.
        ValueLbl.Text = Form2.TextBox1.Text

    End Sub

End Class
