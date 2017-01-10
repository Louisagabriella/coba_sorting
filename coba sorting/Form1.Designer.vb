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
        Me.hasil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.mat = New System.Windows.Forms.TextBox()
        Me.bind = New System.Windows.Forms.TextBox()
        Me.nis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.namad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nisd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilaimatd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilaibind = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hasil
        '
        Me.hasil.Location = New System.Drawing.Point(529, 144)
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(75, 23)
        Me.hasil.TabIndex = 0
        Me.hasil.Text = "Inputkan"
        Me.hasil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nilai Mat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nilai B.Ind"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(132, 23)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(205, 20)
        Me.nama.TabIndex = 4
        '
        'mat
        '
        Me.mat.Location = New System.Drawing.Point(132, 74)
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(205, 20)
        Me.mat.TabIndex = 5
        '
        'bind
        '
        Me.bind.Location = New System.Drawing.Point(132, 100)
        Me.bind.Name = "bind"
        Me.bind.Size = New System.Drawing.Size(205, 20)
        Me.bind.TabIndex = 6
        '
        'nis
        '
        Me.nis.Location = New System.Drawing.Point(132, 49)
        Me.nis.Name = "nis"
        Me.nis.Size = New System.Drawing.Size(205, 20)
        Me.nis.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nis"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namad, Me.nisd, Me.nilaimatd, Me.nilaibind})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(495, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'namad
        '
        Me.namad.HeaderText = "Nama"
        Me.namad.Name = "namad"
        Me.namad.Width = 150
        '
        'nisd
        '
        Me.nisd.HeaderText = "Nis"
        Me.nisd.Name = "nisd"
        '
        'nilaimatd
        '
        Me.nilaimatd.HeaderText = "Nilai Mat"
        Me.nilaimatd.Name = "nilaimatd"
        '
        'nilaibind
        '
        Me.nilaibind.HeaderText = "Nilai B.Ind"
        Me.nilaibind.Name = "nilaibind"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Mat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "B.Ind"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Urutkan Terkecil - Terbesar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Urutkan Terbesar - Terkecil"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(433, 316)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "B.Ind"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(352, 316)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Mat"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 358)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.nis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bind)
        Me.Controls.Add(Me.mat)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hasil)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hasil As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents mat As System.Windows.Forms.TextBox
    Friend WithEvents bind As System.Windows.Forms.TextBox
    Friend WithEvents nis As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents namad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nisd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nilaimatd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nilaibind As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
