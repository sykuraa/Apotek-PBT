Imports MySql.Data.MySqlClient
Public Class FKelolaLaporan
    Sub tampilData()
        Call Koneksi()
        DA = New MySqlDataAdapter("SELECT * FROM tbl_transaksi", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_transaksi")
        DGV.DataSource = DS.Tables("tbl_transaksi")
    End Sub

    Private Sub FKelolaLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()

    End Sub

    Private Sub BtnKelolaUser_Click(sender As Object, e As EventArgs) Handles BtnKelolaUser.Click
        Fklolauser.Show()
        Me.Close()
    End Sub

    Private Sub BtnKelolaObat_Click(sender As Object, e As EventArgs) Handles BtnKelolaObat.Click
        FKlolaObat.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        FLogin.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Chart1.Visible = True
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        Call Koneksi()
        CMD = New MySqlCommand("SELECT Tanggal_Bayar, Total_Bayar FROM tbl_transaksi WHERE Tanggal_Bayar BETWEEN '" & dtp1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp2.Value.ToString("yyyy-MM-dd") & "'", CONN)
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet
        DA.Fill(DS)
        If DS.Tables.Count > 0 Then
            DGV.DataSource = DS.Tables(0)
        End If
    End Sub
End Class