Imports System.Data.SqlClient
Public Class formlaporankehadiran

    Sub ref()
        Try
            Dim ds As New DataSet
            Dim adp = New SqlDataAdapter("select * from tKehadiran", penggajian.conn)
            adp.Fill(ds, "data")
            DataGridView1.DataSource = ds.Tables("data")
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub


    Private Sub FrKehadiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        ref()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrInputKehadiran.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrEditKehadiran.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ref()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cari()
    End Sub
    Sub cari()
        Dim ds As New DataSet
        Dim adp = New SqlDataAdapter("select * from tpegawai where nama_pegawai like '" & TextBox1.Text & "%'", penggajian.conn)
        adp.Fill(ds, "data")
        DataGridView1.DataSource = ds.Tables("data")
        DataGridView1.Refresh()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FormrReportKehadiran.Show()
    End Sub
End Class