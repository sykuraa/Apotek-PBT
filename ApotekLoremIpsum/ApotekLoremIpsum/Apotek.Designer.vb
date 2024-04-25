<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FApotek
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FApotek))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tumbal = New System.Windows.Forms.TextBox()
        Me.TxbSearch = New System.Windows.Forms.TextBox()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxbJumlah = New System.Windows.Forms.TextBox()
        Me.TxbNamaObat = New System.Windows.Forms.TextBox()
        Me.TxbNamaDokter = New System.Windows.Forms.TextBox()
        Me.TxbNamaPasien = New System.Windows.Forms.TextBox()
        Me.dtpTanggalResep = New System.Windows.Forms.DateTimePicker()
        Me.TxbNoResep = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 494)
        Me.Panel1.TabIndex = 16
        '
        'BtnLogout
        '
        Me.BtnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.Location = New System.Drawing.Point(54, 397)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(124, 55)
        Me.BtnLogout.TabIndex = 22
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(108, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 36)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Resep"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
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
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 36)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "APOTEKER"
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
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
        Me.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.tumbal)
        Me.Panel2.Controls.Add(Me.TxbSearch)
        Me.Panel2.Controls.Add(Me.BtnHapus)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnTambah)
        Me.Panel2.Controls.Add(Me.TxbJumlah)
        Me.Panel2.Controls.Add(Me.TxbNamaObat)
        Me.Panel2.Controls.Add(Me.TxbNamaDokter)
        Me.Panel2.Controls.Add(Me.TxbNamaPasien)
        Me.Panel2.Controls.Add(Me.dtpTanggalResep)
        Me.Panel2.Controls.Add(Me.TxbNoResep)
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(260, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 494)
        Me.Panel2.TabIndex = 17
        '
        'tumbal
        '
        Me.tumbal.Location = New System.Drawing.Point(165, 23)
        Me.tumbal.Name = "tumbal"
        Me.tumbal.Size = New System.Drawing.Size(100, 20)
        Me.tumbal.TabIndex = 53
        Me.tumbal.Visible = False
        '
        'TxbSearch
        '
        Me.TxbSearch.Location = New System.Drawing.Point(438, 303)
        Me.TxbSearch.Name = "TxbSearch"
        Me.TxbSearch.Size = New System.Drawing.Size(144, 20)
        Me.TxbSearch.TabIndex = 52
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(279, 303)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(87, 27)
        Me.BtnHapus.TabIndex = 51
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(157, 303)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(87, 27)
        Me.BtnEdit.TabIndex = 50
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(29, 303)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(87, 27)
        Me.BtnTambah.TabIndex = 49
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxbJumlah
        '
        Me.TxbJumlah.Location = New System.Drawing.Point(324, 263)
        Me.TxbJumlah.Name = "TxbJumlah"
        Me.TxbJumlah.Size = New System.Drawing.Size(214, 20)
        Me.TxbJumlah.TabIndex = 48
        '
        'TxbNamaObat
        '
        Me.TxbNamaObat.Location = New System.Drawing.Point(324, 192)
        Me.TxbNamaObat.Name = "TxbNamaObat"
        Me.TxbNamaObat.Size = New System.Drawing.Size(214, 20)
        Me.TxbNamaObat.TabIndex = 47
        '
        'TxbNamaDokter
        '
        Me.TxbNamaDokter.Location = New System.Drawing.Point(324, 102)
        Me.TxbNamaDokter.Name = "TxbNamaDokter"
        Me.TxbNamaDokter.Size = New System.Drawing.Size(214, 20)
        Me.TxbNamaDokter.TabIndex = 46
        '
        'TxbNamaPasien
        '
        Me.TxbNamaPasien.Location = New System.Drawing.Point(40, 263)
        Me.TxbNamaPasien.Name = "TxbNamaPasien"
        Me.TxbNamaPasien.Size = New System.Drawing.Size(214, 20)
        Me.TxbNamaPasien.TabIndex = 45
        '
        'dtpTanggalResep
        '
        Me.dtpTanggalResep.Location = New System.Drawing.Point(40, 189)
        Me.dtpTanggalResep.Name = "dtpTanggalResep"
        Me.dtpTanggalResep.Size = New System.Drawing.Size(214, 20)
        Me.dtpTanggalResep.TabIndex = 44
        '
        'TxbNoResep
        '
        Me.TxbNoResep.Location = New System.Drawing.Point(40, 102)
        Me.TxbNoResep.Name = "TxbNoResep"
        Me.TxbNoResep.Size = New System.Drawing.Size(214, 20)
        Me.TxbNoResep.TabIndex = 43
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 336)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(570, 137)
        Me.DGV.TabIndex = 42
        '
        'Panel3
        '
        Me.Panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(279, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(16, 215)
        Me.Panel3.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.Label8.Location = New System.Drawing.Point(389, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 20)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(320, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Quantity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(320, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Nama Obat"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(320, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nama Dokter"
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label9.Location = New System.Drawing.Point(38, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nama Pasien"
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label10.Location = New System.Drawing.Point(36, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Tanggal Resep"
        '
        'Label11
        '
        Me.Label11.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label11.Location = New System.Drawing.Point(38, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "No. Resep"
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Kelola Obat"
        '
        'FApotek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApotekLoremIpsum.My.Resources.Resources._93368
        Me.ClientSize = New System.Drawing.Size(867, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FApotek"
        Me.Text = "Kelola Resep (Apoteker)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TxbNoResep As TextBox
    Friend WithEvents TxbSearch As TextBox
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxbJumlah As TextBox
    Friend WithEvents TxbNamaObat As TextBox
    Friend WithEvents TxbNamaDokter As TextBox
    Friend WithEvents TxbNamaPasien As TextBox
    Friend WithEvents dtpTanggalResep As DateTimePicker
    Friend WithEvents tumbal As TextBox
End Class
