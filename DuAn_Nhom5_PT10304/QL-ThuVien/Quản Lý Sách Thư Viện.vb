Imports System.Data.SqlClient
Imports System.Data
Public Class frmQuanLySachThuVien
    'khai báo biến
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=DESKTOP-MD7TVGN;Initial Catalog=QL_SachThuVien;Integrated Security=True"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim ten As String
    Dim noidung As String
    Dim masach As String
    Dim trangthai As String
    Dim image As Image
    Dim fs As System.IO.FileStream
    'load form
    Private Sub frmQuanLySachThuVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        masach = dgvXemDanhSach.Item(0, 0).Value
        ten = dgvXemDanhSach.Item(2, 0).Value
        noidung = dgvXemDanhSach.Item(3, 0).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSach.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSach.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
    End Sub
    'tùy chọn kiểu hiển thị dữ liệu
    Private Sub cbbDanhSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbDanhSach.SelectedIndexChanged
        If cbbDanhSach.Text = "Tất cả" Then
            connect.Open()
            Dim danhsach As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', THELOAI.TENTL as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả', NGAYDANG as 'Ngày đăng' , TRANGTHAI as 'Trạng thái' from SACH inner join THELOAI on SACH.MATL=THELOAI.MATL", connect)
            dgvXemDanhSach.DataSource = db.DefaultView
            db.Clear()
            danhsach.Fill(db)
            connect.Close()
        ElseIf cbbDanhSach.Text = "Sách mới" Then
            connect.Open()
            Dim sachmoi As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', THELOAI.TENTL as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả', NGAYDANG as 'Ngày đăng' , TRANGTHAI as 'Trạng thái'from SACH inner join THELOAI on SACH.MATL=THELOAI.MATL order by NGAYDANG ", connect)
            dgvXemDanhSach.DataSource = db.DefaultView
            db.Clear()
            sachmoi.Fill(db)
            connect.Close()
        End If
    End Sub
    'lấy dữ liệu từ các dòng được chọn
    Private Sub dgvXemDanhSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemDanhSach.CellContentClick
        Dim click As Integer = dgvXemDanhSach.CurrentCell.RowIndex
        masach = dgvXemDanhSach.Item(0, click).Value
        ten = dgvXemDanhSach.Item(2, click).Value
        noidung = dgvXemDanhSach.Item(3, click).Value
        trangthai = dgvXemDanhSach.Item(6, click).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSach.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSach.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
        click = Nothing
    End Sub
    'click mở form xem chi tiết
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Try
            frmChiTiet.Close()
            frmChiTiet.Show()
            frmChiTiet.lblTenSachND.Text = ten & " (" & trangthai & ")"
            frmChiTiet.lblMaSachND.Text = masach
            frmChiTiet.lblNoiDungND.Text = noidung
            Try
                fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
                image = System.Drawing.Image.FromStream(fs)
                fs.Close()
                frmChiTiet.ptbHinhSachND.BackgroundImage = image
            Catch ex As Exception
                frmChiTiet.ptbHinhSachND.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
            End Try
        Catch ex As Exception
            MessageBox.Show("Vui lòng chọn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' tìm kiếm trong form

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim sql As String = "select MASACH as 'Mã sách', THELOAI.TENTL as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả', NGAYDANG as 'Ngày đăng' , TRANGTHAI as 'Trạng thái' from SACH inner join THELOAI on SACH.MATL=THELOAI.MATL where MASACH like  '%" & txtMaSachTK.Text & "%' and TENSACH like '%" & txtTenSachTK.Text & "%' and TACGIA like '%" & txtTacGia.Text & "%' "
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter(sql, connect)
        dgvXemDanhSach.DataSource = db.DefaultView
        db.Clear()
        timkiem.Fill(db)
        connect.Close()
        masach = dgvXemDanhSach.Item(0, 0).Value
        ten = dgvXemDanhSach.Item(2, 0).Value
        noidung = dgvXemDanhSach.Item(3, 0).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSach.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSach.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
    End Sub

End Class
