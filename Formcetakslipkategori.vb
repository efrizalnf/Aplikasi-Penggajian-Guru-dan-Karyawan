Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Formcetakslipkategori

    Dim crParameterFieldDefinitions As ParameterFieldDefinitions
    Dim crParameterFieldDefinition As ParameterFieldDefinition
    Dim crParameterValues As New ParameterValues
    Dim crParameterDiscreteValue As New ParameterDiscreteValue

    Dim cryRpt As New ReportDocument
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim CrTables As Tables
    Dim CrTable As Table

    Private Sub Formcetakslipkategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penggajian.conect()
        'cryRpt.Load("D:\APLIKASI SPP\SPP\SPP\REPORT\RPT\CetakDSP.rpt")
        cryRpt.Load("D:\VB\Aplikasi Penggajian Guru dan Karyawan YAPINDA\Gaji\Laporan\RptSlipgaji.rpt")
        With crConnectionInfo
            .ServerName = penggajian.server
            .DatabaseName = penggajian.db
            .UserID = ""
            .Password = ""
        End With
        CrTables = cryRpt.Database.Tables
        CrystalReportViewer1.RefreshReport()

        CrystalReportViewer1.SelectionFormula = "{Tpegawai.NIP}='" + Formlaporanslipkategori.ComboBox2.Text + "'  and {Tpenggajian.tahun}='" + Formlaporanslipkategori.TextBox6.Text + "' and {Tpenggajian.bulan}='" + Formlaporanslipkategori.ComboBox1.Text + "'"
        'CrystalReportViewer1.SelectionFormula = "{Tpegawai.NIP}='" + Formlaporanslipkategori.TextBox1.Text + "'  and {Tpenggajian.tahun}='" + Formlaporanslipkategori.TextBox6.Text + "'"
        '
        'CrystalReportViewer1.SelectionFormula = "{Tpenggajian.NIP}='" + Formlaporanslipkategori.TextBox1.Text + "'"



        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class