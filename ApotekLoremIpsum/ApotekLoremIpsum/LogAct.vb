Imports MySql.Data.MySqlClient
Public Class FAdminNav
    Sub tampilData()
        Call Koneksi()
        DA = New MySqlDataAdapter("SELECT Id_log, Waktu, Aktifitas, Username, Tipe_User FROM tbl_log INNER JOIN tbl_users
        on tbl_log.Id_User = tbl_users.Id_User order by Id_Log", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_log")
        DGV.DataSource = DS.Tables("tbl_log")
    End Sub

    Sub tambahadmin()
        Try
            Call Koneksi()
            Dim datenow As DateTime = DateTime.Now
            Dim str As String
            str = ("INSERT INTO tbl_log (Waktu, Aktifitas, Id_User) VALUES ('" & datenow.ToString("yyyy/MM/dd HH:mm:ss") & "',
            'Login', (SELECT Id_User FROM tbl_users WHERE Username = '" & FLogin.Usn.Text & "'))")
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            'loading
        End Try
    End Sub

    Sub degeve()
        DGV.Columns(0).HeaderText = "Id Log"
        DGV.Columns(1).HeaderText = "Waktu"
        DGV.Columns(2).HeaderText = "Aktifitas"
        DGV.Columns(3).HeaderText = "Username"
        DGV.Columns(4).HeaderText = "Tipe User"
    End Sub

    Private Sub FAdminNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call tambahadmin()
        Call tampilData()
        Call degeve()
    End Sub

    Private Sub BtnKelolaUser_Click(sender As Object, e As EventArgs) Handles BtnKelolaUser.Click
        Fklolauser.Show()
        Me.Close()
    End Sub

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

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        Try
            Call Koneksi()
            DA = New MySqlDataAdapter("SELECT Id_log, Waktu, Aktifitas, Username FROM tbl_log INNER JOIN
            tbl_users on tbl_log.Id_User = tbl_users.Id_User WHERE Waktu like '%" & waktu.Value.ToString("yyyy-MM-dd") & "%'", CONN)
            DS = New Data.DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Catch ex As Exception
        End Try
    End Sub
End Class