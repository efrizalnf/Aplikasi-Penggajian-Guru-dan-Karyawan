Imports System.Data.SqlClient

Public Class frPegawai
    Dim jenis_kelamin As String
    Dim count_jenjang As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con()
        simpan()
    End Sub

    Sub simpanjenjang()
        Try
            Dim simpan As String
            simpan = "insert into tpegawai values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & jenis_kelamin & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "')"

            Dim command As New SqlClient.SqlCommand(simpan, conn)
            command.ExecuteNonQuery()

            If CheckBox1.Checked = True Then
                Dim simpan2 As String
                simpan2 = "insert into jenjang_NIP values ('" & TextBox1.Text & "','001')"
                Dim command2 As New SqlClient.SqlCommand(simpan2, conn)
                command2.ExecuteNonQuery()
            End If

            If CheckBox2.Checked = True Then
                Dim simpan3 As String
                simpan3 = "insert into jenjang_NIP values ('" & TextBox1.Text & "','002')"
                Dim command2 As New SqlClient.SqlCommand(simpan3, conn)
                command2.ExecuteNonQuery()
            End If

            If CheckBox3.Checked = True Then
                Dim simpan4 As String
                simpan4 = "insert into jenjang_NIP values ('" & TextBox1.Text & "','003')"
                Dim command3 As New SqlClient.SqlCommand(simpan4, conn)
                command3.ExecuteNonQuery()
            End If

            If CheckBox4.Checked = True Then
                Dim simpan5 As String
                simpan5 = "insert into jenjang_NIP values ('" & TextBox1.Text & "','004')"
                Dim command4 As New SqlClient.SqlCommand(simpan5, conn)
                command4.ExecuteNonQuery()
            End If

            conn.Close()

            MsgBox("data disimpan", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    
    Sub simpan()
        Try
            Dim simpan As String
            simpan = "insert into tpegawai values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & jenis_kelamin & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "')"

            Dim command As New SqlClient.SqlCommand(simpan, conn)
            command.ExecuteNonQuery()

            If CheckBox1.Checked = True Then
                Dim simpan2 As String
                simpan2 = "insert into jenjang_NIP values ('" & TextBox1.Text & "','001')"
                Dim command2 As New SqlClient.SqlCommand(simpan2, conn)
                command2.ExecuteNonQuery()
            End If

            If CheckBox2.Checked = True Then
                Dim simpan3 As String
                simpan3 = "insert into jenjang_NIP values ('" & TextBox1.Text & "','002')"
                Dim command2 As New SqlClient.SqlCommand(simpan3, conn)
                command2.ExecuteNonQuery()
            End If

            If CheckBox3.Checked = True Then
                Dim simpan4 As String
                simpan4 = "insert into jenjang_NIP values ('" & TextBox1.Text & "','003')"
                Dim command3 As New SqlClient.SqlCommand(simpan4, conn)
                command3.ExecuteNonQuery()
            End If

            If CheckBox4.Checked = True Then
                Dim simpan5 As String
                simpan5 = "insert into jenjang_NIP values ('" & TextBox1.Text & "','004')"
                Dim command4 As New SqlClient.SqlCommand(simpan5, conn)
                command4.ExecuteNonQuery()
            End If

            conn.Close()

            MsgBox("data disimpan", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Private Sub frPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con()
        ref()
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
        Dim adp = New SqlDataAdapter("select * from tpegawai where nama_pegawai like '" & TextBox7.Text & "%'", penggajian.conn)
        adp.Fill(ds, "data")
        DataGridView1.DataSource = ds.Tables("data")
        DataGridView1.Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cari()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ref()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FrPegawaiEdit.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Frhapuspegawai.ComboBox2.Text = DataGridView1.SelectedRows(0).Cells(0).Value
        Frhapuspegawai.TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value
        Frhapuspegawai.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Frhapuspegawai.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frptpegawai.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
       
        If CheckBox1.Checked = True Then
            txtRA.Text = "001"
        End If

        
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            txtMTS.Text = "003"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtMI.Text = "002"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox1.Checked = True Then
            txtMA.Text = "004"
        End If
    End Sub
End Class