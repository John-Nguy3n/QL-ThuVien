<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Me.btnThoatDN = New System.Windows.Forms.Button()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.lblTen2 = New System.Windows.Forms.Label()
        Me.lblTen1 = New System.Windows.Forms.Label()
        Me.btnDangKi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnThoatDN
        '
        Me.btnThoatDN.Location = New System.Drawing.Point(118, 177)
        Me.btnThoatDN.Name = "btnThoatDN"
        Me.btnThoatDN.Size = New System.Drawing.Size(87, 27)
        Me.btnThoatDN.TabIndex = 5
        Me.btnThoatDN.Text = "Thoát"
        Me.btnThoatDN.UseVisualStyleBackColor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(187, 139)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(87, 27)
        Me.btnDangNhap.TabIndex = 3
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(139, 76)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(135, 23)
        Me.txtMatKhau.TabIndex = 2
        Me.txtMatKhau.UseSystemPasswordChar = True
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Location = New System.Drawing.Point(139, 29)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(135, 23)
        Me.txtTenDangNhap.TabIndex = 1
        '
        'lblTen2
        '
        Me.lblTen2.AutoSize = True
        Me.lblTen2.Location = New System.Drawing.Point(27, 80)
        Me.lblTen2.Name = "lblTen2"
        Me.lblTen2.Size = New System.Drawing.Size(60, 15)
        Me.lblTen2.TabIndex = 11
        Me.lblTen2.Text = "Mật khẩu:"
        '
        'lblTen1
        '
        Me.lblTen1.AutoSize = True
        Me.lblTen1.Location = New System.Drawing.Point(27, 32)
        Me.lblTen1.Name = "lblTen1"
        Me.lblTen1.Size = New System.Drawing.Size(90, 15)
        Me.lblTen1.TabIndex = 10
        Me.lblTen1.Text = "Tên đăng nhập:"
        '
        'btnDangKi
        '
        Me.btnDangKi.Location = New System.Drawing.Point(53, 139)
        Me.btnDangKi.Name = "btnDangKi"
        Me.btnDangKi.Size = New System.Drawing.Size(87, 27)
        Me.btnDangKi.TabIndex = 4
        Me.btnDangKi.Text = "Đăng kí"
        Me.btnDangKi.UseVisualStyleBackColor = True
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 217)
        Me.Controls.Add(Me.btnDangKi)
        Me.Controls.Add(Me.btnThoatDN)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.lblTen2)
        Me.Controls.Add(Me.lblTen1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "frmDangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoatDN As System.Windows.Forms.Button
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents lblTen2 As System.Windows.Forms.Label
    Friend WithEvents lblTen1 As System.Windows.Forms.Label
    Friend WithEvents btnDangKi As System.Windows.Forms.Button
End Class
