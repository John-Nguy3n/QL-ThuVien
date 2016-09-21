<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiem))
        Me.btnThoatTK = New System.Windows.Forms.Button()
        Me.btnTimKiemTK = New System.Windows.Forms.Button()
        Me.txtMaSachTK = New System.Windows.Forms.TextBox()
        Me.txtTenSachTK = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvXemDanhSach = New System.Windows.Forms.DataGridView()
        Me.lblBiaSachTK = New System.Windows.Forms.Label()
        Me.ptbHinhSachTK = New System.Windows.Forms.PictureBox()
        Me.lblTenSachTK = New System.Windows.Forms.Label()
        Me.lblTacGia = New System.Windows.Forms.Label()
        Me.lblMaSach = New System.Windows.Forms.Label()
        Me.lblTenSach = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvXemDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinhSachTK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoatTK
        '
        Me.btnThoatTK.Location = New System.Drawing.Point(461, 341)
        Me.btnThoatTK.Name = "btnThoatTK"
        Me.btnThoatTK.Size = New System.Drawing.Size(87, 23)
        Me.btnThoatTK.TabIndex = 14
        Me.btnThoatTK.Text = "Thoát"
        Me.btnThoatTK.UseVisualStyleBackColor = True
        '
        'btnTimKiemTK
        '
        Me.btnTimKiemTK.Location = New System.Drawing.Point(609, 17)
        Me.btnTimKiemTK.Name = "btnTimKiemTK"
        Me.btnTimKiemTK.Size = New System.Drawing.Size(75, 23)
        Me.btnTimKiemTK.TabIndex = 13
        Me.btnTimKiemTK.Text = "Tìm kiếm"
        Me.btnTimKiemTK.UseVisualStyleBackColor = True
        '
        'txtMaSachTK
        '
        Me.txtMaSachTK.Location = New System.Drawing.Point(315, 17)
        Me.txtMaSachTK.Name = "txtMaSachTK"
        Me.txtMaSachTK.Size = New System.Drawing.Size(80, 23)
        Me.txtMaSachTK.TabIndex = 10
        '
        'txtTenSachTK
        '
        Me.txtTenSachTK.Location = New System.Drawing.Point(102, 17)
        Me.txtTenSachTK.Name = "txtTenSachTK"
        Me.txtTenSachTK.Size = New System.Drawing.Size(142, 23)
        Me.txtTenSachTK.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dgvXemDanhSach)
        Me.Panel1.Controls.Add(Me.lblBiaSachTK)
        Me.Panel1.Controls.Add(Me.ptbHinhSachTK)
        Me.Panel1.Controls.Add(Me.lblTenSachTK)
        Me.Panel1.Location = New System.Drawing.Point(49, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 264)
        Me.Panel1.TabIndex = 9
        '
        'dgvXemDanhSach
        '
        Me.dgvXemDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemDanhSach.Location = New System.Drawing.Point(180, 39)
        Me.dgvXemDanhSach.Name = "dgvXemDanhSach"
        Me.dgvXemDanhSach.Size = New System.Drawing.Size(448, 229)
        Me.dgvXemDanhSach.TabIndex = 21
        '
        'lblBiaSachTK
        '
        Me.lblBiaSachTK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBiaSachTK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblBiaSachTK.Location = New System.Drawing.Point(-1, 0)
        Me.lblBiaSachTK.Name = "lblBiaSachTK"
        Me.lblBiaSachTK.Size = New System.Drawing.Size(175, 36)
        Me.lblBiaSachTK.TabIndex = 5
        Me.lblBiaSachTK.Text = "Bìa sách"
        Me.lblBiaSachTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbHinhSachTK
        '
        Me.ptbHinhSachTK.BackgroundImage = CType(resources.GetObject("ptbHinhSachTK.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhSachTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhSachTK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhSachTK.Location = New System.Drawing.Point(-2, 33)
        Me.ptbHinhSachTK.Name = "ptbHinhSachTK"
        Me.ptbHinhSachTK.Size = New System.Drawing.Size(176, 220)
        Me.ptbHinhSachTK.TabIndex = 4
        Me.ptbHinhSachTK.TabStop = False
        '
        'lblTenSachTK
        '
        Me.lblTenSachTK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTenSachTK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenSachTK.Location = New System.Drawing.Point(173, 0)
        Me.lblTenSachTK.Name = "lblTenSachTK"
        Me.lblTenSachTK.Size = New System.Drawing.Size(460, 36)
        Me.lblTenSachTK.TabIndex = 0
        Me.lblTenSachTK.Text = "Danh sách tìm kiếm"
        Me.lblTenSachTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTacGia
        '
        Me.lblTacGia.AutoSize = True
        Me.lblTacGia.Location = New System.Drawing.Point(417, 20)
        Me.lblTacGia.Name = "lblTacGia"
        Me.lblTacGia.Size = New System.Drawing.Size(48, 15)
        Me.lblTacGia.TabIndex = 6
        Me.lblTacGia.Text = "Tác giả:"
        '
        'lblMaSach
        '
        Me.lblMaSach.AutoSize = True
        Me.lblMaSach.Location = New System.Drawing.Point(260, 20)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(54, 15)
        Me.lblMaSach.TabIndex = 7
        Me.lblMaSach.Text = "Mã sách:"
        '
        'lblTenSach
        '
        Me.lblTenSach.AutoSize = True
        Me.lblTenSach.Location = New System.Drawing.Point(45, 20)
        Me.lblTenSach.Name = "lblTenSach"
        Me.lblTenSach.Size = New System.Drawing.Size(57, 15)
        Me.lblTenSach.TabIndex = 8
        Me.lblTenSach.Text = "Tên sách:"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(471, 17)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(132, 23)
        Me.txtTacGia.TabIndex = 16
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(330, 341)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(88, 23)
        Me.btnXem.TabIndex = 17
        Me.btnXem.Text = "Chi tiết"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'frmTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 410)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.btnThoatTK)
        Me.Controls.Add(Me.btnTimKiemTK)
        Me.Controls.Add(Me.txtMaSachTK)
        Me.Controls.Add(Me.txtTenSachTK)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTacGia)
        Me.Controls.Add(Me.lblMaSach)
        Me.Controls.Add(Me.lblTenSach)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTimKiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tìm kiếm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvXemDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinhSachTK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoatTK As System.Windows.Forms.Button
    Friend WithEvents btnTimKiemTK As System.Windows.Forms.Button
    Friend WithEvents txtMaSachTK As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSachTK As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblBiaSachTK As System.Windows.Forms.Label
    Friend WithEvents ptbHinhSachTK As System.Windows.Forms.PictureBox
    Friend WithEvents lblTenSachTK As System.Windows.Forms.Label
    Friend WithEvents lblTacGia As System.Windows.Forms.Label
    Friend WithEvents lblMaSach As System.Windows.Forms.Label
    Friend WithEvents lblTenSach As System.Windows.Forms.Label
    Friend WithEvents txtTacGia As System.Windows.Forms.TextBox
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents dgvXemDanhSach As System.Windows.Forms.DataGridView
End Class
