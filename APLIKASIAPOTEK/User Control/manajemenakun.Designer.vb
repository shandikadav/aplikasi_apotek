<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manajemenakun
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_uname = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_role = New System.Windows.Forms.ComboBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_cari = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(791, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MANAJEMEN AKUN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ROLE"
        '
        'txt_uname
        '
        Me.txt_uname.Location = New System.Drawing.Point(243, 259)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(295, 20)
        Me.txt_uname.TabIndex = 4
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(243, 293)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(295, 20)
        Me.txt_pass.TabIndex = 4
        '
        'txt_role
        '
        Me.txt_role.FormattingEnabled = True
        Me.txt_role.Items.AddRange(New Object() {"Operator", "Pimpinan", "Apoteker"})
        Me.txt_role.Location = New System.Drawing.Point(243, 327)
        Me.txt_role.Name = "txt_role"
        Me.txt_role.Size = New System.Drawing.Size(295, 21)
        Me.txt_role.TabIndex = 5
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_simpan.Location = New System.Drawing.Point(22, 444)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(140, 37)
        Me.btn_simpan.TabIndex = 6
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_ubah.FlatAppearance.BorderSize = 0
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_ubah.Location = New System.Drawing.Point(350, 444)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(140, 37)
        Me.btn_ubah.TabIndex = 6
        Me.btn_ubah.Text = "UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_hapus.FlatAppearance.BorderSize = 0
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_hapus.Location = New System.Drawing.Point(633, 444)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(140, 37)
        Me.btn_hapus.TabIndex = 6
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_cari
        '
        Me.btn_cari.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btn_cari.FlatAppearance.BorderSize = 0
        Me.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cari.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cari.Location = New System.Drawing.Point(544, 255)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(147, 26)
        Me.btn_cari.TabIndex = 6
        Me.btn_cari.Text = "Cari berdasarkan Username"
        Me.btn_cari.UseVisualStyleBackColor = False
        '
        'manajemenakun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_role)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_uname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "manajemenakun"
        Me.Size = New System.Drawing.Size(798, 629)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_role As ComboBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_cari As Button
End Class
