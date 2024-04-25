<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FKasir))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IdUser = New System.Windows.Forms.TextBox()
        Me.tumbal = New System.Windows.Forms.TextBox()
        Me.waktu = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WaktuTransaksi = New System.Windows.Forms.Label()
        Me.TxbNamaObat = New System.Windows.Forms.TextBox()
        Me.waktusekarang = New System.Windows.Forms.DateTimePicker()
        Me.BtnPrintSave = New System.Windows.Forms.Button()
        Me.TxbBayar = New System.Windows.Forms.TextBox()
        Me.BtnKosong = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxbJumlah = New System.Windows.Forms.TextBox()
        Me.TxbHarga = New System.Windows.Forms.TextBox()
        Me.CbxNamaObat = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxbNamaDokter = New System.Windows.Forms.TextBox()
        Me.TxbNamaPasien = New System.Windows.Forms.TextBox()
        Me.dtpTanggalResep = New System.Windows.Forms.DateTimePicker()
        Me.TxbNoResep = New System.Windows.Forms.TextBox()
        Me.Kembalian = New System.Windows.Forms.Label()
        Me.TotalHarga = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TipeResep = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'IdUser
        '
        Me.IdUser.Location = New System.Drawing.Point(316, 15)
        Me.IdUser.Name = "IdUser"
        Me.IdUser.Size = New System.Drawing.Size(100, 20)
        Me.IdUser.TabIndex = 97
        '
        'tumbal
        '
        Me.tumbal.Location = New System.Drawing.Point(166, 15)
        Me.tumbal.Name = "tumbal"
        Me.tumbal.Size = New System.Drawing.Size(100, 20)
        Me.tumbal.TabIndex = 96
        '
        'waktu
        '
        Me.waktu.AutoSize = True
        Me.waktu.Location = New System.Drawing.Point(503, 11)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(10, 13)
        Me.waktu.TabIndex = 95
        Me.waktu.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(447, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Ahmad"
        '
        'WaktuTransaksi
        '
        Me.WaktuTransaksi.AutoSize = True
        Me.WaktuTransaksi.Location = New System.Drawing.Point(285, 15)
        Me.WaktuTransaksi.Name = "WaktuTransaksi"
        Me.WaktuTransaksi.Size = New System.Drawing.Size(0, 13)
        Me.WaktuTransaksi.TabIndex = 93
        '
        'TxbNamaObat
        '
        Me.TxbNamaObat.Location = New System.Drawing.Point(310, 122)
        Me.TxbNamaObat.Name = "TxbNamaObat"
        Me.TxbNamaObat.Size = New System.Drawing.Size(222, 20)
        Me.TxbNamaObat.TabIndex = 92
        Me.TxbNamaObat.Visible = False
        '
        'waktusekarang
        '
        Me.waktusekarang.Location = New System.Drawing.Point(493, 33)
        Me.waktusekarang.Name = "waktusekarang"
        Me.waktusekarang.Size = New System.Drawing.Size(131, 20)
        Me.waktusekarang.TabIndex = 91
        '
        'BtnPrintSave
        '
        Me.BtnPrintSave.Location = New System.Drawing.Point(426, 434)
        Me.BtnPrintSave.Name = "BtnPrintSave"
        Me.BtnPrintSave.Size = New System.Drawing.Size(87, 43)
        Me.BtnPrintSave.TabIndex = 89
        Me.BtnPrintSave.Text = "Print and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnPrintSave.UseVisualStyleBackColor = True
        '
        'TxbBayar
        '
        Me.TxbBayar.Location = New System.Drawing.Point(81, 460)
        Me.TxbBayar.Name = "TxbBayar"
        Me.TxbBayar.Size = New System.Drawing.Size(114, 20)
        Me.TxbBayar.TabIndex = 88
        '
        'BtnKosong
        '
        Me.BtnKosong.Location = New System.Drawing.Point(378, 240)
        Me.BtnKosong.Name = "BtnKosong"
        Me.BtnKosong.Size = New System.Drawing.Size(99, 23)
        Me.BtnKosong.TabIndex = 87
        Me.BtnKosong.Text = "Kosongkan"
        Me.BtnKosong.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(96, 237)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(99, 23)
        Me.BtnTambah.TabIndex = 86
        Me.BtnTambah.Text = "Tambahkan"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxbJumlah
        '
        Me.TxbJumlah.Location = New System.Drawing.Point(326, 211)
        Me.TxbJumlah.Name = "TxbJumlah"
        Me.TxbJumlah.Size = New System.Drawing.Size(222, 20)
        Me.TxbJumlah.TabIndex = 85
        '
        'TxbHarga
        '
        Me.TxbHarga.Location = New System.Drawing.Point(326, 168)
        Me.TxbHarga.Name = "TxbHarga"
        Me.TxbHarga.Size = New System.Drawing.Size(222, 20)
        Me.TxbHarga.TabIndex = 84
        '
        'CbxNamaObat
        '
        Me.CbxNamaObat.FormattingEnabled = True
        Me.CbxNamaObat.Items.AddRange(New Object() {"Asmurat", "Repatis", "Kebas", "Iprof", "Sepuh"})
        Me.CbxNamaObat.Location = New System.Drawing.Point(326, 121)
        Me.CbxNamaObat.Name = "CbxNamaObat"
        Me.CbxNamaObat.Size = New System.Drawing.Size(222, 21)
        Me.CbxNamaObat.TabIndex = 83
        Me.CbxNamaObat.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 494)
        Me.Panel1.TabIndex = 20
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.Location = New System.Drawing.Point(52, 394)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(124, 55)
        Me.BtnLogout.TabIndex = 22
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(55, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 36)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(24, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 36)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Kelola"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(60, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 36)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "KASIR"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(195, 165)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.IdUser)
        Me.Panel2.Controls.Add(Me.tumbal)
        Me.Panel2.Controls.Add(Me.waktu)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.WaktuTransaksi)
        Me.Panel2.Controls.Add(Me.TxbNamaObat)
        Me.Panel2.Controls.Add(Me.waktusekarang)
        Me.Panel2.Controls.Add(Me.BtnPrintSave)
        Me.Panel2.Controls.Add(Me.TxbBayar)
        Me.Panel2.Controls.Add(Me.BtnKosong)
        Me.Panel2.Controls.Add(Me.BtnTambah)
        Me.Panel2.Controls.Add(Me.TxbJumlah)
        Me.Panel2.Controls.Add(Me.TxbHarga)
        Me.Panel2.Controls.Add(Me.CbxNamaObat)
        Me.Panel2.Controls.Add(Me.TxbNamaDokter)
        Me.Panel2.Controls.Add(Me.TxbNamaPasien)
        Me.Panel2.Controls.Add(Me.dtpTanggalResep)
        Me.Panel2.Controls.Add(Me.TxbNoResep)
        Me.Panel2.Controls.Add(Me.Kembalian)
        Me.Panel2.Controls.Add(Me.TotalHarga)
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TipeResep)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(260, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 494)
        Me.Panel2.TabIndex = 21
        '
        'TxbNamaDokter
        '
        Me.TxbNamaDokter.Location = New System.Drawing.Point(326, 73)
        Me.TxbNamaDokter.Name = "TxbNamaDokter"
        Me.TxbNamaDokter.Size = New System.Drawing.Size(222, 20)
        Me.TxbNamaDokter.TabIndex = 82
        '
        'TxbNamaPasien
        '
        Me.TxbNamaPasien.Location = New System.Drawing.Point(44, 211)
        Me.TxbNamaPasien.Name = "TxbNamaPasien"
        Me.TxbNamaPasien.Size = New System.Drawing.Size(222, 20)
        Me.TxbNamaPasien.TabIndex = 81
        '
        'dtpTanggalResep
        '
        Me.dtpTanggalResep.Location = New System.Drawing.Point(44, 165)
        Me.dtpTanggalResep.Name = "dtpTanggalResep"
        Me.dtpTanggalResep.Size = New System.Drawing.Size(222, 20)
        Me.dtpTanggalResep.TabIndex = 80
        '
        'TxbNoResep
        '
        Me.TxbNoResep.Location = New System.Drawing.Point(44, 121)
        Me.TxbNoResep.Name = "TxbNoResep"
        Me.TxbNoResep.Size = New System.Drawing.Size(222, 20)
        Me.TxbNoResep.TabIndex = 79
        '
        'Kembalian
        '
        Me.Kembalian.AutoSize = True
        Me.Kembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kembalian.Location = New System.Drawing.Point(248, 441)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.Size = New System.Drawing.Size(108, 24)
        Me.Kembalian.TabIndex = 78
        Me.Kembalian.Text = "Kembalian"
        '
        'TotalHarga
        '
        Me.TotalHarga.AutoSize = True
        Me.TotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalHarga.Location = New System.Drawing.Point(108, 424)
        Me.TotalHarga.Name = "TotalHarga"
        Me.TotalHarga.Size = New System.Drawing.Size(56, 24)
        Me.TotalHarga.TabIndex = 77
        Me.TotalHarga.Text = "Total"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 269)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(570, 137)
        Me.DGV.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label13.Location = New System.Drawing.Point(322, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 20)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Quantity"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label12.Location = New System.Drawing.Point(40, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 20)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Nama Pasien"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(288, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(16, 215)
        Me.Panel3.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(322, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Harga"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(322, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Nama Obat"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(322, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nama Dokter"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label9.Location = New System.Drawing.Point(43, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Tanggal Resep"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label10.Location = New System.Drawing.Point(40, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "No. Resep"
        '
        'TipeResep
        '
        Me.TipeResep.FormattingEnabled = True
        Me.TipeResep.Items.AddRange(New Object() {"Resep", "Non-Resep"})
        Me.TipeResep.Location = New System.Drawing.Point(44, 72)
        Me.TipeResep.Name = "TipeResep"
        Me.TipeResep.Size = New System.Drawing.Size(222, 21)
        Me.TipeResep.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label11.Location = New System.Drawing.Point(40, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Type Resep"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Form Transaksi"
        '
        'FKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApotekLoremIpsum.My.Resources.Resources._93368
        Me.ClientSize = New System.Drawing.Size(867, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FKasir"
        Me.Text = "Kasir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IdUser As TextBox
    Friend WithEvents tumbal As TextBox
    Friend WithEvents waktu As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents WaktuTransaksi As Label
    Friend WithEvents TxbNamaObat As TextBox
    Friend WithEvents waktusekarang As DateTimePicker
    Friend WithEvents BtnPrintSave As Button
    Friend WithEvents TxbBayar As TextBox
    Friend WithEvents BtnKosong As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxbJumlah As TextBox
    Friend WithEvents TxbHarga As TextBox
    Friend WithEvents CbxNamaObat As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxbNamaDokter As TextBox
    Friend WithEvents TxbNamaPasien As TextBox
    Friend WithEvents dtpTanggalResep As DateTimePicker
    Friend WithEvents TxbNoResep As TextBox
    Friend WithEvents Kembalian As Label
    Friend WithEvents TotalHarga As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TipeResep As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
End Class
