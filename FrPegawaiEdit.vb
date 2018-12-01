Imports System.Data.SqlClient
Public Class FrPegawaiEdit
    Dim jenis_kelamin As String
    Dim count_jenjang As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con()
        ubah()
    End Sub
    Sub ubah()
        'Try
        '    Dim ubah As String
        '    ubah = "insert into tpegawai values ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & jenis_kelamin & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "')"

        '    Dim command As New SqlClient.SqlCommand(ubah, conn)
        '    command.ExecuteNonQuery()

        '    If CheckBox1.Checked = True Then
        '        Dim ubah2 As String
        '        ubah2 = "insert into jenjang_NIP values ('" & TextBox2.Text & "','001')"
        '        Dim command2 As New SqlClient.SqlCommand(ubah2, conn)
        '        command2.ExecuteNonQuery()
        '    End If

        '    If CheckBox2.Checked = True Then
        '        Dim ubah3 As String
        '        ubah3 = "insert into jenjang_NIP values ('" & TextBox2.Text & "','002')"
        '        Dim command2 As New SqlClient.SqlCommand(ubah3, conn)
        '        command2.ExecuteNonQuery()
        '    End If

        '    If CheckBox3.Checked = True Then
        '        Dim ubah4 As String
        '        ubah4 = "insert into jenjang_NIP values ('" & TextBox2.Text & "','003')"
        '        Dim command3 As New SqlClient.SqlCommand(ubah4, conn)
        '        command3.ExecuteNonQuery()
        '    End If

        '    If CheckBox4.Checked = True Then
        '        Dim ubah5 As String
        '        ubah5 = "insert into jenjang_NIP values ('" & TextBox2.Text & "','004')"
        '        Dim command4 As New SqlClient.SqlCommand(ubah5, conn)
        '        command4.ExecuteNonQuery()
        '    End If

        '    conn.Close()

        '    MsgBox("data berhasil diubah", MsgBoxStyle.Information)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Try
            Dim ubah As String
            
            ubah = "update Tpegawai set nama_pegawai='" & TextBox2.Text & "'," & _
                    "tempat_lahir='" & TextBox3.Text & "',tanggal_lahir='" & DateTimePicker1.Text & "'," & _
                    "jenis_kelamin='" & TextBox7.Text & "',alamat='" & TextBox4.Text & "'," & _
                    "telepon='" & TextBox5.Text & "', pendidikan='" & ComboBox1.Text & "',jabatan='" & ComboBox2.Text & "'," & _
                    "username='" & TextBox6.Text & "', password='" & TextBox8.Text & "' where NIP ='" + ComboBox3.Text + "'"

            Dim command As New SqlClient.SqlCommand(ubah, conn)
            command.ExecuteNonQuery()
            MsgBox("Data Berhasil DiUbah")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Me.Close()
    End Sub
    

    Private Sub FrPegawaiEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con()
        masuk_nip()
        masuk_nama()
    End Sub

    Public Sub masuk_nip()
        Dim cmd = New SqlClient.SqlCommand("select nip from tpegawai", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read
            ComboBox3.Items.Add(reader.Item(0))
        End While
    End Sub
    Sub masuk_nama()
        con()
        Dim cmd = New SqlCommand("select nama_pegawai from tpegawai where nama_pegawai ='" & TextBox2.Text & "'", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read
            TextBox2.Text = reader.Item(0)
        End While
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            jenis_kelamin = "L"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            jenis_kelamin = "P"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        txtra.Text = "RA"
        txtra1.Text = "001"
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        txtmi.Text = "MI"
        txtmi1.Text = "002"
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        txtmts.Text = "MTS"
        txtmts1.Text = "003"
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        txtma.Text = "MA"
            txtma1.Text = "004"
    End Sub

    
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        
        con()
        Dim cmd = New SqlCommand("select * from tpegawai where nip ='" & ComboBox3.Text & "'", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read

            TextBox2.Text = reader.Item(1)
            TextBox3.Text = reader.Item(2)
            DateTimePicker1.Text = reader.Item(3)
            TextBox7.Text = reader.Item(4)
            TextBox4.Text = reader.Item(5)
            TextBox5.Text = reader.Item(6)
            ComboBox1.Text = reader.Item(7)
            ComboBox2.Text = reader.Item(8)
            TextBox6.Text = reader.Item(9)
            TextBox8.Text = reader.Item(10)


        End While
        'masuk_nama()

        If TextBox7.Text = "L" Then
            RadioButton1.Checked = True

        ElseIf TextBox7.Text = "P" Then
            RadioButton2.Checked = True
        End If
        
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "L" Then
            RadioButton1.Checked = True

        ElseIf TextBox7.Text = "P" Then
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class


