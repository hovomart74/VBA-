Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Addition functionality.
        Label3.Text = "Решение: " _
            & Str(Val(TextBox1.Text) + Val(TextBox2.Text))

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label3.Text = "Решение: " & Str(Val(TextBox1.Text) - Val(TextBox2.Text))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label3.Text = "Решение: " & Str(Val(TextBox1.Text) / Val(TextBox2.Text))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label3.Text = "Решение: " & Str(Val(TextBox1.Text) * Val(TextBox2.Text))
    End Sub
End Class
