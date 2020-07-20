<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ColorBtn = New System.Windows.Forms.Button()
        Me.FontBtn = New System.Windows.Forms.Button()
        Me.ImgBtn = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(445, 217)
        Me.TextBox1.TabIndex = 1
        '
        'ColorBtn
        '
        Me.ColorBtn.Location = New System.Drawing.Point(189, 253)
        Me.ColorBtn.Name = "ColorBtn"
        Me.ColorBtn.Size = New System.Drawing.Size(75, 23)
        Me.ColorBtn.TabIndex = 2
        Me.ColorBtn.Text = "Цвет"
        Me.ColorBtn.UseVisualStyleBackColor = True
        '
        'FontBtn
        '
        Me.FontBtn.Location = New System.Drawing.Point(366, 253)
        Me.FontBtn.Name = "FontBtn"
        Me.FontBtn.Size = New System.Drawing.Size(75, 23)
        Me.FontBtn.TabIndex = 3
        Me.FontBtn.Text = "Шрифт"
        Me.FontBtn.UseVisualStyleBackColor = True
        '
        'ImgBtn
        '
        Me.ImgBtn.Location = New System.Drawing.Point(559, 253)
        Me.ImgBtn.Name = "ImgBtn"
        Me.ImgBtn.Size = New System.Drawing.Size(75, 23)
        Me.ImgBtn.TabIndex = 4
        Me.ImgBtn.Text = "Рисунок"
        Me.ImgBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 323)
        Me.Controls.Add(Me.ImgBtn)
        Me.Controls.Add(Me.FontBtn)
        Me.Controls.Add(Me.ColorBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ColorBtn As Button
    Friend WithEvents FontBtn As Button
    Friend WithEvents ImgBtn As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
