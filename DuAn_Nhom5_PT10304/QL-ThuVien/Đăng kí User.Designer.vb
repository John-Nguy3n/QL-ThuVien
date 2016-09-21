<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangKiUser
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
        Me.dtbNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.txtTenUser = New System.Windows.Forms.TextBox()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.lblSoDienThoai = New System.Windows.Forms.Label()
        Me.lblTenUser = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnXacNhan = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtbNgaySinh
        '
        Me.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbNgaySinh.Location = New System.Drawing.Point(107, 270)
        Me.dtbNgaySinh.Name = "dtbNgaySinh"
        Me.dtbNgaySinh.Size = New System.Drawing.Size(239, 20)
        Me.dtbNgaySinh.TabIndex = 6
        Me.dtbNgaySinh.Value = New Date(2016, 8, 14, 0, 0, 0, 0)
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(38, 276)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(57, 13)
        Me.lbNgaySinh.TabIndex = 30
        Me.lbNgaySinh.Text = "Ngày sinh:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(107, 221)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(239, 20)
        Me.txtDiaChi.TabIndex = 5
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(107, 171)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(239, 20)
        Me.txtSoDienThoai.TabIndex = 4
        '
        'txtTenUser
        '
        Me.txtTenUser.Location = New System.Drawing.Point(107, 124)
        Me.txtTenUser.Name = "txtTenUser"
        Me.txtTenUser.Size = New System.Drawing.Size(239, 20)
        Me.txtTenUser.TabIndex = 3
        '
        'lblDiachi
        '
        Me.lblDiachi.AutoSize = True
        Me.lblDiachi.Location = New System.Drawing.Point(57, 224)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(43, 13)
        Me.lblDiachi.TabIndex = 24
        Me.lblDiachi.Text = "Địa chỉ:"
        '
        'lblSoDienThoai
        '
        Me.lblSoDienThoai.AutoSize = True
        Me.lblSoDienThoai.Location = New System.Drawing.Point(24, 174)
        Me.lblSoDienThoai.Name = "lblSoDienThoai"
        Me.lblSoDienThoai.Size = New System.Drawing.Size(73, 13)
        Me.lblSoDienThoai.TabIndex = 25
        Me.lblSoDienThoai.Text = "Số điện thoại:"
        '
        'lblTenUser
        '
        Me.lblTenUser.AutoSize = True
        Me.lblTenUser.Location = New System.Drawing.Point(40, 127)
        Me.lblTenUser.Name = "lblTenUser"
        Me.lblTenUser.Size = New System.Drawing.Size(57, 13)
        Me.lblTenUser.TabIndex = 26
        Me.lblTenUser.Text = "Họ và tên:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(21, 39)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(76, 13)
        Me.lblID.TabIndex = 26
        Me.lblID.Text = "Tên tài khoản:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(38, 86)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(55, 13)
        Me.lblPassword.TabIndex = 25
        Me.lblPassword.Text = "Mật khẩu:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(110, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(239, 20)
        Me.txtID.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(110, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(239, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Location = New System.Drawing.Point(127, 333)
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(75, 23)
        Me.btnXacNhan.TabIndex = 7
        Me.btnXacNhan.Text = "Xác nhận"
        Me.btnXacNhan.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(232, 333)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmDangKiUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 380)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXacNhan)
        Me.Controls.Add(Me.dtbNgaySinh)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtTenUser)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblSoDienThoai)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTenUser)
        Me.Name = "frmDangKiUser"
        Me.Text = "Đăng kí"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtbNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbNgaySinh As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtSoDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtTenUser As System.Windows.Forms.TextBox
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents lblSoDienThoai As System.Windows.Forms.Label
    Friend WithEvents lblTenUser As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnXacNhan As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
End Class
