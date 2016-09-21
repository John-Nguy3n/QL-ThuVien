<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySachThuVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLySachThuVien))
        Me.btnXem = New System.Windows.Forms.Button()
        Me.grbTieuDe2 = New System.Windows.Forms.GroupBox()
        Me.dgvXemDanhSach = New System.Windows.Forms.DataGridView()
        Me.ptbHinhSach = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbbDanhSach = New System.Windows.Forms.ComboBox()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtMaSachTK = New System.Windows.Forms.TextBox()
        Me.txtTenSachTK = New System.Windows.Forms.TextBox()
        Me.lblTacGia = New System.Windows.Forms.Label()
        Me.lblMaSach = New System.Windows.Forms.Label()
        Me.lblTenSach = New System.Windows.Forms.Label()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        CType(Me.dgvXemDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(201, 368)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(113, 23)
        Me.btnXem.TabIndex = 13
        Me.btnXem.Text = "Xem Chi Tiết"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'grbTieuDe2
        '
        Me.grbTieuDe2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.grbTieuDe2.Location = New System.Drawing.Point(499, 59)
        Me.grbTieuDe2.Name = "grbTieuDe2"
        Me.grbTieuDe2.Size = New System.Drawing.Size(236, 19)
        Me.grbTieuDe2.TabIndex = 12
        Me.grbTieuDe2.TabStop = False
        Me.grbTieuDe2.Text = "Trang bìa"
        '
        'dgvXemDanhSach
        '
        Me.dgvXemDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemDanhSach.Location = New System.Drawing.Point(23, 120)
        Me.dgvXemDanhSach.Name = "dgvXemDanhSach"
        Me.dgvXemDanhSach.Size = New System.Drawing.Size(469, 229)
        Me.dgvXemDanhSach.TabIndex = 15
        '
        'ptbHinhSach
        '
        Me.ptbHinhSach.BackgroundImage = CType(resources.GetObject("ptbHinhSach.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhSach.Location = New System.Drawing.Point(526, 84)
        Me.ptbHinhSach.Name = "ptbHinhSach"
        Me.ptbHinhSach.Size = New System.Drawing.Size(196, 265)
        Me.ptbHinhSach.TabIndex = 14
        Me.ptbHinhSach.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 19)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'cbbDanhSach
        '
        Me.cbbDanhSach.FormattingEnabled = True
        Me.cbbDanhSach.Items.AddRange(New Object() {"Tất cả", "Sách mới"})
        Me.cbbDanhSach.Location = New System.Drawing.Point(23, 84)
        Me.cbbDanhSach.Name = "cbbDanhSach"
        Me.cbbDanhSach.Size = New System.Drawing.Size(121, 23)
        Me.cbbDanhSach.TabIndex = 20
        Me.cbbDanhSach.Text = "Tất cả"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(455, 21)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(132, 23)
        Me.txtTacGia.TabIndex = 27
        '
        'txtMaSachTK
        '
        Me.txtMaSachTK.Location = New System.Drawing.Point(299, 21)
        Me.txtMaSachTK.Name = "txtMaSachTK"
        Me.txtMaSachTK.Size = New System.Drawing.Size(80, 23)
        Me.txtMaSachTK.TabIndex = 24
        '
        'txtTenSachTK
        '
        Me.txtTenSachTK.Location = New System.Drawing.Point(86, 21)
        Me.txtTenSachTK.Name = "txtTenSachTK"
        Me.txtTenSachTK.Size = New System.Drawing.Size(142, 23)
        Me.txtTenSachTK.TabIndex = 25
        '
        'lblTacGia
        '
        Me.lblTacGia.AutoSize = True
        Me.lblTacGia.Location = New System.Drawing.Point(401, 24)
        Me.lblTacGia.Name = "lblTacGia"
        Me.lblTacGia.Size = New System.Drawing.Size(48, 15)
        Me.lblTacGia.TabIndex = 21
        Me.lblTacGia.Text = "Tác giả:"
        '
        'lblMaSach
        '
        Me.lblMaSach.AutoSize = True
        Me.lblMaSach.Location = New System.Drawing.Point(244, 24)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(54, 15)
        Me.lblMaSach.TabIndex = 22
        Me.lblMaSach.Text = "Mã sách:"
        '
        'lblTenSach
        '
        Me.lblTenSach.AutoSize = True
        Me.lblTenSach.Location = New System.Drawing.Point(23, 25)
        Me.lblTenSach.Name = "lblTenSach"
        Me.lblTenSach.Size = New System.Drawing.Size(57, 15)
        Me.lblTenSach.TabIndex = 23
        Me.lblTenSach.Text = "Tên sách:"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Image = Global.QuanLySachThuVien1.My.Resources.Resources.Tim_kiem
        Me.btnTimKiem.Location = New System.Drawing.Point(593, 16)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(33, 33)
        Me.btnTimKiem.TabIndex = 28
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'frmQuanLySachThuVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(750, 415)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.txtMaSachTK)
        Me.Controls.Add(Me.txtTenSachTK)
        Me.Controls.Add(Me.lblTacGia)
        Me.Controls.Add(Me.lblMaSach)
        Me.Controls.Add(Me.lblTenSach)
        Me.Controls.Add(Me.cbbDanhSach)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvXemDanhSach)
        Me.Controls.Add(Me.ptbHinhSach)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.grbTieuDe2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuanLySachThuVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Quản Lý Sách Thư Viện"
        CType(Me.dgvXemDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents grbTieuDe2 As System.Windows.Forms.GroupBox
    Friend WithEvents ptbHinhSach As System.Windows.Forms.PictureBox
    Friend WithEvents dgvXemDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbbDanhSach As System.Windows.Forms.ComboBox
    Friend WithEvents txtTacGia As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSachTK As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSachTK As System.Windows.Forms.TextBox
    Friend WithEvents lblTacGia As System.Windows.Forms.Label
    Friend WithEvents lblMaSach As System.Windows.Forms.Label
    Friend WithEvents lblTenSach As System.Windows.Forms.Label
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button

End Class
