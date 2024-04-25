Imports MySql.Data.MySqlClient
Public Class FKlolaObat

    Sub tampilData()
        Call Koneksi()
        DA = New MySqlDataAdapter("select * from tbl_obat", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_obat")
        DGV.DataSource = DS.Tables("tbl_obat")
    End Sub

    Sub degeve()
        DGV.Columns(0).HeaderText = "ID"
        DGV.Columns(1).HeaderText = "Kode Obat"
        DGV.Columns(2).HeaderText = "Nama Obat"
        DGV.Columns(3).HeaderText = "Tanggal EXP"
        DGV.Columns(4).HeaderText = "Jumlah"
        DGV.Columns(5).HeaderText = "Harga"
    End Sub

    Sub tambahobat()        Try            Call Koneksi()            Dim str As String
            str = "INSERT INTO tbl_obat (Kode_Obat, Nama_Date, Expired_Date, Jumlah, Harga) VALUES            ('" & TxbKodeObt.Text & "','" & TxbNamaObt.Text & "','" & dtp.Value.ToString("yyyy-MM-dd") & "',            '" & TxbJumlah.Text & "','" & TxbHarga.Text & "')"            CMD = New MySqlCommand(str, CONN)            CMD.ExecuteReader()            MessageBox.Show("Insert Obat Berhasil Dilakukan")
        Catch ex As Exception            MessageBox.Show("Insert Obat gagal dilakukan.")        End Try
        Call tampilData()
        Call degeve()
    End Sub

    Sub updateobat()
        Try            Call Koneksi()
            Dim str As String
            str = "UPDATE tbl_obat SET Kode_Obat = '" & TxbKodeObt.Text & "', Nama_Date = '" & TxbNamaObt.Text & "',
                   Jumlah = '" & TxbJumlah.Text & "', Harga = '" & TxbHarga.Text & "' WHERE Id_Obat = '" & tumbal.Text & "' "
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()            MessageBox.Show("Update Data User Berhasil Dilakukan.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)        Catch ex As Exception            MessageBox.Show("Update Data User Gagal Dilakukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)        End Try
        Call tampilData()
        Call degeve()
    End Sub

    Sub hapusobat()        Try            Call Koneksi()            Dim str As String            str = "DELETE from tbl_obat WHERE Id_Obat = '" & tumbal.Text & "'"            CMD = New MySqlCommand(str, CONN)            CMD.ExecuteNonQuery()            MessageBox.Show("Data obat Berhasil Dihapus.")        Catch ex As Exception            MessageBox.Show("Data obat Gagal Dihapus.")        End Try
        Call tampilData()
        Call degeve()        TxbKodeObt.Clear()    End Sub
    Private Sub FKlolaObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Call degeve()
    End Sub

    Private Sub BtnKelolaUser_Click(sender As Object, e As EventArgs) Handles BtnKelolaUser.Click
        Fklolauser.Show()
        Me.Close()
    End Sub

    Private Sub BtnKelolaLaporan_Click(sender As Object, e As EventArgs) Handles BtnKelolaLaporan.Click
        FKelolaLaporan.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        FLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If TxbKodeObt.Text = "" Or TxbNamaObt.Text = "" Or TxbJumlah.Text = "" Or TxbHarga.Text = "" Then
            MessageBox.Show("Isi Semua Data Terlebih Dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call tambahobat()
            TxbKodeObt.Clear()
            TxbNamaObt.Clear()
            TxbJumlah.Clear()
            TxbHarga.Clear()
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Call updateobat()
        TxbKodeObt.Clear()
        TxbNamaObt.Clear()
        TxbJumlah.Clear()
        TxbHarga.Clear()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Call hapusobat()
        TxbKodeObt.Clear()
        TxbNamaObt.Clear()
        TxbJumlah.Clear()
        TxbHarga.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TxbKodeObt.Clear()
        TxbNamaObt.Clear()
        TxbJumlah.Clear()
        TxbHarga.Clear()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        tumbal.Text = DGV.Item(0, i).Value
        TxbKodeObt.Text = DGV.Item(1, i).Value
        TxbNamaObt.Text = DGV.Item(2, i).Value
        dtp.Text = DGV.Item(3, i).Value
        TxbJumlah.Text = DGV.Item(4, i).Value
        TxbHarga.Text = DGV.Item(5, i).Value
    End Sub

    Private Sub TxbSearch_TextChanged(sender As Object, e As EventArgs) Handles TxbSearch.TextChanged
        Try
            Call Koneksi()
            DA = New MySqlDataAdapter("SELECT * from tbl_obat WHERE Nama_Date like '%" & TxbSearch.Text & "%'", CONN)
            DS = New Data.DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxbJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbJumlah.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxbHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbHarga.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class