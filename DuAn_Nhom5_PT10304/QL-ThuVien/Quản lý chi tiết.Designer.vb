<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyCT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyCT))
        Me.btnSuaHinhQLCT = New System.Windows.Forms.Button()
        Me.btnThoatQLCT = New System.Windows.Forms.Button()
        Me.btnLuuQLCT = New System.Windows.Forms.Button()
        Me.pnlKhungQL = New System.Windows.Forms.Panel()
        Me.cbbTL = New System.Windows.Forms.ComboBox()
        Me.lbNgay = New System.Windows.Forms.Label()
        Me.lbTrangThai = New System.Windows.Forms.Label()
        Me.lbTacGia = New System.Windows.Forms.Label()
        Me.lbMaSach = New System.Windows.Forms.Label()
        Me.lblTheLoai = New System.Windows.Forms.Label()
        Me.lbTenSach = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtTenSachQLCT = New System.Windows.Forms.TextBox()
        Me.txtMaSachQLCT = New System.Windows.Forms.TextBox()
        Me.cbbTrangThai = New System.Windows.Forms.ComboBox()
        Me.dtbNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.txtNoiDungQLCT = New System.Windows.Forms.RichTextBox()
        Me.lblGioiThieuQLCT = New System.Windows.Forms.Label()
        Me.lblBiaSachQLCT = New System.Windows.Forms.Label()
        Me.ptbHinhSachQLCT = New System.Windows.Forms.PictureBox()
        Me.pnlKhungQL.SuspendLayout()
        CType(Me.ptbHinhSachQLCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSuaHinhQLCT
        '
        Me.btnSuaHinhQLCT.Location = New System.Drawing.Point(91, 316)
        Me.btnSuaHinhQLCT.Name = "btnSuaHinhQLCT"
        Me.btnSuaHinhQLCT.Size = New System.Drawing.Size(94, 23)
        Me.btnSuaHinhQLCT.TabIndex = 20
        Me.btnSuaHinhQLCT.Text = "Sửa hình ảnh"
        Me.btnSuaHinhQLCT.UseVisualStyleBackColor = True
        '
        'btnThoatQLCT
        '
        Me.btnThoatQLCT.Location = New System.Drawing.Point(572, 316)
        Me.btnThoatQLCT.Name = "btnThoatQLCT"
        Me.btnThoatQLCT.Size = New System.Drawing.Size(87, 23)
        Me.btnThoatQLCT.TabIndex = 19
        Me.btnThoatQLCT.Text = "Thoát"
        Me.btnThoatQLCT.UseVisualStyleBackColor = True
        '
        'btnLuuQLCT
        '
        Me.btnLuuQLCT.Location = New System.Drawing.Point(421, 316)
        Me.btnLuuQLCT.Name = "btnLuuQLCT"
        Me.btnLuuQLCT.Size = New System.Drawing.Size(87, 23)
        Me.btnLuuQLCT.TabIndex = 17
        Me.btnLuuQLCT.Text = "Lưu"
        Me.btnLuuQLCT.UseVisualStyleBackColor = True
        '
        'pnlKhungQL
        '
        Me.pnlKhungQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlKhungQL.Controls.Add(Me.cbbTL)
        Me.pnlKhungQL.Controls.Add(Me.lbNgay)
        Me.pnlKhungQL.Controls.Add(Me.lbTrangThai)
        Me.pnlKhungQL.Controls.Add(Me.lbTacGia)
        Me.pnlKhungQL.Controls.Add(Me.lbMaSach)
        Me.pnlKhungQL.Controls.Add(Me.lblTheLoai)
        Me.pnlKhungQL.Controls.Add(Me.lbTenSach)
        Me.pnlKhungQL.Controls.Add(Me.txtTacGia)
        Me.pnlKhungQL.Controls.Add(Me.txtTenSachQLCT)
        Me.pnlKhungQL.Controls.Add(Me.txtMaSachQLCT)
        Me.pnlKhungQL.Controls.Add(Me.cbbTrangThai)
        Me.pnlKhungQL.Controls.Add(Me.dtbNgayNhap)
        Me.pnlKhungQL.Controls.Add(Me.txtNoiDungQLCT)
        Me.pnlKhungQL.Controls.Add(Me.lblGioiThieuQLCT)
        Me.pnlKhungQL.Controls.Add(Me.lblBiaSachQLCT)
        Me.pnlKhungQL.Controls.Add(Me.ptbHinhSachQLCT)
        Me.pnlKhungQL.Location = New System.Drawing.Point(24, 12)
        Me.pnlKhungQL.Name = "pnlKhungQL"
        Me.pnlKhungQL.Size = New System.Drawing.Size(635, 286)
        Me.pnlKhungQL.TabIndex = 16
        '
        'cbbTL
        '
        Me.cbbTL.FormattingEnabled = True
        Me.cbbTL.Items.AddRange(New Object() {"SDSXH", "SGT", "SKD", "SKH", "STT"})
        Me.cbbTL.Location = New System.Drawing.Point(297, 30)
        Me.cbbTL.Name = "cbbTL"
        Me.cbbTL.Size = New System.Drawing.Size(138, 23)
        Me.cbbTL.TabIndex = 34
        '
        'lbNgay
        '
        Me.lbNgay.AutoSize = True
        Me.lbNgay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbNgay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbNgay.Location = New System.Drawing.Point(441, 61)
        Me.lbNgay.Name = "lbNgay"
        Me.lbNgay.Size = New System.Drawing.Size(66, 15)
        Me.lbNgay.TabIndex = 33
        Me.lbNgay.Text = "Ngày đăng"
        '
        'lbTrangThai
        '
        Me.lbTrangThai.AutoSize = True
        Me.lbTrangThai.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbTrangThai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTrangThai.Location = New System.Drawing.Point(441, 33)
        Me.lbTrangThai.Name = "lbTrangThai"
        Me.lbTrangThai.Size = New System.Drawing.Size(62, 15)
        Me.lbTrangThai.TabIndex = 33
        Me.lbTrangThai.Text = "Trạng thái"
        '
        'lbTacGia
        '
        Me.lbTacGia.AutoSize = True
        Me.lbTacGia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbTacGia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTacGia.Location = New System.Drawing.Point(247, 61)
        Me.lbTacGia.Name = "lbTacGia"
        Me.lbTacGia.Size = New System.Drawing.Size(44, 15)
        Me.lbTacGia.TabIndex = 33
        Me.lbTacGia.Text = "Tác giả"
        '
        'lbMaSach
        '
        Me.lbMaSach.AutoSize = True
        Me.lbMaSach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbMaSach.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbMaSach.Location = New System.Drawing.Point(85, 228)
        Me.lbMaSach.Name = "lbMaSach"
        Me.lbMaSach.Size = New System.Drawing.Size(51, 15)
        Me.lbMaSach.TabIndex = 32
        Me.lbMaSach.Text = "Mã sách"
        '
        'lblTheLoai
        '
        Me.lblTheLoai.AutoSize = True
        Me.lblTheLoai.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTheLoai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTheLoai.Location = New System.Drawing.Point(241, 33)
        Me.lblTheLoai.Name = "lblTheLoai"
        Me.lblTheLoai.Size = New System.Drawing.Size(50, 15)
        Me.lblTheLoai.TabIndex = 31
        Me.lblTheLoai.Text = "Thể loại"
        '
        'lbTenSach
        '
        Me.lbTenSach.AutoSize = True
        Me.lbTenSach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbTenSach.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTenSach.Location = New System.Drawing.Point(237, 7)
        Me.lbTenSach.Name = "lbTenSach"
        Me.lbTenSach.Size = New System.Drawing.Size(54, 15)
        Me.lbTenSach.TabIndex = 31
        Me.lbTenSach.Text = "Tên sách"
        '
        'txtTacGia
        '
        Me.txtTacGia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTacGia.Location = New System.Drawing.Point(297, 56)
        Me.txtTacGia.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.txtTacGia.Multiline = True
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(138, 23)
        Me.txtTacGia.TabIndex = 7
        Me.txtTacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTenSachQLCT
        '
        Me.txtTenSachQLCT.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTenSachQLCT.Location = New System.Drawing.Point(297, 0)
        Me.txtTenSachQLCT.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.txtTenSachQLCT.Multiline = True
        Me.txtTenSachQLCT.Name = "txtTenSachQLCT"
        Me.txtTenSachQLCT.Size = New System.Drawing.Size(328, 27)
        Me.txtTenSachQLCT.TabIndex = 7
        Me.txtTenSachQLCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaSachQLCT
        '
        Me.txtMaSachQLCT.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtMaSachQLCT.Location = New System.Drawing.Point(-1, 251)
        Me.txtMaSachQLCT.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.txtMaSachQLCT.Multiline = True
        Me.txtMaSachQLCT.Name = "txtMaSachQLCT"
        Me.txtMaSachQLCT.ReadOnly = True
        Me.txtMaSachQLCT.Size = New System.Drawing.Size(236, 33)
        Me.txtMaSachQLCT.TabIndex = 7
        Me.txtMaSachQLCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbbTrangThai
        '
        Me.cbbTrangThai.FormattingEnabled = True
        Me.cbbTrangThai.Items.AddRange(New Object() {"Còn sách", "Tạm hết"})
        Me.cbbTrangThai.Location = New System.Drawing.Point(513, 30)
        Me.cbbTrangThai.Name = "cbbTrangThai"
        Me.cbbTrangThai.Size = New System.Drawing.Size(112, 23)
        Me.cbbTrangThai.TabIndex = 30
        '
        'dtbNgayNhap
        '
        Me.dtbNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbNgayNhap.Location = New System.Drawing.Point(513, 56)
        Me.dtbNgayNhap.Name = "dtbNgayNhap"
        Me.dtbNgayNhap.Size = New System.Drawing.Size(112, 23)
        Me.dtbNgayNhap.TabIndex = 8
        Me.dtbNgayNhap.Value = New Date(2016, 2, 26, 23, 12, 43, 0)
        '
        'txtNoiDungQLCT
        '
        Me.txtNoiDungQLCT.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtNoiDungQLCT.Location = New System.Drawing.Point(234, 124)
        Me.txtNoiDungQLCT.MaxLength = 255
        Me.txtNoiDungQLCT.Name = "txtNoiDungQLCT"
        Me.txtNoiDungQLCT.Size = New System.Drawing.Size(399, 160)
        Me.txtNoiDungQLCT.TabIndex = 7
        Me.txtNoiDungQLCT.Text = ""
        '
        'lblGioiThieuQLCT
        '
        Me.lblGioiThieuQLCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGioiThieuQLCT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblGioiThieuQLCT.Location = New System.Drawing.Point(234, 85)
        Me.lblGioiThieuQLCT.Name = "lblGioiThieuQLCT"
        Me.lblGioiThieuQLCT.Size = New System.Drawing.Size(399, 36)
        Me.lblGioiThieuQLCT.TabIndex = 6
        Me.lblGioiThieuQLCT.Text = "Giới thiệu"
        Me.lblGioiThieuQLCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBiaSachQLCT
        '
        Me.lblBiaSachQLCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBiaSachQLCT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblBiaSachQLCT.Location = New System.Drawing.Point(-1, 0)
        Me.lblBiaSachQLCT.Name = "lblBiaSachQLCT"
        Me.lblBiaSachQLCT.Size = New System.Drawing.Size(236, 36)
        Me.lblBiaSachQLCT.TabIndex = 5
        Me.lblBiaSachQLCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbHinhSachQLCT
        '
        Me.ptbHinhSachQLCT.BackgroundImage = CType(resources.GetObject("ptbHinhSachQLCT.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhSachQLCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhSachQLCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhSachQLCT.Location = New System.Drawing.Point(42, 36)
        Me.ptbHinhSachQLCT.Name = "ptbHinhSachQLCT"
        Me.ptbHinhSachQLCT.Size = New System.Drawing.Size(151, 189)
        Me.ptbHinhSachQLCT.TabIndex = 4
        Me.ptbHinhSachQLCT.TabStop = False
        '
        'frmQuanLyCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 372)
        Me.Controls.Add(Me.btnSuaHinhQLCT)
        Me.Controls.Add(Me.btnThoatQLCT)
        Me.Controls.Add(Me.btnLuuQLCT)
        Me.Controls.Add(Me.pnlKhungQL)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "frmQuanLyCT"
        Me.Text = "Quản lý chi tiết"
        Me.pnlKhungQL.ResumeLayout(False)
        Me.pnlKhungQL.PerformLayout()
        CType(Me.ptbHinhSachQLCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSuaHinhQLCT As System.Windows.Forms.Button
    Friend WithEvents btnThoatQLCT As System.Windows.Forms.Button
    Friend WithEvents btnLuuQLCT As System.Windows.Forms.Button
    Friend WithEvents pnlKhungQL As System.Windows.Forms.Panel
    Friend WithEvents txtNoiDungQLCT As System.Windows.Forms.RichTextBox
    Friend WithEvents lblGioiThieuQLCT As System.Windows.Forms.Label
    Friend WithEvents lblBiaSachQLCT As System.Windows.Forms.Label
    Friend WithEvents ptbHinhSachQLCT As System.Windows.Forms.PictureBox
    Friend WithEvents dtbNgayNhap As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbbTrangThai As System.Windows.Forms.ComboBox
    Friend WithEvents txtMaSachQLCT As System.Windows.Forms.TextBox
    Friend WithEvents lbMaSach As System.Windows.Forms.Label
    Friend WithEvents lbTenSach As System.Windows.Forms.Label
    Friend WithEvents txtTacGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSachQLCT As System.Windows.Forms.TextBox
    Friend WithEvents lbTrangThai As System.Windows.Forms.Label
    Friend WithEvents lbTacGia As System.Windows.Forms.Label
    Friend WithEvents lbNgay As System.Windows.Forms.Label
    Friend WithEvents cbbTL As System.Windows.Forms.ComboBox
    Friend WithEvents lblTheLoai As System.Windows.Forms.Label
End Class
