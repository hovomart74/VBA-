Public Class Form1

    Dim mySS As String = "C:\Users\Овик\Downloads\Data.xlsx"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        Dim row, col, finalRow, finalCol As Integer
        Dim xl = CreateObject("Excel.Application")
        xl.workbooks.open(mySS)
        xl.Worksheets("Лист1").Activate()
        finalRow = xl.ActiveSheet.UsedRange.Rows.Count
        finalCol = xl.ActiveSheet.UsedRange.Columns.Count
        Dim vals(finalRow, finalCol) As String
        Dim zamen As String = ""
        For row = 1 To finalRow
            For col = 1 To finalCol
                If xl.ActiveSheet.Cells(row, col).Value = Nothing Then
                    zamen = "___"
                Else
                    zamen = xl.ActiveSheet.Cells(row, col).Value
                End If
                vals(row, col) = zamen
                ListBox1.Items.Insert(0, row)
                ListBox2.Items.Insert(0, col)
                ListBox3.Items.Insert(0, vals(row, col))
            Next col
        Next row
        ' Release resources.
        xl.Workbooks.Close()
        xl = Nothing

    End Sub
End Class
