Public Class Form1

    Private Sub Clear()
        Label1.Text = "..."
        Label2.Text = "..."
        Label3.Text = "..."
        Label4.Text = "..."
        Label5.Text = "..."
        Label6.Text = "..."
        PickBtn.Enabled = True
        ResetBtn.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear()
        Randomize()
    End Sub

    Private Sub ResetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetBtn.Click
        Clear()
    End Sub

    Private Sub PickBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PickBtn.Click

        ' Declare working variables.
        Dim i, r, temp, nums(50) As Integer

        ' Fill elements 1-49 with integers 1 to 49.
        For i = 1 To 49
            nums(i) = i
        Next

        ' Shuffle the values in elements 1-49.
        For i = 1 To 49
            r = Int(49 * Rnd()) + 1
            temp = nums(i)
            nums(i) = nums(r)
            nums(r) = temp
        Next

        ' Display the values in elements 1-6.
        Label1.Text = nums(1)
        Label2.Text = nums(2)
        Label3.Text = nums(3)
        Label4.Text = nums(4)
        Label5.Text = nums(5)
        Label6.Text = nums(6)

        ' Set the Button states to Done.
        PickBtn.Enabled = False
        ResetBtn.Enabled = True
    End Sub
End Class