Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormrReportKehadiran
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
    Private Sub FormrReportKehadiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penggajian.conect()
        'cryRpt.Load("D:\APLIKASI SPP\SPP\SPP\REPORT\RPT\CetakDSP.rpt")
        cryRpt.Load("D:\VB\Aplikasi Penggajian Guru dan Karyawan YAPINDA\Gaji\Laporan\RptKehadiran.rpt")
        With crConnectionInfo
            .ServerName = penggajian.server
            .DatabaseName = penggajian.db
            .UserID = ""
            .Password = ""
        End With
        CrTables = cryRpt.Database.Tables
        CrystalReportViewer1.RefreshReport()
        'CrystalReportViewer1.SelectionFormula = "{transaksi_dsp.no_transaksi_dsp}='" + Form_Transaksi_Dsp.txtvalidasi.Text + "'"
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class