Public Class Form1
    ''' <summary>
    ''' путь к папке со СТАРЫМИ фотками, которые ещё не переименованы. 
    ''' В конце отсутствует знк "\"
    ''' </summary>
    Dim PutStarFoto As String = "D:\диск Д\000 прайсы\Ватермарк\фотки стар"

    ''' <summary>
    ''' путь к папке с НОВЫМИ фотками, которые уже переименованы. 
    ''' В конце отсутствует знк "\"
    ''' </summary>
    Dim PutNovFoto As String = "D:\фото кайзер"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MasStarFoto() As String = IO.Directory.GetFiles(PutStarFoto)
        Dim MasNovFoto(MasStarFoto.GetUpperBound(0)) As String
        For i = MasStarFoto.GetLowerBound(0) To MasStarFoto.GetUpperBound(0)
            MasNovFoto(i) = MasStarFoto(i).Replace(PutStarFoto & "\ВМ", PutNovFoto & "\ВМК").
                Replace("К-", "-")
            FileIO.FileSystem.CopyFile(MasStarFoto(i), MasNovFoto(i))
        Next i

        'по окончании воспроизводит звук
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
    End Sub
End Class
