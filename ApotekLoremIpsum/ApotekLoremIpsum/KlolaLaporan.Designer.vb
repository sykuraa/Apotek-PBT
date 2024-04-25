<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKelolaLaporan
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FKelolaLaporan))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnKelolaLaporan = New System.Windows.Forms.Button()
        Me.BtnKelolaObat = New System.Windows.Forms.Button()
        Me.BtnKelolaUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.Chart1)
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Controls.Add(Me.BtnGenerate)
        Me.Panel2.Controls.Add(Me.BtnLoad)
        Me.Panel2.Controls.Add(Me.dtp2)
        Me.Panel2.Controls.Add(Me.dtp1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(260, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 494)
        Me.Panel2.TabIndex = 15
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(39, 296)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(395, 163)
        Me.Chart1.TabIndex = 30
        Me.Chart1.Text = "Chart1"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(16, 122)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(570, 137)
        Me.DGV.TabIndex = 29
        '
        'BtnGenerate
        '
        Me.BtnGenerate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnGenerate.Location = New System.Drawing.Point(467, 336)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(73, 33)
        Me.BtnGenerate.TabIndex = 28
        Me.BtnGenerate.Text = "Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = False
        '
        'BtnLoad
        '
        Me.BtnLoad.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLoad.Location = New System.Drawing.Point(501, 78)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(73, 33)
        Me.BtnLoad.TabIndex = 27
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = False
        '
        'dtp2
        '
        Me.dtp2.Location = New System.Drawing.Point(364, 84)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(119, 20)
        Me.dtp2.TabIndex = 26
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(126, 84)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(119, 20)
        Me.dtp1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Sampai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Dari Tanggal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Kelola Laporan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Penjualan"
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
        Me.Panel1.TabIndex = 29
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
        Me.BtnKelolaLaporan.Visible = False
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
        'FKelolaLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApotekLoremIpsum.My.Resources.Resources._93368
        Me.ClientSize = New System.Drawing.Size(867, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FKelolaLaporan"
        Me.Text = "Kelola Laporan"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents BtnLoad As Button
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnKelolaLaporan As Button
    Friend WithEvents BtnKelolaObat As Button
    Friend WithEvents BtnKelolaUser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
