Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Only good to add numbers -2,147,483,648 through 2,147,483,647.
        ' Dim num1 As Integer = Val(TextBox1.Text)
        ' Dim num2 As Integer = Val(TextBox2.Text)

        ' Good to add numbers -9,223,372,036,854,775,808 through 9,223,372,036,854,775,807.
        Dim num1 As Long = Val(TextBox1.Text)
        Dim num2 As Long = Val(TextBox2.Text)

        ' Display the sum total of the two fields.
        ResultLbl.Text = num1 + num2

    End Sub



























    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' Clear all fields.
        TextBox1.Text = ""
        TextBox2.Text = ""
        ResultLbl.Text = "?"

    End Sub

End Class
