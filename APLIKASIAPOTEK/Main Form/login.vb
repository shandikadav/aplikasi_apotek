Imports System.Data.SqlClient
Public Class login

    Sub bersihkandata()
        txt_uname.Text = ""
        txt_pass.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_uname.Text = "" Or txt_pass.Text = "" Then
            MessageBox.Show("Usernama dan Password belum diisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txt_uname.Focus()
        Else
            konekdb()
            Dim cmd As New SqlCommand("SELECT * FROM akun WHERE Username = '" + txt_uname.Text + "' AND Password = '" + txt_pass.Text + "'", konek)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                If rd.Item(2).ToString = "Pimpinan" Then
                    MessageBox.Show("Login akun Pimpinan berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    pimpinan.Show()
                    Me.Hide()
                ElseIf rd.Item(2).ToString = "Operator" Then
                    MessageBox.Show("Login akun Operator berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    operatormain.Show()
                    Me.Hide()
                ElseIf rd.Item(2).ToString = "Apoteker" Then
                    MessageBox.Show("Login akun Apoteker berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    apoteker.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Username atau Password salah, silahkan coba lagi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bersihkandata()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_pass.PasswordChar = ""
        Else
            txt_pass.PasswordChar = "*"
        End If
    End Sub
End Class