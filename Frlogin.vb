Imports System.Data.SqlClient
Public Class Frlogin

    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim a As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            cmd = New SqlCommand("select * from tpegawai where username  ='" & TextBox1.Text & "' and password = '" + TextBox2.Text + "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                TextBox3.Text = reader.Item("NIP")
                TextBox4.Text = reader.Item("Jabatan")
            End While

            If TextBox4.Text = "Guru" Then

                frutama.DataToolStripMenuItem.Visible = False
                frutama.DataPegawaiToolStripMenuItem.Visible = False
                frutama.DataPenggajianToolStripMenuItem.Visible = False
                frutama.DataKehadiranToolStripMenuItem.Visible = False
                frutama.DataPengunaToolStripMenuItem.Visible = False


                frutama.LaporanToolStripMenuItem.Visible = True
                frutama.PegawaiToolStripMenuItem.Visible = False
                frutama.KehadiranToolStripMenuItem.Visible = False
                frutama.PenggajianToolStripMenuItem.Visible = False
                frutama.CetakSlipGajiToolStripMenuItem.Visible = True

                frutama.ToolStripButton1.Visible = False
                frutama.ToolStripButton3.Visible = False
                frutama.Penggajian.Visible = False

                MsgBox("Anda Sebagai " + TextBox4.Text)
                frutama.Show()

            ElseIf TextBox4.Text = "TU Sekolah" Then

                frutama.DataToolStripMenuItem.Visible = True
                frutama.DataPegawaiToolStripMenuItem.Visible = True
                frutama.DataPenggajianToolStripMenuItem.Visible = False
                frutama.DataKehadiranToolStripMenuItem.Visible = True
                frutama.DataPengunaToolStripMenuItem.Visible = False



                frutama.LaporanToolStripMenuItem.Visible = True
                frutama.PegawaiToolStripMenuItem.Visible = True
                frutama.KehadiranToolStripMenuItem.Visible = True
                frutama.PenggajianToolStripMenuItem.Visible = True
                frutama.CetakSlipGajiToolStripMenuItem.Visible = False

                frutama.ToolStripButton1.Visible = True
                frutama.ToolStripButton3.Visible = True
                frutama.Penggajian.Visible = False

                MsgBox("Anda Sebagai " + TextBox4.Text)
                frutama.Show()

            ElseIf TextBox4.Text = "TU Yayasan" Or TextBox4.Text = "Kepala Sekolah" Then

                frutama.DataToolStripMenuItem.Visible = True
                frutama.DataPegawaiToolStripMenuItem.Visible = True
                frutama.DataPenggajianToolStripMenuItem.Visible = True
                frutama.DataKehadiranToolStripMenuItem.Visible = True
                frutama.DataPengunaToolStripMenuItem.Visible = True



                frutama.LaporanToolStripMenuItem.Visible = True
                frutama.PegawaiToolStripMenuItem.Visible = True
                frutama.KehadiranToolStripMenuItem.Visible = True
                frutama.PenggajianToolStripMenuItem.Visible = True
                frutama.CetakSlipGajiToolStripMenuItem.Visible = True

                MsgBox("Anda Sebagai " + TextBox4.Text)
                frutama.Show()

                frutama.ToolStripButton1.Visible = True
                frutama.ToolStripButton3.Visible = True
                frutama.Penggajian.Visible = True
            End If
            'TU(Sekolah)
            'TU(Yayasan)
            'Kepala(Sekolah)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        cmd.Dispose()
        reader.Close()
        Me.Close()
    End Sub

    Private Sub Frlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()

    End Sub


End Class
