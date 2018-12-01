<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frutama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frutama))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.LblUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.Lbltanggal = New System.Windows.Forms.ToolStripStatusLabel
        Me.LblJam = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKehadiranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPengunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KehadiranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakSlipGajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.Penggajian = New System.Windows.Forms.ToolStripButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LblUser, Me.Lbltanggal, Me.LblJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 544)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel1.Text = "User Login :  "
        '
        'LblUser
        '
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(460, 17)
        Me.LblUser.Spring = True
        '
        'Lbltanggal
        '
        Me.Lbltanggal.Name = "Lbltanggal"
        Me.Lbltanggal.Size = New System.Drawing.Size(121, 17)
        Me.Lbltanggal.Text = "ToolStripStatusLabel3"
        '
        'LblJam
        '
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(121, 17)
        Me.LblJam.Text = "ToolStripStatusLabel4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOffToolStripMenuItem, Me.EToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.LogOffToolStripMenuItem.Text = "LogOff"
        '
        'EToolStripMenuItem
        '
        Me.EToolStripMenuItem.Name = "EToolStripMenuItem"
        Me.EToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.EToolStripMenuItem.Text = "E&xit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPegawaiToolStripMenuItem, Me.DataKehadiranToolStripMenuItem, Me.DataPenggajianToolStripMenuItem, Me.DataPenggunaToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'DataPegawaiToolStripMenuItem
        '
        Me.DataPegawaiToolStripMenuItem.Name = "DataPegawaiToolStripMenuItem"
        Me.DataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DataPegawaiToolStripMenuItem.Text = "Data Pegawai"
        '
        'DataKehadiranToolStripMenuItem
        '
        Me.DataKehadiranToolStripMenuItem.Name = "DataKehadiranToolStripMenuItem"
        Me.DataKehadiranToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DataKehadiranToolStripMenuItem.Text = "Data Kehadiran"
        '
        'DataPenggajianToolStripMenuItem
        '
        Me.DataPenggajianToolStripMenuItem.Name = "DataPenggajianToolStripMenuItem"
        Me.DataPenggajianToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DataPenggajianToolStripMenuItem.Text = "Data Penggajian"
        '
        'DataPenggunaToolStripMenuItem
        '
        Me.DataPenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPengunaToolStripMenuItem})
        Me.DataPenggunaToolStripMenuItem.Name = "DataPenggunaToolStripMenuItem"
        Me.DataPenggunaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DataPenggunaToolStripMenuItem.Text = "Data Pengguna"
        '
        'DataPengunaToolStripMenuItem
        '
        Me.DataPengunaToolStripMenuItem.Name = "DataPengunaToolStripMenuItem"
        Me.DataPengunaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DataPengunaToolStripMenuItem.Text = "Data Penguna"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PegawaiToolStripMenuItem, Me.KehadiranToolStripMenuItem, Me.PenggajianToolStripMenuItem, Me.CetakSlipGajiToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'PegawaiToolStripMenuItem
        '
        Me.PegawaiToolStripMenuItem.Name = "PegawaiToolStripMenuItem"
        Me.PegawaiToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PegawaiToolStripMenuItem.Text = "Laporan Pegawai"
        '
        'KehadiranToolStripMenuItem
        '
        Me.KehadiranToolStripMenuItem.Name = "KehadiranToolStripMenuItem"
        Me.KehadiranToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.KehadiranToolStripMenuItem.Text = "Laporan Kehadiran"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PenggajianToolStripMenuItem.Text = "Laporan Penggajian"
        '
        'CetakSlipGajiToolStripMenuItem
        '
        Me.CetakSlipGajiToolStripMenuItem.Name = "CetakSlipGajiToolStripMenuItem"
        Me.CetakSlipGajiToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CetakSlipGajiToolStripMenuItem.Text = "Cetak Slip Gaji"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton3, Me.Penggajian})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 57)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(55, 54)
        Me.ToolStripButton1.Text = "Pegawai"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(44, 41)
        Me.ToolStripButton3.Text = "Absen"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Penggajian
        '
        Me.Penggajian.Image = CType(resources.GetObject("Penggajian.Image"), System.Drawing.Image)
        Me.Penggajian.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Penggajian.Name = "Penggajian"
        Me.Penggajian.Size = New System.Drawing.Size(70, 41)
        Me.Penggajian.Text = "Penggajian"
        Me.Penggajian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 463)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frutama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Penggajian Guru dan Karyawan Yayasan Pendidikan Islam Nurul Huda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPengunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KehadiranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Penggajian As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataKehadiranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakSlipGajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbltanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblJam As System.Windows.Forms.ToolStripStatusLabel
End Class
