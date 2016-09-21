Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmDangNhap
    'sự kiện click nút đăng nhập
    Dim chuoiketnoi As String = "Data Source=DESKTOP-MD7TVGN;Initial Catalog=QL_SachThuVien;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim bienbang As DataGridView = New DataGridView
    Private Function Checklogin(user As String, pass As String) As Boolean
        Dim sql As String = String.Format("select * from TAIKHOAN where ID='{0}' and PASS='{1}'", user, pass)
        Dim sqlquerry As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        Dim dtable As DataTable = New DataTable
        sqlquerry.fill(dtable)
        Return dtable.Rows.Count > 0
    End Function
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'kiểm tra mật khẩu và id

        If Checklogin(txtTenDangNhap.Text.ToLower, txtMatKhau.Text.ToLower) Then

            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmTrangChu.tsbTrangThai.Text = "Đăng xuất"

            If txtTenDangNhap.Text = "admin" Then
                frmTrangChu.tsbVaoThuVien.Enabled = True
                frmTrangChu.tsbQuanLy.Enabled = True
                Me.Close()
            Else
                frmTrangChu.tsbVaoThuVien.Enabled = True
                Me.Close()
            End If
        Else
            MessageBox.Show("Vui lòng nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnDangKi_Click(sender As Object, e As EventArgs) Handles btnDangKi.Click
        frmDangKiUser.Show()
        frmDangKiUser.Location = New Point(240, 150)
    End Sub
    'thoát form
    Private Sub btnThoatDN_Click(sender As Object, e As EventArgs) Handles btnThoatDN.Click
        Me.Close()
    End Sub


End Class