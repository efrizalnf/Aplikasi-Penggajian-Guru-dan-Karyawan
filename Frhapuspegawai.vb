Imports System.Data.SqlClient
Imports System.Data
Public Class Frhapuspegawai
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader


    Private Sub Frhapuspegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        masuk_nip()
    End Sub


    Sub hapus()
        Dim ubah As String
        Try


            ubah = "delete from jenjang_NIP where nip = '" + ComboBox2.Text + "'"
            Dim command As New SqlClient.SqlCommand(ubah, conn)
            command.ExecuteNonQuery()
            'MsgBox("Data Berhasil Dihapus")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try


            ubah = "delete from Tkehadiran where nip = '" + ComboBox2.Text + "'"
            Dim command As New SqlClient.SqlCommand(ubah, conn)
            command.ExecuteNonQuery()
            'MsgBox("Data Berhasil Dihapus")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try


            ubah = "delete from Tpenggajian where nip = '" + ComboBox2.Text + "'"
            Dim command As New SqlClient.SqlCommand(ubah, conn)
            command.ExecuteNonQuery()
            'MsgBox("Data Berhasil Dihapus")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try


            ubah = "delete from Tpegawai where nip = '" + ComboBox2.Text + "'"
            Dim command As New SqlClient.SqlCommand(ubah, conn)
            command.ExecuteNonQuery()
            'MsgBox("Data Berhasil Dihapus")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try

            ubah = "delete from Tpegawai where nip = '" + ComboBox2.Text + "'"
            Dim command As New SqlClient.SqlCommand(ubah, conn)
            command.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        frPegawai.ref()
    End Sub


    Public Sub masuk_nip()
        cmd = New SqlCommand("select nip from tpegawai", conn)
        reader = cmd.ExecuteReader
        Try

            While reader.Read
                ComboBox2.Items.Add(reader.Item(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        cmd.Dispose()
        reader.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hapus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class