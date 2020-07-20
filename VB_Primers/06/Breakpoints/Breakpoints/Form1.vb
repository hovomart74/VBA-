Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declare counter variables.
        Dim i, j, k As Integer

        ' Iteration total variable.
        Dim pass As Integer = 0

        ' Nested loops.
        For i = 1 To 3
            For j = 1 To 3
                For k = 1 To 3
                    pass = pass + 1
                Next k
            Next j
        Next i

    End Sub

End Class
