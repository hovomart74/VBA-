<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProschitatButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DeistvieComboBox = New System.Windows.Forms.ComboBox()
        Me.Num1TextBox = New System.Windows.Forms.TextBox()
        Me.Num2TextBox = New System.Windows.Forms.TextBox()
        Me.SbrosButton = New System.Windows.Forms.Button()
        Me.RezultatListBox = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RezultatRichTextBox = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProschitatButton
        '
        Me.ProschitatButton.Location = New System.Drawing.Point(343, 13)
        Me.ProschitatButton.Name = "ProschitatButton"
        Me.ProschitatButton.Size = New System.Drawing.Size(100, 39)
        Me.ProschitatButton.TabIndex = 2
        Me.ProschitatButton.Text = "Просчитать"
        Me.ProschitatButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Timer.My.Resources.Resources.ВМ35К_1
        Me.PictureBox1.Location = New System.Drawing.Point(18, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Timer.My.Resources.Resources.ВМ50К_1
        Me.PictureBox2.Location = New System.Drawing.Point(18, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 192)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'DeistvieComboBox
        '
        Me.DeistvieComboBox.FormattingEnabled = True
        Me.DeistvieComboBox.Items.AddRange(New Object() {"+", "-", "/", "*"})
        Me.DeistvieComboBox.Location = New System.Drawing.Point(150, 12)
        Me.DeistvieComboBox.Name = "DeistvieComboBox"
        Me.DeistvieComboBox.Size = New System.Drawing.Size(45, 21)
        Me.DeistvieComboBox.TabIndex = 3
        '
        'Num1TextBox
        '
        Me.Num1TextBox.Location = New System.Drawing.Point(24, 12)
        Me.Num1TextBox.Name = "Num1TextBox"
        Me.Num1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Num1TextBox.TabIndex = 4
        '
        'Num2TextBox
        '
        Me.Num2TextBox.Location = New System.Drawing.Point(218, 13)
        Me.Num2TextBox.Name = "Num2TextBox"
        Me.Num2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Num2TextBox.TabIndex = 5
        '
        'SbrosButton
        '
        Me.SbrosButton.Location = New System.Drawing.Point(477, 12)
        Me.SbrosButton.Name = "SbrosButton"
        Me.SbrosButton.Size = New System.Drawing.Size(75, 48)
        Me.SbrosButton.TabIndex = 7
        Me.SbrosButton.Text = "Сброс"
        Me.SbrosButton.UseVisualStyleBackColor = True
        '
        'RezultatListBox
        '
        Me.RezultatListBox.FormattingEnabled = True
        Me.RezultatListBox.Items.AddRange(New Object() {"Расчёты"})
        Me.RezultatListBox.Location = New System.Drawing.Point(218, 99)
        Me.RezultatListBox.Name = "RezultatListBox"
        Me.RezultatListBox.Size = New System.Drawing.Size(314, 108)
        Me.RezultatListBox.Sorted = True
        Me.RezultatListBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(379, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Очистка результатов"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RezultatRichTextBox
        '
        Me.RezultatRichTextBox.Location = New System.Drawing.Point(218, 65)
        Me.RezultatRichTextBox.Name = "RezultatRichTextBox"
        Me.RezultatRichTextBox.Size = New System.Drawing.Size(314, 28)
        Me.RezultatRichTextBox.TabIndex = 10
        Me.RezultatRichTextBox.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 280)
        Me.Controls.Add(Me.RezultatRichTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RezultatListBox)
        Me.Controls.Add(Me.SbrosButton)
        Me.Controls.Add(Me.Num2TextBox)
        Me.Controls.Add(Me.Num1TextBox)
        Me.Controls.Add(Me.DeistvieComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProschitatButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ProschitatButton As Button
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents DeistvieComboBox As ComboBox
    Friend WithEvents Num1TextBox As TextBox
    Friend WithEvents Num2TextBox As TextBox
    Friend WithEvents SbrosButton As Button
    Friend WithEvents RezultatListBox As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RezultatRichTextBox As RichTextBox
End Class
