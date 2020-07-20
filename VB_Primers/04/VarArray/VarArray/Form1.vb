Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim Sales(2) As Double
        'Sales(0) = 5245.0
        'Sales(1) = 4785.0
        'Sales(2) = 7365.5

        'Dim Quarter As Double = Sales(0) + Sales(1) + Sales(2)
        'MsgBox("Quarter Sales: " & FormatCurrency(Quarter))

        Dim Sales(2, 1) As Double
        Sales(0, 0) = 1255 : Sales(1, 0) = 1845.5 : Sales(2, 0) = 1065
        Sales(0, 1) = 2175 : Sales(1, 1) = 2215.5 : Sales(2, 1) = 2453

        Dim Store1, Store2 As Double
        Store1 = Sales(0, 0) + Sales(1, 0) + Sales(2, 0)
        Store2 = Sales(0, 1) + Sales(1, 1) + Sales(2, 1)

        MsgBox("Квартальные продажи... " & vbCrLf &
               "Магазин1: " & FormatCurrency(Store1) & vbCrLf &
               "Магазин2: " & FormatCurrency(Store2))

    End Sub
End Class
