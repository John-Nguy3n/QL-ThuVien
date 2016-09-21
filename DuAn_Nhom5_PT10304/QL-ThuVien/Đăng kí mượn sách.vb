Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmDangKiMuonSach
    'khai báo biến
    Dim chuoiketnoi As String = "Data Source=DESKTOP-MD7TVGN;Initial Catalog=QL_SachThuVien;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    'sự kiện load form
    Private Sub frmDangKi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'khai báo biến
        Dim chuoi As String = "0123456789"
        Dim dodaichuoi As Integer = Len(chuoi)
        Dim vitrilaykitu As Integer
        Dim sokitu As Integer
        Dim kytu As String
        Randomize()
        'tạo mã khách hàng ngẫu nhiên
        For sokitu = 0 To 4
            vitrilaykitu = Int(dodaichuoi * Rnd() + 1)
            kytu = Mid(chuoi, vitrilaykitu, 1)
            txtMaKH.Text += kytu
        Next
        'tạo mã hóa đơn ngẫu nhiên
        For sokitu = 0 To 4
            vitrilaykitu = Int(dodaichuoi * Rnd() + 1)
            kytu = Mid(chuoi, vitrilaykitu, 1)
            txtHD.Text += kytu
        Next
        'hiển thị dữ liệu của sách được chọn
        lblHienThiMaSach.Text = frmChiTiet.lblMaSachND.Text
        lblHienThiTenSachDK.Text = frmChiTiet.lblTenSachND.Text
        dtbNgayDK.Value = Today
        dtbNgayTra.Value = dtbNgayDK.Value.AddDays(2)
    End Sub
    ' xác nhận đăng kí
    Private Sub btnXacNhanDK_Click(sender As Object, e As EventArgs) Handles btnXacNhanDK.Click
        'khai báo biến
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "Insert Into KHACHHANG values (@MAKH,@TENKH,@NGAYSINH,@DIACHI,@SDT) Insert Into HOADONMUON values (@MAHD,@MAKH,@NGAYLAP) Insert Into CHITIETMUON values (@MAHD,@MASACH,@NGAYMUON,@NGAYTRA) "
        Dim query2 As String = "Insert Into HOADONMUON values (@MAHD,@MAKH,@NGAYLAP) Insert Into CHITIETMUON values (@MAHD,@MASACH,@NGAYMUON,@NGAYTRA) "
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Dim save2 As SqlCommand = New SqlCommand(query2, conn)
        conn.Open()
        'áp dụng cho khách hàng đã có mã khách hàng
        If cbMaKH.Checked = True Then
            Try
                If txtMaKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMaKH.Focus()
                    If txtHD.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        save2.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                        save2.Parameters.AddWithValue("@MAHD", txtHD.Text)
                        save2.Parameters.AddWithValue("@NGAYLAP", dtbNgayDK.Text)
                        save2.Parameters.AddWithValue("@MASACH", lblHienThiMaSach.Text)
                        save2.Parameters.AddWithValue("@NGAYMUON", dtbNgayDK.Text)
                        save2.Parameters.AddWithValue("@NGAYTRA", dtbNgayTra.Text)
                        save2.ExecuteNonQuery()
                        conn.Close() 'đóng kết nối
                        MessageBox.Show("Đăng kí thành công")
                        txtHD.Text = "HD"
                        txtMaKH.Text = "KH"
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Mã khách hàng không đúng hoặc không tồn tại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtHD.Text = "HD"
                txtMaKH.Text = "KH"
            End Try
            Me.Close()
        Else         'áp dụng cho khách hàng lần đầu đăng kí
            Try
                txtHoTen.Focus()
                If txtHoTen.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtHoTen.Focus()
                    If txtDiaChi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDiaChi.Focus()
                        If txtSoDienThoai.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập SĐT", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSoDienThoai.Focus()
                            If txtMaKH.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtMaKH.Focus()
                                If txtHD.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                    save.Parameters.AddWithValue("@TENKH", txtHoTen.Text)
                                    save.Parameters.AddWithValue("@NGAYSINH", dtbNgaySinh.Text)
                                    save.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text)
                                    save.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text)
                                    save.Parameters.AddWithValue("@MAHD", txtHD.Text)
                                    save.Parameters.AddWithValue("@NGAYLAP", dtbNgayDK.Text)
                                    save.Parameters.AddWithValue("@MASACH", lblHienThiMaSach.Text)
                                    save.Parameters.AddWithValue("@NGAYMUON", dtbNgayDK.Text)
                                    save.Parameters.AddWithValue("@NGAYTRA", dtbNgayTra.Text)
                                    save.ExecuteNonQuery()
                                    conn.Close() 'đóng kết nối
                                    MessageBox.Show("Đăng kí thành công")
                                    txtHD.Text = "HD"
                                    txtMaKH.Text = "KH"
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtHD.Text = "HD"
                txtMaKH.Text = "KH"
            End Try
            Me.Close()
        End If
    End Sub
    'xóa nhập lại
    Private Sub btnNhapLaiDK_Click(sender As Object, e As EventArgs) Handles btnNhapLaiDK.Click
        txtHoTen.Clear()
        txtSoDienThoai.Clear()
        txtDiaChi.Clear()
    End Sub
    'mở khung nhập liệu cho textbox mã khách hàng
    Private Sub cbMaKH_CheckedChanged(sender As Object, e As EventArgs) Handles cbMaKH.CheckedChanged
        If cbMaKH.Checked = True Then
            txtMaKH.ReadOnly = False
        Else
            txtMaKH.ReadOnly = True
        End If
    End Sub
    'kiểm tra số ngày đăng kí sách
    Private Sub dtbNgayTra_ValueChanged(sender As Object, e As EventArgs) Handles dtbNgayTra.ValueChanged
        If dtbNgayTra.Value < dtbNgayDK.Value Or dtbNgayTra.Value = dtbNgayDK.Value Then
            MessageBox.Show("Ngày trả sách phải sau ngày mượn sách ít nhất 1 ngày", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            dtbNgayTra.Value = dtbNgayDK.Value.AddDays(2)
        End If
    End Sub
End Class