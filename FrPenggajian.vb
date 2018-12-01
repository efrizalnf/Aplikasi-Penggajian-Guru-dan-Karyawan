Imports System.Data.SqlClient

Public Class FrPenggajian

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrHitunggaji.Show()
    End Sub

    Private Sub FrPenggajian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        ref()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ref()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cari()
    End Sub

    Sub ref()
        Dim ds As New DataSet
        Dim adp = New SqlDataAdapter("select * from tpegawai", penggajian.conn)
        adp.Fill(ds, "data")
        DataGridView1.DataSource = ds.Tables("data")
        DataGridView1.Refresh()
    End Sub

    Sub cari()
        Dim ds As New DataSet
        Dim adp = New SqlDataAdapter("select * from tpegawai where nama_pegawai like '" & TextBox1.Text & "%'", penggajian.conn)
        adp.Fill(ds, "data")
        DataGridView1.DataSource = ds.Tables("data")
        DataGridView1.Refresh()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Formlaporanslipkategori.Show()
    End Sub
End Class