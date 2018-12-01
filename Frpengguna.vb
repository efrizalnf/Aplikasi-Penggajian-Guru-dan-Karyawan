Imports System.Data.SqlClient
Public Class Frpengguna

    Private Sub Frpengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        ref()
    End Sub

    Sub ref()
        Dim ds As New DataSet
        Dim adp = New SqlDataAdapter("select NIP,username, password from tpegawai", penggajian.conn)
        adp.Fill(ds, "data")
        DataGridView1.DataSource = ds.Tables("data")
        DataGridView1.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ubah()
        ref()
    End Sub

    Sub ubah()

        Try
            Dim ubah As String

            ubah = "update Tpegawai set username='" + TextBox1.Text + "' ,password='" + TextBox2.Text + "' where NIP='" + TextBox3.Text + "'"

            Dim command As New SqlClient.SqlCommand(ubah, conn)
            command.ExecuteNonQuery()
            MsgBox("Data Berhasil DiUbah")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

   

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox3.Text = DataGridView1.SelectedRows(0).Cells(0).Value
        TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value
        TextBox2.Text = DataGridView1.SelectedRows(0).Cells(2).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class