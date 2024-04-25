Imports MySql.Data.MySqlClient
Public Class FLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If Usn.Text = "" And Pw.Text = "" Then
            MessageBox.Show("Harap isi Username dan Password terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Usn.Text = "" Or Pw.Text = "" Then
            MessageBox.Show("Harap lengkapi data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Call Koneksi()
                CMD = New MySqlCommand("SELECT * FROM tbl_users WHERE Username = @usn AND Password = @pw", CONN)
                CMD.Parameters.AddWithValue("@usn", Usn.Text)
                CMD.Parameters.AddWithValue("@pw", Pw.Text)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then

                    If RD("Tipe_User").ToString = "admin" Then
                        'Login sebagai Admin
                        FAdminNav.Show()
                        Usn.Clear()
                        Pw.Clear()
                        Me.Hide()
                    ElseIf RD("Tipe_User").ToString = "kasir" Then
                        'Login sebagai Kasir
                        FKasir.Show()
                        Usn.Clear()
                        Pw.Clear()
                        Me.Hide()
                    ElseIf RD("Tipe_User").ToString = "apoteker" Then
                        'Login sebagai Apoteker
                        FApotek.Show()
                        Usn.Clear()
                        Pw.Clear()
                        Me.Hide()
                    Else
                        MessageBox.Show("Role tidak tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Periksa kembali Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Usn.Focus()
                    Pw.Clear()
                End If

                RD.Close()
            Catch ex As Exception
                MessageBox.Show("Periksa", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Usn.Focus()
                Pw.Clear()
            End Try
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Usn.Clear()
        Pw.Clear()
    End Sub
End Class
