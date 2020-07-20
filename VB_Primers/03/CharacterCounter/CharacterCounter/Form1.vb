Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Вы ввели: " & Str(Len(TextBox1.Text)) & " символов")
    End Sub
End Class
