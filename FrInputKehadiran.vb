Imports System.Data.SqlClient

Public Class FrInputKehadiran
    Dim cmd As SqlCommand
    Dim reader As SqlDataReader
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrInputKehadiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        masuk_nip()
    End Sub

    Public Sub masuk_nip()
        Try
            cmd = New SqlCommand("select nip from tpegawai", conn)
            reader = cmd.ExecuteReader
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
        Try
            Dim simpan As String
            simpan = "insert into tkehadiran values ('" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Label14.Text & "')"
            Dim command As New SqlClient.SqlCommand(simpan, conn)
            command.ExecuteNonQuery()
            MsgBox("data berhasil di simpan")
            formlaporankehadiran.ref()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        Try
            cmd = New SqlCommand("select * from tpegawai where nip ='" & ComboBox2.Text & "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                TextBox6.Text = reader.Item(1)
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        reader.Close()
        cmd.Dispose()
    End Sub

    Sub hitung()
        Label14.Text = Val(TextBox2.Text) - (Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text))
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        hitung()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        hitung()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        hitung()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        hitung()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        hitung()
    End Sub


End Class