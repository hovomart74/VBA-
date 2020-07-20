Public Class Form1

    'создаём переменную num, которую будет исползовать GetNumber 
    Dim num As Integer

    'создаём переменную tiv, которой будет присваиваться цыфровые значения
    'эти значения используются чтобы понять, угадал ли пользователь загаданное число
    Dim tiv As Integer

    'создаём событие GetNumber, которая генерирует (загадывает) те 
    'числа, которые и нужно угадывать пользователю 
    Private Sub GetNumber()
        num = Math.Ceiling(Rnd() * 100)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Msg.Text = "Я загадал число от 1 до 100 
Попробуй отгадать!"
        Randomize()
        GetNumber()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tiv = 0 Then
            Label1.Text = 1
        Else
            Label1.Text = Val(Label1.Text) + 1
        End If
        Select Case (Val(Guess.Text))
            Case Is > num
                Msg.Text = Guess.Text & " много" & "
" & Msg.Text
                tiv = 12
            Case Is < num
                Msg.Text = Guess.Text & " мало" & "
" & Msg.Text
                tiv = 15
            Case Is = num
                Msg.Text = Guess.Text & " правильно! " &
                    "
Я загадал новое число
от 1 до 100
Отгадай! "
                tiv = 0
                If Val(Label4.Text) > Val(Label1.Text) Then
                    Label4.Text = Label1.Text
                    MsgBox("УРААА!
Новый рекорд: " & Label1.Text, 48, "Окно рекордов")
                Else
                    MsgBox(Guess.Text & " Правильно! 
но " & Label1.Text & " попыток, многовато для рекорда", 64, "Окно рекордов")
                End If
                GetNumber()
        End Select
        Guess.Text = ""
    End Sub

    Private Sub Guess_TextChanged(sender As Object, e As EventArgs) Handles Guess.TextChanged
        AcceptButton = Button1
    End Sub
End Class
