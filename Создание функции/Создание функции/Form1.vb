Public Class Form1
    Private Function Inches(ByVal cam As String) As Double
        Inches = Val(cam) / 2.54
        Inches = FormatNumber(Inches, 3)
        Return Inches
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = Inches(TextBox1.Text) & " дюймов"
        If Inches(TextBox1.Text) = 0 Then
            Label3.Text = "Նորմալ թիվ չգիտե՞ս, արա՛:"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        AcceptButton = Button1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case TextBox2.Text
            Case Is = "+"
                Label3.Text = Val(TextBox1.Text) + Val(TextBox3.Text)
            Case Is = "-"
                Label3.Text = Val(TextBox1.Text) - Val(TextBox3.Text)
            Case Is = "/"
                Label3.Text = Val(TextBox1.Text) / Val(TextBox3.Text)
            Case Is = "*"
                Label3.Text = Val(TextBox1.Text) * Val(TextBox3.Text)
            Case Else
                Label3.Text = "Это не арифметический знак"
        End Select
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        AcceptButton = Button2
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        AcceptButton = Button2
    End Sub
End Class