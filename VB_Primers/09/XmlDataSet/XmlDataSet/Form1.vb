Public Class Form1

    Dim file As String = "books.xml"
    
    Private Sub ReadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadBtn.Click

        ' Read the XML data into the dataset.
        DataSet1.ReadXml(file)

        ' Display the DataSet in the DataGridView control.
        DataGridView1.DataSource = DataSet1

        ' Define the parent XML element.
        DataGridView1.DataMember = "book"

    End Sub

    Private Sub WriteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteBtn.Click

        ' Write the current data in the DataSet from  memory to the file.
        DataSet1.WriteXml(file)
    End Sub

End Class
