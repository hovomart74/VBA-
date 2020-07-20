Public Class Form1
    Private Function Inches(ByVal Cm As String) As Double
        Inches = Cm / 2.54
        Inches = FormatNumber(Inches, 2)
        Return Inches
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label3.Text = Inches(TextBox1.Text) & " дюймов"
    End Sub
End Class
