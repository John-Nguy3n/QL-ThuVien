<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiTiet))
        Me.btnThoatND = New System.Windows.Forms.Button()
        Me.btnMuonSachND = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNoiDungND = New System.Windows.Forms.Label()
        Me.lblGioiThieuND = New System.Windows.Forms.Label()
        Me.lblMaSachND = New System.Windows.Forms.Label()
        Me.lblBiaSachND = New System.Windows.Forms.Label()
        Me.ptbHinhSachND = New System.Windows.Forms.PictureBox()
        Me.lblTenSachND = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ptbHinhSachND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoatND
        '
        Me.btnThoatND.Location = New System.Drawing.Point(475, 295)
        Me.btnThoatND.Name = "btnThoatND"
        Me.btnThoatND.Size = New System.Drawing.Size(87, 23)
        Me.btnThoatND.TabIndex = 14
        Me.btnThoatND.Text = "Thoát"
        Me.btnThoatND.UseVisualStyleBackColor = True
        '
        'btnMuonSachND
        '
        Me.btnMuonSachND.Location = New System.Drawing.Point(341, 295)
        Me.btnMuonSachND.Name = "btnMuonSachND"
        Me.btnMuonSachND.Size = New System.Drawing.Size(87, 23)
        Me.btnMuonSachND.TabIndex = 13
        Me.btnMuonSachND.Text = "Mượn sách"
        Me.btnMuonSachND.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblNoiDungND)
        Me.Panel1.Controls.Add(Me.lblGioiThieuND)
        Me.Panel1.Controls.Add(Me.lblMaSachND)
        Me.Panel1.Controls.Add(Me.lblBiaSachND)
        Me.Panel1.Controls.Add(Me.ptbHinhSachND)
        Me.Panel1.Controls.Add(Me.lblTenSachND)
        Me.Panel1.Location = New System.Drawing.Point(21, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 264)
        Me.Panel1.TabIndex = 12
        '
        'lblNoiDungND
        '
        Me.lblNoiDungND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoiDungND.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblNoiDungND.Location = New System.Drawing.Point(234, 72)
        Me.lblNoiDungND.Name = "lblNoiDungND"
        Me.lblNoiDungND.Size = New System.Drawing.Size(399, 190)
        Me.lblNoiDungND.TabIndex = 7
        '
        'lblGioiThieuND
        '
        Me.lblGioiThieuND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGioiThieuND.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblGioiThieuND.Location = New System.Drawing.Point(234, 36)
        Me.lblGioiThieuND.Name = "lblGioiThieuND"
        Me.lblGioiThieuND.Size = New System.Drawing.Size(399, 36)
        Me.lblGioiThieuND.TabIndex = 6
        Me.lblGioiThieuND.Text = "Giới thiệu"
        Me.lblGioiThieuND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaSachND
        '
        Me.lblMaSachND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaSachND.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaSachND.Location = New System.Drawing.Point(-1, 226)
        Me.lblMaSachND.Name = "lblMaSachND"
        Me.lblMaSachND.Size = New System.Drawing.Size(236, 36)
        Me.lblMaSachND.TabIndex = 5
        Me.lblMaSachND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBiaSachND
        '
        Me.lblBiaSachND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBiaSachND.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblBiaSachND.Location = New System.Drawing.Point(-1, 0)
        Me.lblBiaSachND.Name = "lblBiaSachND"
        Me.lblBiaSachND.Size = New System.Drawing.Size(236, 36)
        Me.lblBiaSachND.TabIndex = 5
        Me.lblBiaSachND.Text = "Bìa sách"
        Me.lblBiaSachND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbHinhSachND
        '
        Me.ptbHinhSachND.BackgroundImage = CType(resources.GetObject("ptbHinhSachND.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhSachND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhSachND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhSachND.Location = New System.Drawing.Point(42, 36)
        Me.ptbHinhSachND.Name = "ptbHinhSachND"
        Me.ptbHinhSachND.Size = New System.Drawing.Size(152, 187)
        Me.ptbHinhSachND.TabIndex = 4
        Me.ptbHinhSachND.TabStop = False
        '
        'lblTenSachND
        '
        Me.lblTenSachND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTenSachND.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenSachND.Location = New System.Drawing.Point(234, 0)
        Me.lblTenSachND.Name = "lblTenSachND"
        Me.lblTenSachND.Size = New System.Drawing.Size(399, 36)
        Me.lblTenSachND.TabIndex = 0
        Me.lblTenSachND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 330)
        Me.Controls.Add(Me.btnThoatND)
        Me.Controls.Add(Me.btnMuonSachND)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "frmChiTiet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Chi tiết sách"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ptbHinhSachND, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnThoatND As System.Windows.Forms.Button
    Friend WithEvents btnMuonSachND As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNoiDungND As System.Windows.Forms.Label
    Friend WithEvents lblGioiThieuND As System.Windows.Forms.Label
    Friend WithEvents lblMaSachND As System.Windows.Forms.Label
    Friend WithEvents lblBiaSachND As System.Windows.Forms.Label
    Friend WithEvents ptbHinhSachND As System.Windows.Forms.PictureBox
    Friend WithEvents lblTenSachND As System.Windows.Forms.Label
End Class
