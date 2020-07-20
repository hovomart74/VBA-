Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim amount As Double = Val(TextBox1.Text)
        Dim counter As Integer
        For counter = 1 To 10
            ListBox1.Items.Add("Значение " & counter & "% равно " & FormatCurrency((amount * counter) / 100))
        Next counter
    End Sub
End Class
