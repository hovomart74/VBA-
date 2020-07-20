Public Class Form1
    ' Form declarations section.
    ' Declare a project-wide variable.
    Public globalVar As String = "Привет из Проекта"

    ' Declare a module-wide variable.
    Private formVar As String = "Привет из этого Модуля"


    Private Sub Button1_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles Button1.Click
        Dim msg As String = "Привет из Sub Button1"
        MsgBox(msg)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msg As String = "Привет из Sub Button2"
        MsgBox(msg)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox(globalVar & vbCrLf & formVar)
    End Sub
End Class
