Imports System.Data.SqlClient

Module penggajian
    Public server, db As String
    Public conn As New SqlClient.SqlConnection

    Public Sub con()
        conn = New SqlClient.SqlConnection("server=PROJECT;database=Penggajian;integrated security=true")
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Gagal terkoneksi dengan database !")
            conn.Dispose()
        End Try
    End Sub

    Public Sub conect()
        server = "PROJECT"
        db = "Penggajian"
    End Sub
End Module
