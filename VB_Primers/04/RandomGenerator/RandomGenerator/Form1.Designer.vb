<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Msg = New System.Windows.Forms.Label()
        Me.Guess = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Msg
        '
        Me.Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Msg.Location = New System.Drawing.Point(12, 9)
        Me.Msg.Name = "Msg"
        Me.Msg.Size = New System.Drawing.Size(331, 48)
        Me.Msg.TabIndex = 0
        Me.Msg.Text = "Я загадал число между 1 и 20. Попробуй отгадать!"
        '
        'Guess
        '
        Me.Guess.Location = New System.Drawing.Point(16, 73)
        Me.Guess.Name = "Guess"
        Me.Guess.Size = New System.Drawing.Size(100, 20)
        Me.Guess.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(166, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Попробовать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 128)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Guess)
        Me.Controls.Add(Me.Msg)
        Me.Name = "Form1"
        Me.Text = "RandomGenerator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Msg As System.Windows.Forms.Label
    Friend WithEvents Guess As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
