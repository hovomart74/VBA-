Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ProschitatButton.Click
        If DeistvieComboBox.Text = "+" Then
            RezultatListBox.Items.Add(Num1TextBox.Text & DeistvieComboBox.Text & Num2TextBox.Text & "=" &
                                      Val(Num1TextBox.Text) + Val(Num2TextBox.Text))
        End If
        If DeistvieComboBox.Text = "-" Then
            RezultatListBox.Items.Add(Num1TextBox.Text & DeistvieComboBox.Text & Num2TextBox.Text & "=" &
                                      Val(Num1TextBox.Text) - Val(Num2TextBox.Text))
        End If
        If DeistvieComboBox.Text = "/" Then
            RezultatListBox.Items.Add(Num1TextBox.Text & DeistvieComboBox.Text & Num2TextBox.Text & "=" &
                                      Val(Num1TextBox.Text) / Val(Num2TextBox.Text))
        End If
        If DeistvieComboBox.Text = "*" Then
            RezultatListBox.Items.Add(Num1TextBox.Text & DeistvieComboBox.Text & Num2TextBox.Text & "=" &
                                      Val(Num1TextBox.Text) * Val(Num2TextBox.Text))
        End If
        Timer1.Enabled = True
        If DeistvieComboBox.Text = "+" Then
            RezultatRichTextBox.Text = (Num1TextBox.Text & DeistvieComboBox.Text & Num2TextBox.Text & "=" &
                                      Val(Num1TextBox.Text) + Val(Num2TextBox.Text))
        End If
        If DeistvieComboBox.Text = "-" Then
            RezultatRichTextBox.Text = (Num1TextBox.Text & DeistvieComboBox.Text & Num2TextBox.Text & "=" &
                                      Val(Num1TextBox.Text) - Val(Num2TextBox.Text))
        End If
        If DeistvieComboBox.Text = "/" Then
            RezultatRichTextBox.Text = (Num1TextBox.Text & DeistvieComboBox.Text & Num2TextBox.Text & "=" &
                                      Val(Num1TextBox.Text) / Val(Num2TextBox.Text))
        End If
        If DeistvieComboBox.Text = "*" Then
            RezultatRichTextBox.Text = (Num1TextBox.Text & DeistvieComboBox.Text & Num2TextBox.Text & "=" &
                                      Val(Num1TextBox.Text) * Val(Num2TextBox.Text))
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub SbrosButton_Click(sender As Object, e As EventArgs) Handles SbrosButton.Click
        Num1TextBox.Text = ""
        Num2TextBox.Text = ""
        DeistvieComboBox.Text = ""
        Timer1.Enabled = False
    End Sub

    Private Sub RezultatListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RezultatListBox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RezultatListBox.Items.Clear()
        Timer1.Enabled = False
    End Sub

    Private Sub Num2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Num2TextBox.TextChanged
        Me.AcceptButton = ProschitatButton
    End Sub


End Class
