Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Weekday(Now) = vbSaturday) Or (Weekday(Now) = vbSunday) Then
            label1.text = "Relax - it's the weekend"
        Else
            Label1.Text = "Today's a working weekday"
        End If
    End Sub
End Class
