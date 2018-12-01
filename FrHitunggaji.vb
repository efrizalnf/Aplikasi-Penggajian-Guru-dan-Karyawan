Imports System.Data.SqlClient

Public Class FrHitunggaji
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim a As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
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

        honor()
        hitung_gaji()
    End Sub
    
    Sub ref()
        Try
            Dim ds As New DataSet
            Dim adp = New SqlDataAdapter("select * from Tpenggajian ", penggajian.conn)
            adp.Fill(ds, "data")
            DataGridView1.DataSource = ds.Tables("data")
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        TextBox4.Text = 10000
    End Sub

    Private Sub FrHitunggaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        masuk_nip()
        ref()
        jabatan()
        jenjang()
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
    Public Sub jabatan()
        Try
            cmd = New SqlClient.SqlCommand("select jabatan from Tjabatan where jabatan = '" & Label19.Text & "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                ComboBox3.Items.Add(reader.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        cmd.Dispose()
        reader.Close()
    End Sub
    Public Sub jenjang()
        Try
            cmd = New SqlClient.SqlCommand("select jenjang from Tjenjang where jenjang = '" & Label20.Text & "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                ComboBox4.Items.Add(reader.Item(1))
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        cmd.Dispose()
        reader.Close()
    End Sub
    
    Sub masuk_jml()

        Dim cmd = New SqlCommand("select masuk - jml_kehadiran from tkehadiran where nip ='" & ComboBox2.Text & "'", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read
            Label7.Text = reader.Item(0)
        End While
    End Sub
    Public Sub masuk_tkehadiran()
        cmd = New SqlCommand("select masuk,jml_kehadiran   from Tkehadiran  where NIP='" + ComboBox2.Text + "' and bulan='" + ComboBox1.Text + "' and tahun='" + TextBox6.Text + "' ", conn)

        reader = cmd.ExecuteReader
        Try
            If reader.HasRows = False Then

            Else
                While reader.Read
                    Label12.Text = reader.Item("masuk")
                    Label7.Text = reader.Item("jml_kehadiran")
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        reader.Close()
        cmd.Dispose()
    End Sub

    Sub honor()
        Label17.Text = (Val(Label7.Text) * Val(Label20.Text))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TextBox6.Text = "" Then
            MsgBox("Isi Tahun Terlebih Dahulu")
        Else
            masuk_tkehadiran()
            potongan()
            honor()
        End If

    End Sub

    Sub potongan()
        Label14.Text = ((Val(Label12.Text) - Val(Label7.Text)) * 5000)
    End Sub

    Sub hitung_gaji()
        TextBox5.Text = (Val(Label17.Text) + Val(Label19.Text) + Val(TextBox3.Text)) - (Val(Label14.Text) + Val(TextBox4.Text))
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        hitung_gaji()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        hitung_gaji()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        hitung_gaji()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        hitung_gaji()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        hitung_gaji()
    End Sub
    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        hitung_gaji()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpan()
        ref()
    End Sub
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        hitung_gaji()
    End Sub
    Sub simpan()
        Try
            Dim s As String

            s = "insert into  Tpenggajian values  ('" + ComboBox2.Text + "','" + Label14.Text + "','" + Label19.Text + "','" + TextBox5.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.Text + "','" + TextBox6.Text + "')"
            Dim command As New SqlClient.SqlCommand(s, conn)
            command.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormReportPenggajian.Show()
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            cmd = New SqlCommand("select * from tjabatan where jabatan ='" & ComboBox3.Text & "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Label19.Text = Val(reader.Item(1))
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        cmd.Dispose()
        reader.Close()

        hitung_gaji()
        jabatan()
    End Sub


    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            cmd = New SqlCommand("select * from tjenjang where jenjang ='" & ComboBox4.Text & "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Label20.Text = reader.Item(2)
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        cmd.Dispose()
        reader.Close()

        honor()
        hitung_gaji()
        jenjang()
    End Sub

   
End Class