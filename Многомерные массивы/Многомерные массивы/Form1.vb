Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sales(1.2) As Double
        Dim store1, store2 As Double
        sales(0.0) = 1255 : sales(0.1) = 1845.5 : sales(0.2) = 1065
        sales(1.0) = 2175 : sales(1.1) = 2215.5 : sales(1.2) = 2453
        store1 = sales(0.0) + sales(0.1) + sales(0.2)
        store2 = sales(1.0) + sales(1.1) + sales(1.2)
        MsgBox("Квартальные продажи....." & vbCrLf &
               "Магазин 1: " & FormatCurrency(store1) & vbCrLf &
               "Магазин 2: " & FormatCurrency(store2))

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Weekday(Now) = vbSaturday) Or (Weekday(Now) = vbSunday) Then
            Label1.Text = "Расслабьтесь: Сегодня выходной"
        Else
            Label1.Text = "Соберитесь: сегодня рабочий день"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim amount As Double = Val(TextBox1.Text)
        Dim counter As Integer
        For counter = 1 To 100
            ListBox1.Items.Add("Значение " & counter _
                               & "% равно" &
                               FormatCurrency((amount * counter) / 100))
        Next counter

    End Sub


End Class
