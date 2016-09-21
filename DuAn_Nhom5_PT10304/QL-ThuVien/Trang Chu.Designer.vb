<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrangChu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrangChu))
        Me.tosMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbVaoThuVien = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbQuanLy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbThoat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTrangThai = New System.Windows.Forms.ToolStripButton()
        Me.tosMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tosMenu
        '
        Me.tosMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbVaoThuVien, Me.ToolStripSeparator2, Me.tsbQuanLy, Me.ToolStripSeparator3, Me.tsbThoat, Me.ToolStripSeparator4, Me.tsbTrangThai})
        Me.tosMenu.Location = New System.Drawing.Point(0, 0)
        Me.tosMenu.Name = "tosMenu"
        Me.tosMenu.Size = New System.Drawing.Size(756, 25)
        Me.tosMenu.TabIndex = 2
        Me.tosMenu.Text = "ToolStrip1"
        '
        'tsbVaoThuVien
        '
        Me.tsbVaoThuVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbVaoThuVien.Image = CType(resources.GetObject("tsbVaoThuVien.Image"), System.Drawing.Image)
        Me.tsbVaoThuVien.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVaoThuVien.Name = "tsbVaoThuVien"
        Me.tsbVaoThuVien.Size = New System.Drawing.Size(81, 22)
        Me.tsbVaoThuVien.Text = "Vào Thư Viện"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbQuanLy
        '
        Me.tsbQuanLy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbQuanLy.Image = CType(resources.GetObject("tsbQuanLy.Image"), System.Drawing.Image)
        Me.tsbQuanLy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuanLy.Name = "tsbQuanLy"
        Me.tsbQuanLy.Size = New System.Drawing.Size(55, 22)
        Me.tsbQuanLy.Text = "Quản Lý"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbThoat
        '
        Me.tsbThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbThoat.Image = CType(resources.GetObject("tsbThoat.Image"), System.Drawing.Image)
        Me.tsbThoat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbThoat.Name = "tsbThoat"
        Me.tsbThoat.Size = New System.Drawing.Size(42, 22)
        Me.tsbThoat.Text = "Thoát"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbTrangThai
        '
        Me.tsbTrangThai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbTrangThai.Image = CType(resources.GetObject("tsbTrangThai.Image"), System.Drawing.Image)
        Me.tsbTrangThai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTrangThai.Name = "tsbTrangThai"
        Me.tsbTrangThai.Size = New System.Drawing.Size(23, 22)
        '
        'frmTrangChu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLySachThuVien1.My.Resources.Resources.ung_dung_thiet_bi_ma_vach_vao_thu_vien
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(756, 448)
        Me.Controls.Add(Me.tosMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "frmTrangChu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trang chủ"
        Me.tosMenu.ResumeLayout(False)
        Me.tosMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tosMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbThoat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbVaoThuVien As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbQuanLy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbTrangThai As System.Windows.Forms.ToolStripButton
End Class
