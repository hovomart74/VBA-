Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Uncomment the try catch statements to catch an error.
        'Try

        ' Add the values in the text fields.
        Dim num1 As Integer = Val(TextBox1.Text)
            Dim num2 As Integer = Val(TextBox2.Text)
            ResultLbl.Text = num1 + num2

        'Catch ex As OverflowException

        ' Display a friendly message.
        'MsgBox("Only numbers up to 2 Billion are allowed")

        'End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' Clear all fields.
        TextBox1.Text = ""
        TextBox2.Text = ""
        ResultLbl.Text = "?"

    End Sub

End Class
