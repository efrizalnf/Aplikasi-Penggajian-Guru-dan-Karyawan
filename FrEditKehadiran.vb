Imports System.Data.SqlClient
Imports System.Data
Public Class FrEditKehadiran

    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        hitung()
    End Sub

    Public Sub masuk_nip()
        cmd = New SqlCommand("select nip from tpegawai", conn)
        reader = cmd.ExecuteReader
        Try

            While reader.Read
                ComboBox2.Items.Add(reader.Item(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        cmd.Dispose()
        reader.Close()

    End Sub

    Public Sub masuk_tkehadiran()
        cmd = New SqlCommand("select masuk, izin, alfa, sakit , jml_kehadiran from Tkehadiran  where NIP='" + ComboBox2.Text + "' and bulan='" + ComboBox1.Text + "' and tahun='" + TextBox6.Text + "' ", conn)
        ' cmd = New SqlClient.SqlCommand("select * from tkehadiran where NIP='" + ComboBox2.Text + "'and bulan='" + ComboBox1.Text + "' and tahun = '" + TextBox6.Text + "'", conn)
        reader = cmd.ExecuteReader
        Try
            If reader.HasRows = False Then
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox7.Text = ""
                ComboBox2.Text = ""
                ComboBox2.Focus()
            Else
                While reader.Read
                    TextBox2.Text = reader.Item("masuk")
                    TextBox3.Text = reader.Item("izin")
                    TextBox4.Text = reader.Item("alfa")
                    TextBox5.Text = reader.Item("sakit")
                    TextBox7.Text = reader.Item("jml_kehadiran")

                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        reader.Close()
        cmd.Dispose()
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

    Sub hitung()
        TextBox7.Text = Val(TextBox2.Text) - (Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text))
    End Sub


    Private Sub FrEditKehadiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        masuk_nip()
    End Sub



    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        hitung()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        hitung()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        hitung()
    End Sub

    
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TextBox6.Text = "" Then
            MsgBox("Isi Data dengan lengkap", MsgBoxStyle.Critical)
        Else
            masuk_tkehadiran()
        End If

    End Sub

    Sub ubah()
        
        Try
            Dim ubah As String

            ubah = "update Tkehadiran set masuk='" + TextBox2.Text + "' ,izin='" + TextBox3.Text + "' ,alfa='" + TextBox4.Text + "' , sakit='" + TextBox5.Text + "' ,jml_kehadiran='" + TextBox7.Text + "' where NIP='" + ComboBox2.Text + "' and tahun ='" + TextBox6.Text + "' and bulan ='" + ComboBox1.Text + "'"

            Dim command As New SqlClient.SqlCommand(ubah, conn)
            command.ExecuteNonQuery()
            MsgBox("Data Berhasil DiUbah")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ubah()
    End Sub
End Class