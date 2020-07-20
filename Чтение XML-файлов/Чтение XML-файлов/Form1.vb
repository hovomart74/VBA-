Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doc As New System.Xml.XmlDocument
        doc.Load("C:\Users\Овик\Downloads\books.xml")

        Dim nodes As System.Xml.XmlNodeList
        nodes = doc.SelectNodes("catalog/dveri/item")

        Dim counter = 0
        Do Until counter = nodes.Count
            ListBox1.Items.Add(nodes.Item(counter) _
            .SelectSingleNode("name").InnerText & " by " _
            & nodes.Item(counter) _
            .SelectSingleNode("brand").InnerText & vbCrLf)
            counter = counter + 1
        Loop

    End Sub
End Class
