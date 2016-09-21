Public Class frmTrangChu

    Private Sub tsbVaoThuVien_Click(sender As Object, e As EventArgs) Handles tsbVaoThuVien.Click
        frmQuanLySachThuVien.MdiParent = Me
        frmQuanLySachThuVien.Show()
        frmQuanLySachThuVien.BringToFront()
        frmQuanLy.Close()
        frmTimKiem.Close()
    End Sub

    Private Sub btnQuanLy_Click(sender As Object, e As EventArgs) Handles tsbQuanLy.Click
        frmQuanLy.MdiParent = Me
        frmQuanLy.Show()
        frmQuanLy.BringToFront()
        frmQuanLySachThuVien.Close()
        frmTimKiem.Close()
    End Sub

    Private Sub tsbTimKiem_Click(sender As Object, e As EventArgs)
        frmTimKiem.MdiParent = Me
        frmTimKiem.Show()
        frmTimKiem.BringToFront()
        frmQuanLySachThuVien.Close()
        frmQuanLy.Close()
    End Sub

    Private Sub tsbThoat_Click(sender As Object, e As EventArgs) Handles tsbThoat.Click
        Me.Close()
    End Sub

    Private Sub tsbTrangThai_Click(sender As Object, e As EventArgs) Handles tsbTrangThai.Click
        If tsbTrangThai.Text = "Đăng nhập" Then
            frmDangNhap.MdiParent = Me
            frmDangNhap.Show()
            frmDangNhap.BringToFront()
            Dim nv = frmDangNhap
            nv.Location = New Point(200, 70)
            tsbVaoThuVien.Enabled = False
            tsbQuanLy.Enabled = False
        Else
            tsbTrangThai.Text = "Đăng nhập"
            frmQuanLySachThuVien.Close()
            frmQuanLy.Close()
            tsbVaoThuVien.Enabled = False
            tsbQuanLy.Enabled = False
        End If
    End Sub

    Private Sub frmTrangChu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsbTrangThai.Text = "Đăng nhập"
        frmDangNhap.MdiParent = Me
        frmDangNhap.Show()
        frmDangNhap.BringToFront()
        Dim nv = frmDangNhap
        nv.Location = New Point(200, 70)
        tsbVaoThuVien.Enabled = False
        tsbQuanLy.Enabled = False
    End Sub
End Class