Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            ' Create a request to Yahoo Weather for the Zip code.
            Dim rssUrl = _
                "http://xml.weather.yahoo.com/forecastrss?p=" _
                + ZipCode.Text
            Dim rssRequest As System.Net.WebRequest = _
                System.Net.WebRequest.Create(rssUrl)

            ' Save the response into a Stream object.
            Dim rssResponse As System.Net.WebResponse = rssRequest.GetResponse()
            Dim rssStream As System.IO.Stream = rssResponse.GetResponseStream()

            ' Load the Stream into an XMLDocument object.
            Dim rssDoc As New System.Xml.XmlDocument
            rssDoc.Load(rssStream)


            ' Create a nodes list under the <channel> element.
            Dim nodes As System.Xml.XmlNodeList
            nodes = rssDoc.SelectNodes("/rss/channel")

            ' Display the content of the <title> element.
            GroupBox1.Text = nodes.Item(0).SelectSingleNode("title").InnerText

            ' Create a namespace manager to allow access to elements with a yweather: namespace prefix.
            Dim nsMgr = New  _
                System.Xml.XmlNamespaceManager(rssDoc.NameTable)
            nsMgr.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0")

            ' Now display the data.
            ' Mike's note: ny-10021, ca-90021, tx-77021, fl-33140, ak-99521

            Climate.Text = _
            rssDoc.SelectSingleNode( _
                "/rss/channel/item/yweather:condition/@text", _
                nsMgr).InnerText
            Temperature.Text = _
            rssDoc.SelectSingleNode("/rss/channel/yweather:wind/@chill", nsMgr).InnerText + " F"
            Humidity.Text = _
            rssDoc.SelectSingleNode("/rss/channel/yweather:atmosphere/@humidity", nsMgr).InnerText + " %"


        Catch ex As Exception
            MsgBox("Невозможно подключиться к RSS-каналу")
        End Try

    End Sub

End Class
