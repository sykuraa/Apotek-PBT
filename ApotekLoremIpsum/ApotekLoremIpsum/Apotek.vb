Imports MySql.Data.MySqlClient
Public Class FApotek

    Sub tampilData()
        Call Koneksi()
        DA = New MySqlDataAdapter("select * from tbl_resep", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_resep")
        DGV.DataSource = DS.Tables("tbl_resep")
    End Sub

    Sub degeve()
        DGV.Columns(0).HeaderText = "ID"
        DGV.Columns(1).HeaderText = "No. Resep"
        DGV.Columns(2).HeaderText = "Tanggal"
        DGV.Columns(3).HeaderText = "Nama Dokter"
        DGV.Columns(4).HeaderText = "Nama Pasien"
        DGV.Columns(5).HeaderText = "Nama Obat"
        DGV.Columns(6).HeaderText = "Jumlah Obat"
    End Sub

    Sub tambahobatresep()
        Try
            Call Koneksi()            Dim str As String
            str = "INSERT INTO tbl_resep(No_Resep, Tanggal_Resep, Nama_Dokter, Nama_Pasien, Nama_ObatDibeli, Jumlah_ObatDibeli) VALUES                   ('" & TxbNoResep.Text & "','" & dtpTanggalResep.Value.ToString("yyyy-MM-dd") & "','" & TxbNamaDokter.Text & "','" & TxbNamaPasien.Text & "',                    '" & TxbNamaObat.Text & "','" & TxbJumlah.Text & "')"            CMD = New MySqlCommand(str, CONN)            CMD.ExecuteNonQuery()            MessageBox.Show("Insert Obat Resep Berhasil Dilakukan.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception            MessageBox.Show("Insert Obat Resep Gagal Dilakukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)        End Try
    End Sub

    Sub updateobatresep()
        Try            Call Koneksi()
            Dim str As String            str = "UPDATE tbl_resep SET No_Resep = '" & TxbNoResep.Text & "', Tanggal_Resep = '" & dtpTanggalResep.Value.ToString("yyyy-MM-dd") & "',
            Nama_Dokter = '" & TxbNamaDokter.Text & "', Nama_Pasien = '" & TxbNamaPasien.Text & "', Nama_ObatDibeli = '" & TxbNamaObat.Text & "',
            Jumlah_ObatDibeli = '" & TxbJumlah.Text & "' WHERE Id_Resep = '" & tumbal.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Obat Resep Berhasil Dilakukan.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)        Catch ex As Exception            MessageBox.Show("Update Obat Resep Gagal Dilakukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)        End Try
    End Sub

    Sub deleteobatresep()
        Try            Call Koneksi()            Dim str As String            str = "DELETE from tbl_resep WHERE Id_Resep = '" & tumbal.Text & "'"            CMD = New MySqlCommand(str, CONN)            CMD.ExecuteNonQuery()            MessageBox.Show("Data Obat Berhasil Dihapus.")        Catch ex As Exception            MessageBox.Show("Data obat Gagal Dihapus.")        End Try
    End Sub

    Private Sub FApotek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Call degeve()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        FLogin.Show()
        FAdminNav.Close()
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Call tambahobatresep()
        Call tampilData()
        Call degeve()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Call updateobatresep()
        Call tampilData()
        Call degeve()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin Hapus Obat ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            Call deleteobatresep()
            Call tampilData()
            Call degeve()
        End If
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        tumbal.Text = DGV.Item(0, i).Value
        TxbNoResep.Text = DGV.Item(1, i).Value
        dtpTanggalResep.Text = DGV.Item(2, i).Value
        TxbNamaDokter.Text = DGV.Item(3, i).Value
        TxbNamaPasien.Text = DGV.Item(4, i).Value
        TxbNamaObat.Text = DGV.Item(5, i).Value
        TxbJumlah.Text = DGV.Item(6, i).Value
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        tumbal.Clear()
        TxbNoResep.Clear()
        TxbNamaPasien.Clear()
        TxbNamaDokter.Clear()
        TxbNamaObat.Clear()
        TxbJumlah.Clear()
    End Sub

    Private Sub TxbNoResep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbNoResep.KeyPress
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

    Private Sub TxbSearch_TextChanged(sender As Object, e As EventArgs) Handles TxbSearch.TextChanged
        Try
            Call Koneksi()
            DA = New MySqlDataAdapter("SELECT * from tbl_resep WHERE Nama_ObatDibeli LIKE '%" & TxbSearch.Text & "%'", CONN)
            DS = New Data.DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Catch ex As Exception
        End Try
    End Sub
End Class