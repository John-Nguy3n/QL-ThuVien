Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmDangKiUser
    'khai báo biến
    Dim chuoiketnoi As String = "Data Source=DESKTOP-MD7TVGN;Initial Catalog=QL_SachThuVien;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "Insert Into TAIKHOAN values (@MAKH,@PASS) Insert Into KHACHHANG values (@MAKH,@TENKH,@NGAYSINH,@DIACHI,@SDT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtID.Focus()
            If txtID.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên đang nhập", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtPassword.Focus()
                If txtPassword.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Password", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenUser.Focus()
                    If txtTenUser.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập họ tên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSoDienThoai.Focus()
                        If txtSoDienThoai.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập sđt", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtDiaChi.Focus()
                            If txtDiaChi.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MAKH", txtID.Text)
                                save.Parameters.AddWithValue("@PASS", txtPassword.Text)
                                save.Parameters.AddWithValue("@TENKH", txtTenUser.Text)
                                save.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text)
                                save.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text)
                                save.Parameters.AddWithValue("@NGAYSINH", dtbNgaySinh.Text)
                                save.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Đăng kí thành công")
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class