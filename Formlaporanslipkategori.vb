Imports System.Data.SqlClient
Public Class Formlaporanslipkategori

    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim a As String

    Private Sub Formlaporanslipkategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        masuk_nip()
    End Sub

    Public Sub masuk_nip()
        Try
            cmd = New SqlClient.SqlCommand("select nip from tpegawai", conn)
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

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            cmd = New SqlCommand("select * from tpegawai where nip ='" & ComboBox2.Text & "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                TextBox1.Text = reader.Item(1)
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        cmd.Dispose()
        reader.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Formcetakslipkategori.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormSlipGaji.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class