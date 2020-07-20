Public Class Form1
    Private Sub ReadBtn_Click(sender As Object, e As EventArgs) Handles ReadBtn.Click
        DataSet1.ReadXml("books.xml")

        ' Display the DataSet in the DataGridView control.
        DataGridView1.DataSource = DataSet1

        ' Define the parent XML element.
        DataGridView1.DataMember = "item"

    End Sub

    Private Sub WriteBtn_Click(sender As Object, e As EventArgs) Handles WriteBtn.Click
        ' Write the current data in the DataSet from  memory to the file.
        DataSet1.WriteXml("books02.xml")
    End Sub
End Class
