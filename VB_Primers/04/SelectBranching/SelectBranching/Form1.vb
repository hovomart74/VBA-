Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Weekday(Now)
            Case Is = vbSaturday
                Label1.Text = "Сегодня супер-суббота"
            Case Is = vbSunday
                Label1.Text = "Сегодня ленивое воскресенье"
            Case Else
                Label1.Text = "Сегодня еще один рабочий день"
        End Select
    End Sub
End Class
