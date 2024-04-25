<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fklolauser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fklolauser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnKelolaLaporan = New System.Windows.Forms.Button()
        Me.BtnKelolaObat = New System.Windows.Forms.Button()
        Me.BtnKelolaUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tumbal = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxbSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Btntambah = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxbPw = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxbUsn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbNotlp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbNama = New System.Windows.Forms.TextBox()
        Me.TipeUser = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnKelolaLaporan)
        Me.Panel1.Controls.Add(Me.BtnKelolaObat)
        Me.Panel1.Controls.Add(Me.BtnKelolaUser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 494)
        Me.Panel1.TabIndex = 10
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.Location = New System.Drawing.Point(24, 406)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(195, 64)
        Me.BtnLogout.TabIndex = 3
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnKelolaLaporan
        '
        Me.BtnKelolaLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.BtnKelolaLaporan.Location = New System.Drawing.Point(24, 336)
        Me.BtnKelolaLaporan.Name = "BtnKelolaLaporan"
        Me.BtnKelolaLaporan.Size = New System.Drawing.Size(195, 64)
        Me.BtnKelolaLaporan.TabIndex = 2
        Me.BtnKelolaLaporan.Text = "Kelola laporan"
        Me.BtnKelolaLaporan.UseVisualStyleBackColor = True
        '
        'BtnKelolaObat
        '
        Me.BtnKelolaObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnKelolaObat.Location = New System.Drawing.Point(24, 266)
        Me.BtnKelolaObat.Name = "BtnKelolaObat"
        Me.BtnKelolaObat.Size = New System.Drawing.Size(195, 64)
        Me.BtnKelolaObat.TabIndex = 1
        Me.BtnKelolaObat.Text = "Kelola Obat"
        Me.BtnKelolaObat.UseVisualStyleBackColor = True
        '
        'BtnKelolaUser
        '
        Me.BtnKelolaUser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnKelolaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKelolaUser.Location = New System.Drawing.Point(24, 196)
        Me.BtnKelolaUser.Name = "BtnKelolaUser"
        Me.BtnKelolaUser.Size = New System.Drawing.Size(195, 64)
        Me.BtnKelolaUser.TabIndex = 0
        Me.BtnKelolaUser.Text = "Kelola User"
        Me.BtnKelolaUser.UseVisualStyleBackColor = False
        Me.BtnKelolaUser.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.tumbal)
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxbSearch)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.BtnHapus)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.Btntambah)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TxbPw)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TxbUsn)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxbNotlp)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxbAlamat)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxbNama)
        Me.Panel2.Controls.Add(Me.TipeUser)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(260, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 494)
        Me.Panel2.TabIndex = 11
        '
        'tumbal
        '
        Me.tumbal.Location = New System.Drawing.Point(55, 44)
        Me.tumbal.Name = "tumbal"
        Me.tumbal.Size = New System.Drawing.Size(100, 20)
        Me.tumbal.TabIndex = 21
        Me.tumbal.Visible = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 342)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(570, 137)
        Me.DGV.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(279, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(16, 215)
        Me.Panel3.TabIndex = 19
        '
        'TxbSearch
        '
        Me.TxbSearch.Location = New System.Drawing.Point(424, 313)
        Me.TxbSearch.Multiline = True
        Me.TxbSearch.Name = "TxbSearch"
        Me.TxbSearch.Size = New System.Drawing.Size(158, 23)
        Me.TxbSearch.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(350, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cari User"
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHapus.Location = New System.Drawing.Point(228, 305)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(102, 29)
        Me.BtnHapus.TabIndex = 15
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEdit.Location = New System.Drawing.Point(120, 305)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(102, 29)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'Btntambah
        '
        Me.Btntambah.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Btntambah.Location = New System.Drawing.Point(12, 305)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(102, 29)
        Me.Btntambah.TabIndex = 13
        Me.Btntambah.Text = "Tambah"
        Me.Btntambah.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(452, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Passsword"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxbPw
        '
        Me.TxbPw.Location = New System.Drawing.Point(324, 261)
        Me.TxbPw.Multiline = True
        Me.TxbPw.Name = "TxbPw"
        Me.TxbPw.Size = New System.Drawing.Size(220, 20)
        Me.TxbPw.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(450, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "User Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxbUsn
        '
        Me.TxbUsn.Location = New System.Drawing.Point(324, 191)
        Me.TxbUsn.Multiline = True
        Me.TxbUsn.Name = "TxbUsn"
        Me.TxbUsn.Size = New System.Drawing.Size(220, 20)
        Me.TxbUsn.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(320, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No. Telepon"
        '
        'TxbNotlp
        '
        Me.TxbNotlp.Location = New System.Drawing.Point(324, 115)
        Me.TxbNotlp.Multiline = True
        Me.TxbNotlp.Name = "TxbNotlp"
        Me.TxbNotlp.Size = New System.Drawing.Size(220, 20)
        Me.TxbNotlp.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(38, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alamat"
        '
        'TxbAlamat
        '
        Me.TxbAlamat.Location = New System.Drawing.Point(42, 266)
        Me.TxbAlamat.Multiline = True
        Me.TxbAlamat.Name = "TxbAlamat"
        Me.TxbAlamat.Size = New System.Drawing.Size(220, 20)
        Me.TxbAlamat.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(38, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama"
        '
        'TxbNama
        '
        Me.TxbNama.Location = New System.Drawing.Point(42, 196)
        Me.TxbNama.Multiline = True
        Me.TxbNama.Name = "TxbNama"
        Me.TxbNama.Size = New System.Drawing.Size(220, 20)
        Me.TxbNama.TabIndex = 3
        '
        'TipeUser
        '
        Me.TipeUser.FormattingEnabled = True
        Me.TipeUser.Items.AddRange(New Object() {"apoteker", "kasir", "admin"})
        Me.TipeUser.Location = New System.Drawing.Point(40, 120)
        Me.TipeUser.Name = "TipeUser"
        Me.TipeUser.Size = New System.Drawing.Size(222, 21)
        Me.TipeUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(38, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipe User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelola User"
        '
        'Fklolauser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApotekLoremIpsum.My.Resources.Resources._93368
        Me.ClientSize = New System.Drawing.Size(867, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Fklolauser"
        Me.Text = "Kelola User"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnKelolaLaporan As Button
    Friend WithEvents BtnKelolaObat As Button
    Friend WithEvents BtnKelolaUser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxbSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Btntambah As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxbPw As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxbUsn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbNotlp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbNama As TextBox
    Friend WithEvents TipeUser As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents tumbal As TextBox
End Class
