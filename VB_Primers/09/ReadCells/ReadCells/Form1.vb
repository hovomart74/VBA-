Public Class Form1

    Dim file As String = "Data.xlsx"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ' Declare counter variables.
            Dim row, col, finalRow, finalCol As Integer

            ' Open the spreadsheet.
            Dim xl = CreateObject("Excel.application")
            xl.Workbooks.Open(file)
            xl.Worksheets("Sheet1").activate()

            ' Count the number of used rows and columns.
            finalRow = xl.ActiveSheet.UsedRange.Rows.Count
            finalCol = xl.ActiveSheet.UsedRange.Columns.Count

            ' Create a 2-dimensional array of the same size.
            Dim vals(finalRow, finalCol) As String

            ' Assign and display all cell values.
            For row = 1 To finalRow
                For col = 1 To finalCol
                    vals(row, col) = _
                    Str(xl.ActiveSheet.Cells(row, col).Value)
                    ListBox1.Items.Add(row)
                    ListBox2.Items.Add(col)
                    ListBox3.Items.Add(vals(row, col))
                Next col
            Next row

            ' Release resources.
            xl.Workbooks.Close()
            xl = Nothing
        Catch ex As Exception
            MsgBox("Невозможно прочитать таблицу")
        End Try

    End Sub
End Class
