Public Class Form1

    Private Sub Compile_Errors()

        ' Remove the ' to uncomment each example.

        ' Example 1. InvalidCastException.
        ' Dim num As Double = 7.5
        ' Dim str As String = "five"
        ' MsgBox(num * Str())


        ' Example 2. IndexOutOfRangeException.
        'Dim i, nums(10) As Integer
        'For i = 1 To 20
        'nums(i) = i
        'Next i


        ' Example 3. FileNotFoundException.
        ' Dim streamer As New System.IO.StreamReader("nonsuch.txt")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Call to produce an error.
        Compile_Errors()

    End Sub
End Class
