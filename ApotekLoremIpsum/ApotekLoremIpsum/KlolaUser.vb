Imports MySql.Data.MySqlClient
Public Class Fklolauser
    Sub tampilData()
        Call Koneksi()
        DA = New MySqlDataAdapter("select * from tbl_users", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_users")
        DGV.DataSource = DS.Tables("tbl_users")
    End Sub

    Sub degeve()
        DGV.Columns(0).HeaderText = "ID"
        DGV.Columns(1).HeaderText = "Tipe"
        DGV.Columns(2).HeaderText = "Nama"
        DGV.Columns(3).HeaderText = "Alamat"
        DGV.Columns(4).HeaderText = "Telepon"
        DGV.Columns(5).HeaderText = "Username"
        DGV.Columns(6).HeaderText = "Password"
    End Sub

    Sub tambahuser()        Try
            Call Koneksi()            Dim str As String
            str = "INSERT INTO tbl_users(Tipe_User, Nama_User, Alamat, Telepon, Username, Password) VALUES                   ('" & TipeUser.Text & "','" & TxbNama.Text & "','" & TxbAlamat.Text & "','" & TxbNotlp.Text & "',                    '" & TxbUsn.Text & "','" & TxbPw.Text & "')"            CMD = New MySqlCommand(str, CONN)            CMD.ExecuteNonQuery()            MessageBox.Show("Insert Data User Berhasil Dilakukan.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception            MessageBox.Show("Insert Data User Gagal Dilakukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)        End Try
    End Sub

    Sub updateuser()        Try            Call Koneksi()
            Dim str As String
            str = "UPDATE tbl_users SET Tipe_User = '" & TipeUser.Text & "', Nama_User = '" & TxbNama.Text & "',
                   Alamat = '" & TxbAlamat.Text & "', Telepon = '" & TxbNotlp.Text & "', Username = '" & TxbUsn.Text & "',
                   Password = '" & TxbPw.Text & "' WHERE Id_User = '" & tumbal.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()            MessageBox.Show("Update Data User Berhasil Dilakukan.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)        Catch ex As Exception            MessageBox.Show("Update Data User Gagal Dilakukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)        End Try
    End Sub

    Sub hapususer()        Try            Call Koneksi()            Dim str As String            str = "DELETE from tbl_users WHERE Id_User = '" & tumbal.Text & "'"
            CMD = New MySqlCommand(str, CONN)            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)        Catch ex As Exception
            MessageBox.Show("Data User Gagal Dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)        End Try    End Sub

    Private Sub BtnKelolaObat_Click(sender As Object, e As EventArgs) Handles BtnKelolaObat.Click
        FKlolaObat.Show()
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

    Private Sub Btntambah_Click(sender As Object, e As EventArgs) Handles Btntambah.Click
        If TipeUser.Text = "" Or TxbNama.Text = "" Or TxbAlamat.Text = "" Or TxbNotlp.Text = "" Or TxbUsn.Text = "" Or TxbPw.Text = "" Then
            MessageBox.Show("Isi Semua Data Terlebih Dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call tambahuser()
            Call tampilData()
            Call degeve()
            TipeUser.Text = ""
            TxbNama.Clear()
            TxbAlamat.Clear()
            TxbNotlp.Clear()
            TxbUsn.Clear()
            TxbPw.Clear()
            TxbSearch.Clear()
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If TipeUser.Text = "" Or TxbNama.Text = "" Or TxbAlamat.Text = "" Or TxbNotlp.Text = "" Or TxbUsn.Text = "" Or TxbPw.Text = "" Then
            MessageBox.Show("Isi Semua Data Terlebih Dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call updateuser()
            Call tampilData()
            Call degeve()
            TipeUser.Text = ""
            TxbNama.Clear()
            TxbAlamat.Clear()
            TxbNotlp.Clear()
            TxbUsn.Clear()
            TxbPw.Clear()
            TxbSearch.Clear()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin Hapus Akun ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            If TipeUser.Text = "" Or TxbNama.Text = "" Or TxbAlamat.Text = "" Or TxbNotlp.Text = "" Or TxbUsn.Text = "" Or TxbPw.Text = "" Then
                MessageBox.Show("Isi Semua Data Terlebih Dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Call hapususer()
                Call tampilData()
                Call degeve()
                TipeUser.Text = ""
                TxbNama.Clear()
                TxbAlamat.Clear()
                TxbNotlp.Clear()
                TxbUsn.Clear()
                TxbPw.Clear()
                TxbSearch.Clear()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TipeUser.Text = ""
        TxbNama.Clear()
        TxbAlamat.Clear()
        TxbNotlp.Clear()
        TxbUsn.Clear()
        TxbPw.Clear()
        TxbSearch.Clear()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        tumbal.Text = DGV.Item(0, i).Value
        TipeUser.Text = DGV.Item(1, i).Value        TxbNama.Text = DGV.Item(2, i).Value        TxbAlamat.Text = DGV.Item(3, i).Value        TxbNotlp.Text = DGV.Item(4, i).Value        TxbUsn.Text = DGV.Item(5, i).Value        TxbPw.Text = DGV.Item(6, i).Value
    End Sub

    Private Sub Fklolauser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Call degeve()
    End Sub

    Private Sub TxbSearch_TextChanged(sender As Object, e As EventArgs) Handles TxbSearch.TextChanged
        Try
            Call Koneksi()
            DA = New MySqlDataAdapter("SELECT * FROM tbl_users WHERE Nama_User like '%" & TxbSearch.Text & "%'", CONN)
            DS = New Data.DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxbNotlp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbNotlp.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
