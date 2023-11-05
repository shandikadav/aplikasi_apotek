Imports System.Data.SqlClient
Module Module1
    Public konek As SqlConnection
    Sub konekdb()
        Try
            konek = New SqlConnection("Data Source=DESKTOP-D5OLT2H\SQLEXPRESS;initial catalog=DB_APLIKASIAPOTEKER;integrated security=true")
            konek.Open()
        Catch ex As Exception
            MsgBox("Database tidak terkoneksi", vbExclamation)
        End Try
    End Sub

    Public Sub jalankansql(ByVal sql As String)
        Dim cmd As New SqlCommand
        Try
            konekdb()
            cmd.Connection = konek
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            konek.Close()
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try
    End Sub

End Module