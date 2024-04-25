Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FKasir
    Sub tampilData()
        Call Koneksi()
        DA = New MySqlDataAdapter("SELECT Id_Transaksi, No_Transaksi, Tanggal_Bayar, Total_Bayar, Nama_User, Nama_Date, No_Resep FROM tbl_transaksi 
        LEFT JOIN tbl_users ON tbl_transaksi.Id_User =  tbl_users.Id_User
        LEFT JOIN tbl_resep ON tbl_transaksi.Id_Resep =  tbl_resep.Id_Resep
        LEFT JOIN tbl_obat ON tbl_transaksi.Id_Obat =  tbl_obat.Id_Obat", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_transaksi")
        DGV.DataSource = DS.Tables("tbl_transaksi")
    End Sub

    ' FITUR AUTOMATISASI
    Sub nonresep()
        Try
            Call Koneksi()
            Dim selectedItem As String = CbxNamaObat.Text

            Dim query As String = "SELECT Harga, Expired_Date FROM tbl_obat WHERE Nama_Date = @nama_obat"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@nama_obat", selectedItem)
            RD = CMD.ExecuteReader()

            If RD.Read() Then
                Dim harga As Double = Convert.ToDouble(RD("Harga"))
                Dim waktu As String = Convert.ToString(RD("Expired_Date"))
                TxbHarga.Text = harga.ToString()
                dtpTanggalResep.Text = waktu.ToString()
            Else
                MessageBox.Show("Harga tidak ditemukan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            RD.Close()
            CONN.Close()
        End Try
    End Sub
    Sub resep()
        Try
            Call Koneksi()
            Dim selectedItem As String = TxbNoResep.Text

            Dim query As String = "SELECT Tanggal_Resep, Nama_Dokter, Nama_Pasien, Nama_obatDIbeli FROM tbl_resep WHERE No_Resep = @noresep"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@noresep", selectedItem)
            RD = CMD.ExecuteReader()

            If RD.Read() Then
                Dim waktu As String = Convert.ToString(RD("Tanggal_Resep"))
                Dim dokter As String = Convert.ToString(RD("Nama_Dokter"))
                Dim pasien As String = Convert.ToString(RD("Nama_Pasien"))
                Dim obat As String = Convert.ToString(RD("Nama_ObatDibeli"))

                dtpTanggalResep.Text = waktu.ToString()
                TxbNamaDokter.Text = dokter.ToString()
                TxbNamaPasien.Text = pasien.ToString()
                TxbNamaObat.Text = obat.ToString()
            End If
        Catch ex As Exception
            'Error Handling
        Finally
            RD.Close()
            CONN.Close()
        End Try
    End Sub
    Dim kode As String
    Sub kodetrsk()
        Call Koneksi()
        CMD = New MySqlCommand("SELECT * FROM tbl_transaksi ORDER BY No_Transaksi DESC", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim lastTransaction As Integer = Integer.Parse(RD.Item("No_Transaksi").ToString().Substring(4))
            Dim nextTransaction As Integer = lastTransaction + 1
            kode = "Trsk" & nextTransaction.ToString("000")
        Else
            kode = "Trsk001"
        End If
        CONN.Close()
    End Sub


    Sub tambahtransaksi()
        Try
            kodetrsk()
            Call Koneksi()
            Dim datenow As DateTime = DateTime.Now
            Dim str As String
            str = "INSERT INTO tbl_transaksi (No_Transaksi, Tanggal_Bayar, Total_Bayar, Id_User, Id_Obat, Id_Resep)
                   VALUES ('" & kode & "', '" & datenow.ToString("yyyy/MM/dd HH:mm:ss") & "', '" & TotalHarga.Text & "', '" & IdUser.Text & "',
                  (SELECT Id_Obat FROM tbl_obat WHERE Nama_Date = '" & CbxNamaObat.Text & "'), (SELECT Id_Resep FROM tbl_resep WHERE No_Resep = '" & TxbNoResep.Text & "'))"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data User Berhasil Dilakukan.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub hapustransaksi()
        Try            Call Koneksi()            Dim str As String            str = "DELETE from tbl_transaksi WHERE Id_Transaksi = '" & tumbal.Text & "'"
            CMD = New MySqlCommand(str, CONN)            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)        Catch ex As Exception
            MessageBox.Show("Data User Gagal Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)        End Try
    End Sub
    Sub updatejumlah()        Dim nkurang As Integer = Convert.ToInt32(TxbJumlah.Text)        Try            Call Koneksi()
            Dim str As String
            str = "UPDATE tbl_obat SET Jumlah = Jumlah - '" & nkurang & "' WHERE Nama_Date = '" & CbxNamaObat.Text & ""
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()            MessageBox.Show("Update Data User Berhasil Dilakukan.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)        Catch ex As Exception            MessageBox.Show(ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)        End Try
    End Sub

    ' FUNCTION OF AUTO GET ID FROM FLOGIN
    Private Function GetUserIdByUsername(username As String) As String
        ' Implementasikan fungsi ini untuk mendapatkan ID dari username
        ' Misalnya, Anda bisa menggunakan kueri SQL seperti yang sebelumnya dibahas
        ' atau menggunakan metode lain sesuai dengan struktur aplikasi Anda
        ' dan pastikan untuk mengembalikan ID dalam bentuk String
        Dim userId As String = ""

        ' Contoh pengambilan ID dari database
        Try
            Call Koneksi()
            Dim query As String = "SELECT Id_User FROM tbl_users WHERE Username = '" & username & "'"
            CMD = New MySqlCommand(query, CONN)
            userId = CMD.ExecuteScalar().ToString()
        Catch ex As Exception
            ' Tangani kesalahan jika terjadi
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Tutup koneksi setelah digunakan
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try

        ' Kembalikan nilai ID
        Return userId
    End Function

    Private Sub FKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cek apakah TextBoxUsernameLogin memiliki nilai
        If Not String.IsNullOrEmpty(FLogin.Usn.Text) Then
            ' Panggil fungsi untuk mendapatkan ID berdasarkan username
            Dim userId As String = GetUserIdByUsername(FLogin.Usn.Text)

            ' Isi TextBox1.Text dengan ID yang ditemukan
            IdUser.Text = userId
        End If
        Call tampilData()
    End Sub

    Private Sub TipeResep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipeResep.SelectedIndexChanged
        If TipeResep.Text = "Non-Resep" Then
            TxbNoResep.Clear()
            dtpTanggalResep.Value = DateTime.Now
            TxbNamaPasien.Clear()
            TxbNamaDokter.Clear()
            TxbHarga.Clear()
            TxbJumlah.Clear()
            TxbNamaObat.Hide()
            CbxNamaObat.Show()
            TxbNoResep.Text = "-"
            TxbNamaPasien.Text = "-"
            TxbNamaDokter.Text = "-"
        Else
            TxbNoResep.Clear()
            dtpTanggalResep.Value = DateTime.Now
            TxbNamaPasien.Clear()
            TxbNamaDokter.Clear()
            TxbHarga.Clear()
            TxbJumlah.Clear()
            CbxNamaObat.Hide()
            TxbNamaObat.Show()
        End If

    End Sub

    ' VALIDASI NUMERIK
    Private Sub TxbHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbHarga.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TxbJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbJumlah.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxbNoResep_TextChanged(sender As Object, e As EventArgs) Handles TxbNoResep.TextChanged
        If TxbNoResep.Text = "" Then
            dtpTanggalResep.Value = DateTime.Now
            TxbNamaPasien.Clear()
            TxbNamaDokter.Clear()
            TxbNamaObat.Clear()
            TxbHarga.Clear()
            TxbJumlah.Clear()
        Else
            Call resep()
        End If
    End Sub

    Private Sub CbxNamaObat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxNamaObat.SelectedIndexChanged
        Call nonresep()
    End Sub

    ' FITUR OPERATOR
    Private Sub TxbJumlah_TextChanged(sender As Object, e As EventArgs) Handles TxbJumlah.TextChanged
        Dim harga, Jumlah, Total As Double

        If Double.TryParse(TxbHarga.Text, harga) AndAlso Double.TryParse(TxbJumlah.Text, Jumlah) Then
            Total = harga * Jumlah
            TotalHarga.Text = Total.ToString()
        End If
        If TxbJumlah.Text = "" Then
            TotalHarga.Text = "Total"
        End If
    End Sub
    Private Sub TxbBayar_TextChanged(sender As Object, e As EventArgs) Handles TxbBayar.TextChanged
        Dim Total, Bayar, Kembali As Double
        If Double.TryParse(TotalHarga.Text, Total) AndAlso Double.TryParse(TxbBayar.Text, Bayar) Then
            Kembali = Bayar - Total
            Kembalian.Text = Kembali.ToString()
        End If
        If TxbBayar.Text = "" Then
            Kembalian.Text = "Kembali"
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Call updatejumlah()
        Call tambahtransaksi()
        Call tampilData()
    End Sub

    Private Sub BtnKosong_Click(sender As Object, e As EventArgs) Handles BtnKosong.Click
        Call hapustransaksi()
        Call tampilData()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        FLogin.Show()
        Me.Close()
        FAdminNav.Close()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        tumbal.Text = DGV.Item(0, i).Value
    End Sub

    ' PRINT & SAVE FUNCTION

    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog

    Private Sub BtnPrintSave_Click(sender As Object, e As EventArgs) Handles BtnPrintSave.Click
        PDD.Document = PD
        PDD.ShowDialog()

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Costum", 250, 500)
        PD.DefaultPageSettings = pagesetup

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim Mkiri As Integer = PD.DefaultPageSettings.Margins.Left
        Dim MTengah As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim Mkanan As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"

        e.Graphics.DrawString("Apotek LOIP", f14, Brushes.Black, MTengah, 5, tengah)
        e.Graphics.DrawString("Jl. Pangkal Perjuangan, Tanjungpura", f10, Brushes.Black, MTengah, 25, tengah)
        e.Graphics.DrawString("Hp : 0000-5555-999", f10, Brushes.Black, MTengah, 40, tengah)

        e.Graphics.DrawString("No Transaksi", f10, Brushes.Black, 0, 70)
        e.Graphics.DrawString(":", f10, Brushes.Black, 80, 70)
        e.Graphics.DrawString("Trsk001", f10, Brushes.Black, 90, 70)

        e.Graphics.DrawString("Kasir", f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f10, Brushes.Black, 80, 90)
        e.Graphics.DrawString("Najam", f10, Brushes.Black, 90, 90)

        e.Graphics.DrawString("Waktu sekarang", f10, Brushes.Black, 0, 110)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 130)

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To DGV.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(TxbJumlah.Text, f10, Brushes.Black, 0, 150)
            e.Graphics.DrawString(TxbNamaObat.Text, f10, Brushes.Black, 25, 150)
            e.Graphics.DrawString(TotalHarga.Text, f10, Brushes.Black, 75, 150)


        Next

    End Sub
End Class