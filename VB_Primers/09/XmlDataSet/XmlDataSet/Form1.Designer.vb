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
        Me.ReadBtn = New System.Windows.Forms.Button()
        Me.WriteBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New System.Data.DataSet()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReadBtn
        '
        Me.ReadBtn.Location = New System.Drawing.Point(523, 90)
        Me.ReadBtn.Name = "ReadBtn"
        Me.ReadBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReadBtn.TabIndex = 0
        Me.ReadBtn.Text = "Чтение XML"
        Me.ReadBtn.UseVisualStyleBackColor = True
        '
        'WriteBtn
        '
        Me.WriteBtn.Location = New System.Drawing.Point(523, 166)
        Me.WriteBtn.Name = "WriteBtn"
        Me.WriteBtn.Size = New System.Drawing.Size(75, 23)
        Me.WriteBtn.TabIndex = 1
        Me.WriteBtn.Text = "Запись XML"
        Me.WriteBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(505, 177)
        Me.DataGridView1.TabIndex = 2
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 201)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.WriteBtn)
        Me.Controls.Add(Me.ReadBtn)
        Me.Name = "Form1"
        Me.Text = "XmlDataSet"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReadBtn As System.Windows.Forms.Button
    Friend WithEvents WriteBtn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As System.Data.DataSet

End Class
