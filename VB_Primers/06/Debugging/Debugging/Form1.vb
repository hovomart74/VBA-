Public Class Form1

    ' A function to return the squared value of a passed integer parameter.
    Function Square(ByVal num As Integer)

        num = (num * num)
        Return num

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Declare two local integer variables.
        Dim pass As Integer = 0
        Dim base As Integer = 2

        ' Increment the pass counter and call an external function thrice.
        For i As Integer = 1 To 2
            pass = pass + 1
            base = Square(base)
        Next

    End Sub

End Class
