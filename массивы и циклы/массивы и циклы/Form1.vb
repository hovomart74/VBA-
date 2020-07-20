Public Class Form1
    Dim b As Double
    Dim sum As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        sum = 0
        Dim a As Double
        b = Val(TextBox1.Text)
        For i = 1 To Val(TextBox3.Text)
            a = b + Val(TextBox2.Text)
            If Val(TextBox2.Text) < 0 Then
                ListBox1.Items.Insert(0, b & Val(TextBox2.Text) & "=" & a)
            Else
                ListBox1.Items.Insert(0, b & "+" & Val(TextBox2.Text) & "=" & a)
            End If
            sum = sum + a
            Label7.Text = "Сумма всех результатов:
" & sum
            b = a
            Label1.Text = "циклов:
" & i


        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Label7.Text = ""
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        sum = 0
        Dim a As Double
        b = Val(TextBox1.Text)
        For i = 1 To Val(TextBox3.Text)
            a = b + Val(TextBox2.Text)
            If Val(TextBox2.Text) < 0 Then
                ListBox1.Items.Add(b & Val(TextBox2.Text) & "=" & a)
            Else
                ListBox1.Items.Add(b & "+" & Val(TextBox2.Text) & "=" & a)
            End If
            sum = sum + a
            Label7.Text = "Сумма всех результатов:
" & sum
            b = a
            Label1.Text = "циклов:
" & i
        Next
    End Sub
End Class
