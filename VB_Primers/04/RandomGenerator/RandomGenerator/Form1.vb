Public Class Form1
    Dim num As Integer
    Private Sub GetNumber()
        num = Math.Ceiling(Rnd() * 20)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        GetNumber()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case (Val(Guess.Text))
            Case Is > num
                Msg.Text = Guess.Text & " слишком велико"
            Case Is < num
                Msg.Text = Guess.Text & " слишком мало"
            Case Is = num
                Msg.Text = Guess.Text & " правильно" & vbCrLf & "Я загадал новое число. Отгадай!"
                GetNumber()
        End Select
    End Sub
End Class
