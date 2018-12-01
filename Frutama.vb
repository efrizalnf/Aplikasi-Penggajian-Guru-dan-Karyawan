Public Class frutama

    Private Sub frutama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lbltanggal.Text = Format(Now.Date, "dddd, d MMMM yyyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        Frlogin.Show()
        Me.Close()
    End Sub

    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frPegawai.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        formlaporankehadiran.Show()
    End Sub

    Private Sub Barang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Penggajian.Click
        FrPenggajian.Show()
    End Sub

    Private Sub DataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPegawaiToolStripMenuItem.Click
        frPegawai.Show()
    End Sub

    Private Sub DataKehadiranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKehadiranToolStripMenuItem.Click
        formlaporankehadiran.Show()
    End Sub

    Private Sub DataPenggajianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPenggajianToolStripMenuItem.Click
        FrPenggajian.Show()
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegawaiToolStripMenuItem.Click
        frptpegawai.Show()
    End Sub

    Private Sub DataPengunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPengunaToolStripMenuItem.Click
        Frpengguna.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KehadiranToolStripMenuItem.Click
        FormrReportKehadiran.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggajianToolStripMenuItem.Click
        FormReportPenggajian.Show()
    End Sub

    Private Sub CetakSlipGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSlipGajiToolStripMenuItem.Click
        Formlaporanslipkategori.Show()
    End Sub
End Class