Public Class Form1

    Dim file As String = "books.xml"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Create an XmlDocument object.
        Dim doc As New System.Xml.XmlDocument
        doc.Load(file)

        ' Create an XmlNodeList.
        Dim nodes As System.Xml.XmlNodeList
        nodes = doc.SelectNodes("shelf/book")

        ' Display all <title> and <author> element content.
        Dim counter = 0
        Do Until counter = nodes.Count
            ListBox1.Items.Add(nodes.Item(counter) _
            .SelectSingleNode("title").InnerText & " by " _
            & nodes.Item(counter) _
            .SelectSingleNode("author").InnerText & vbCrLf)
            counter = counter + 1
        Loop

    End Sub

End Class
