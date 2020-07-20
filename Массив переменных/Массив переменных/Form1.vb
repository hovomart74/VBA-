Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sales(2) As Double
        Sales(0) = 5245.0
        Sales(1) = 4785.0
        Sales(2) = 7365.5
        Dim Kvartal As Double
        Kvartal = Sales(0) + Sales(1) + Sales(2)
        MsgBox("Квартальные отчёты: " & FormatCurrency(Kvartal))
    End Sub
End Class
