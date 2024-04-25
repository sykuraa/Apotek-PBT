<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAdminNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAdminNav))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.waktu = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Controls.Add(Me.BtnLoad)
        Me.Panel2.Controls.Add(Me.waktu)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(260, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 494)
        Me.Panel2.TabIndex = 9
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(23, 79)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.ShowEditingIcon = False
        Me.DGV.Size = New System.Drawing.Size(552, 349)
        Me.DGV.TabIndex = 5
        '
        'BtnLoad
        '
        Me.BtnLoad.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoad.Location = New System.Drawing.Point(448, 445)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(76, 25)
        Me.BtnLoad.TabIndex = 4
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLoad.UseVisualStyleBackColor = False
        '
        'waktu
        '
        Me.waktu.Checked = False
        Me.waktu.Location = New System.Drawing.Point(231, 447)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(201, 20)
        Me.waktu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tampilkan Per"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.Location = New System.Drawing.Point(208, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log Activity"
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
        Me.Panel1.TabIndex = 11
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
        'FAdminNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApotekLoremIpsum.My.Resources.Resources._93368
        Me.ClientSize = New System.Drawing.Size(867, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FAdminNav"
        Me.Text = "Admin Navigation"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnLoad As Button
    Friend WithEvents waktu As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnKelolaLaporan As Button
    Friend WithEvents BtnKelolaObat As Button
    Friend WithEvents BtnKelolaUser As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
