Imports System.Data.SqlClient
Public Class manajemenakun

    Sub bersihkandata()
        txt_uname.Text = ""
        txt_pass.Text = ""
        txt_role.Text = ""
    End Sub

    Sub tampilkandata()
        konekdb()
        Dim da As New SqlDataAdapter("SELECT * FROM akun", konek)
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "akun")
        DataGridView1.DataSource = ds.Tables("akun")
    End Sub

    Private Sub manajemenakun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkandata()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim pesan, sql As String
        If txt_uname.Text = "" Or txt_pass.Text = "" Or txt_role.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_uname.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = vbNo Then
                Exit Sub
            End If
            sql = "INSERT INTO akun VALUES ('" + txt_uname.Text + "','" + txt_pass.Text + "','" + txt_role.Text + "')"
            jalankansql(sql)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkandata()
            bersihkandata()
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim pesan, sql As String
        If txt_uname.Text = "" Or txt_pass.Text = "" Or txt_role.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_uname.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = vbNo Then
                Exit Sub
            End If
            sql = "UPDATE akun SET Password = '" + txt_pass.Text + "', LevelAkun = '" + txt_role.Text + "' WHERE Username = '" + txt_uname.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkandata()
            bersihkandata()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim pesan, sql As String
        If txt_uname.Text = "" Or txt_pass.Text = "" Or txt_role.Text = "" Then
            MessageBox.Show("Data belum lengkap!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_uname.Focus()
        Else
            pesan = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If pesan = vbNo Then
                Exit Sub
            End If
            sql = "DELETE FROM akun WHERE Username LIKE '" + txt_uname.Text + "'"
            jalankansql(sql)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkandata()
            bersihkandata()
        End If
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        konekdb()
        Dim cmd As New SqlCommand("SELECT * FROM akun WHERE Username = '" + txt_uname.Text + "'", konek)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_uname.Text = rd.Item(0)
            txt_pass.Text = rd.Item(1)
            txt_role.Text = rd.Item(2)
        End If
    End Sub
End Class