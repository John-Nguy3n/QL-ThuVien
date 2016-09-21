Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanLyCT
    'khai báo biến
    Dim noiluu As String = Application.StartupPath & "\data\hinh\"
    Dim tenhinh As String
    Dim duongdan As String
    Dim chuoiketnoi As String = "Data Source=DESKTOP-MD7TVGN;Initial Catalog=QL_SachThuVien;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    Dim image As Image
    Dim fs As System.IO.FileStream

    'load form ngày cập nhật là ngày hiện tại
    Private Sub frmQuanLyCT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtbNgayNhap.Value = Today
    End Sub
    'nút cập nhật hình ảnh
    Private Sub btnSuaHinhQLCT_Click(sender As Object, e As EventArgs) Handles btnSuaHinhQLCT.Click
        'khai báo biến dialog
        Dim hinhanh As New OpenFileDialog
        'điều kiện để lấy file
        If hinhanh.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            duongdan = hinhanh.FileName
            If duongdan.EndsWith(".jpg") Then
                tenhinh = hinhanh.FileName.Substring(hinhanh.FileName.LastIndexOf("\") + 1)
            Else
                MessageBox.Show("Chỉ cho phép file JPG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                hinhanh.FileName = Nothing
                duongdan = Nothing
            End If
        End If
        fs = New System.IO.FileStream(duongdan, IO.FileMode.Open, IO.FileAccess.Read)
        image = System.Drawing.Image.FromStream(fs)
        fs.Close()
        ptbHinhSachQLCT.BackgroundImage = image
    End Sub
    ' click nút Lưu để cập nhật dữ liệu
    Private Sub btnLuuQLCT_Click(sender As Object, e As EventArgs) Handles btnLuuQLCT.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SACH set MASACH=@MS, MATL=@TL, TENSACH=@TENSACH, TACGIA=@TENTG, NOIDUNG=@ND, NGAYDANG=@NGAY , TRANGTHAI=@TRANGTHAI where MASACH=@MS"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaSachQLCT.Focus()
            If txtMaSachQLCT.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaSachQLCT.Focus()
                If txtTacGia.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên tác giả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTacGia.Focus()
                    If txtTenSachQLCT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập tên sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtTenSachQLCT.Focus()
                        If txtNoiDungQLCT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập nội dung", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            addupdate.Parameters.AddWithValue("@MS", txtMaSachQLCT.Text)
                            addupdate.Parameters.AddWithValue("@TL", cbbTL.Text)
                            addupdate.Parameters.AddWithValue("@TENSACH", txtTenSachQLCT.Text)
                            addupdate.Parameters.AddWithValue("@TENTG", txtTacGia.Text)
                            addupdate.Parameters.AddWithValue("@ND", txtNoiDungQLCT.Text)
                            addupdate.Parameters.AddWithValue("@NGAY", dtbNgayNhap.Text)
                            addupdate.Parameters.AddWithValue("@TRANGTHAI", cbbTrangThai.Text)
                            addupdate.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            'copy file hình vào data
                            Try 'nếu không lựa chọn hình ảnh thì bỏ qua
                                If System.IO.File.Exists(noiluu & txtMaSachQLCT.Text & ".jpg") Then
                                    Kill(noiluu & txtMaSachQLCT.Text & ".jpg")
                                    FileCopy(duongdan, noiluu & tenhinh & "1")
                                    Rename(noiluu & tenhinh & "1", noiluu & txtMaSachQLCT.Text & ".jpg")
                                Else
                                    FileCopy(duongdan, noiluu & tenhinh & "1")
                                    Rename(noiluu & tenhinh & "1", noiluu & txtMaSachQLCT.Text & ".jpg")
                                End If
                            Catch ex As Exception
                            End Try
                            MessageBox.Show("Cập nhật thành công")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        Me.Close()
        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        conn.Open()
        Dim sachmoi As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', MATL as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả', NGAYDANG as 'Ngày đăng' , TRANGTHAI as 'Trạng thái' from SACH", conn)
        frmQuanLy.dgvXemDanhSach.DataSource = db.DefaultView
        db.Clear()
        sachmoi.Fill(db)
        conn.Close()
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & frmQuanLy.dgvXemDanhSach.Item(0, 0).Value & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            frmQuanLy.ptbHinhSachQL.BackgroundImage = image
        Catch ex As Exception
            frmQuanLy.ptbHinhSachQL.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub
    'nút thoát form
    Private Sub btnThoatQLCT_Click(sender As Object, e As EventArgs) Handles btnThoatQLCT.Click
        Me.Close()
    End Sub


End Class



