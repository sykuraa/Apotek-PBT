<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKlolaObat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FKlolaObat))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbKodeObt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbNamaObt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbJumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxbSearch = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tumbal = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnKelolaLaporan = New System.Windows.Forms.Button()
        Me.BtnKelolaObat = New System.Windows.Forms.Button()
        Me.BtnKelolaUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelola Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(38, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Obat"
        '
        'TxbKodeObt
        '
        Me.TxbKodeObt.Location = New System.Drawing.Point(42, 115)
        Me.TxbKodeObt.Multiline = True
        Me.TxbKodeObt.Name = "TxbKodeObt"
        Me.TxbKodeObt.Size = New System.Drawing.Size(220, 20)
        Me.TxbKodeObt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(38, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Obat"
        '
        'TxbNamaObt
        '
        Me.TxbNamaObt.Location = New System.Drawing.Point(42, 196)
        Me.TxbNamaObt.Multiline = True
        Me.TxbNamaObt.Name = "TxbNamaObt"
        Me.TxbNamaObt.Size = New System.Drawing.Size(220, 20)
        Me.TxbNamaObt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(38, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Expired Date"
        '
        'TxbJumlah
        '
        Me.TxbJumlah.Location = New System.Drawing.Point(324, 115)
        Me.TxbJumlah.Multiline = True
        Me.TxbJumlah.Name = "TxbJumlah"
        Me.TxbJumlah.Size = New System.Drawing.Size(220, 20)
        Me.TxbJumlah.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(320, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jumlah"
        '
        'TxbHarga
        '
        Me.TxbHarga.Location = New System.Drawing.Point(324, 191)
        Me.TxbHarga.Multiline = True
        Me.TxbHarga.Name = "TxbHarga"
        Me.TxbHarga.Size = New System.Drawing.Size(220, 20)
        Me.TxbHarga.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(324, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Harga Per Unit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTambah.Location = New System.Drawing.Point(12, 305)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(102, 29)
        Me.BtnTambah.TabIndex = 13
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
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
        'TxbSearch
        '
        Me.TxbSearch.Location = New System.Drawing.Point(424, 313)
        Me.TxbSearch.Multiline = True
        Me.TxbSearch.Name = "TxbSearch"
        Me.TxbSearch.Size = New System.Drawing.Size(158, 23)
        Me.TxbSearch.TabIndex = 17
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
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(45, 271)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(217, 20)
        Me.dtp.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.tumbal)
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Controls.Add(Me.dtp)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TxbSearch)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.BtnHapus)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnTambah)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TxbHarga)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxbJumlah)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxbNamaObt)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TxbKodeObt)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(260, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 494)
        Me.Panel2.TabIndex = 13
        '
        'tumbal
        '
        Me.tumbal.Location = New System.Drawing.Point(71, 32)
        Me.tumbal.Name = "tumbal"
        Me.tumbal.Size = New System.Drawing.Size(100, 20)
        Me.tumbal.TabIndex = 22
        Me.tumbal.Visible = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 340)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(570, 137)
        Me.DGV.TabIndex = 21
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
        Me.Panel1.TabIndex = 21
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
        Me.BtnKelolaObat.Visible = False
        '
        'BtnKelolaUser
        '
        Me.BtnKelolaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKelolaUser.Location = New System.Drawing.Point(24, 196)
        Me.BtnKelolaUser.Name = "BtnKelolaUser"
        Me.BtnKelolaUser.Size = New System.Drawing.Size(195, 64)
        Me.BtnKelolaUser.TabIndex = 0
        Me.BtnKelolaUser.Text = "Kelola User"
        Me.BtnKelolaUser.UseVisualStyleBackColor = True
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
        'FKlolaObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApotekLoremIpsum.My.Resources.Resources._93368
        Me.ClientSize = New System.Drawing.Size(867, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FKlolaObat"
        Me.Text = "Kelola Obat"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbKodeObt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbNamaObt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbJumlah As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxbSearch As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnKelolaLaporan As Button
    Friend WithEvents BtnKelolaObat As Button
    Friend WithEvents BtnKelolaUser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tumbal As TextBox
End Class
