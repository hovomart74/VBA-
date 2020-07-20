Public Class Form1

    ' Create an instance of the system SoundPlayer.
    Friend WithEvents player As New System.Media.SoundPlayer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Play a resource sound.
        player.Stream = My.Resources.tada
        player.Play()

    End Sub

End Class
