﻿Public Class form1

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

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Randomize()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Clear()
        PickBtn.Focus()
    End Sub

    Private Sub PickBtn_Click(sender As Object, e As EventArgs) Handles PickBtn.Click
        Dim i, r, temp, nums(50) As Integer
        For i = 1 To 49
            nums(i) = i
        Next

        For i = 1 To 49
            r = Int(49 * Rnd()) + 1
            temp = nums(i)
            nums(i) = nums(r)
            nums(r) = temp
        Next

        ' Создадим новый массив где будем хранить отсортированные сгенерированные числа
        Dim sortednums(6) As Integer
        For i = 1 To 6
            sortednums(i) = nums(i)
        Next
        ' Отсортируем.
        Array.Sort(sortednums)

        Label1.Text = sortednums(1)
        Label2.Text = sortednums(2)
        Label3.Text = sortednums(3)
        Label4.Text = sortednums(4)
        Label5.Text = sortednums(5)
        Label6.Text = sortednums(6)
        ListBox1.Items.Insert(0, Label1.Text & "                 " &
                           Label2.Text & "                 " &
                           Label3.Text & "                 " &
                           Label4.Text & "                 " &
                           Label5.Text & "                 " &
                           Label6.Text)
        PickBtn.Enabled = False
        ResetBtn.Enabled = True
        ResetBtn.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            TextBox2.Focus()

        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            TextBox1.Focus()

        End If
    End Sub

End Class