Imports System.Data.SqlClient
Imports System.Data
Public Class frmQuanLy
    'khai báo biến
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=DESKTOP-MD7TVGN;Initial Catalog=QL_SachThuVien;Integrated Security=True"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim ten As String
    Dim noidung As String
    Dim masach As String
    Dim trangthai As String
    Dim ngaydang As Date
    Dim tacgia As String
    Dim theloai As String
    Dim image As Image
    Dim fs As System.IO.FileStream
    'load dữ liệu khi mở form
    Private Sub frmQuanLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.Open()
        Dim sachmoi As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã sách', MATL as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả', NGAYDANG as 'Ngày đăng' , TRANGTHAI as 'Trạng thái' from SACH ", connect)
        dgvXemDanhSach.DataSource = db.DefaultView
        db.Clear()
        sachmoi.Fill(db)
        connect.Close()
        masach = dgvXemDanhSach.Item(0, 0).Value
        ten = dgvXemDanhSach.Item(2, 0).Value
        noidung = dgvXemDanhSach.Item(3, 0).Value
        tacgia = dgvXemDanhSach.Item(4, 0).Value
        ngaydang = dgvXemDanhSach.Item(5, 0).Value
        trangthai = dgvXemDanhSach.Item(6, 0).Value
        theloai = dgvXemDanhSach.Item(1, 0).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSachQL.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSachQL.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
    End Sub

    'lấy dữ liệu từ các dòng được chọn
    Private Sub dgvXemDanhSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemDanhSach.CellContentClick
        Dim click As Integer = dgvXemDanhSach.CurrentCell.RowIndex
        masach = dgvXemDanhSach.Item(0, click).Value
        ten = dgvXemDanhSach.Item(2, click).Value
        noidung = dgvXemDanhSach.Item(3, click).Value
        tacgia = dgvXemDanhSach.Item(4, click).Value
        ngaydang = dgvXemDanhSach.Item(5, click).Value
        trangthai = dgvXemDanhSach.Item(6, click).Value
        theloai = dgvXemDanhSach.Item(1, click).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSachQL.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSachQL.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
        click = Nothing
    End Sub
    'mở form cập nhật 
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        frmQuanLyCT.Close()
        frmQuanLyCT.Show()
        frmQuanLyCT.txtMaSachQLCT.Text = masach
        frmQuanLyCT.txtTenSachQLCT.Text = ten
        frmQuanLyCT.txtTacGia.Text = tacgia
        frmQuanLyCT.cbbTrangThai.Text = trangthai
        frmQuanLyCT.dtbNgayNhap.Text = ngaydang
        frmQuanLyCT.txtNoiDungQLCT.Text = noidung
        frmQuanLyCT.cbbTL.Text = theloai
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            frmQuanLyCT.ptbHinhSachQLCT.BackgroundImage = image
        Catch ex As Exception
            frmQuanLyCT.ptbHinhSachQLCT.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
    End Sub
    'xóa dữ liệu
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from CHITIETMUON where MASACH=@MS delete from SACH where MASACH=@MS"
        Dim delete As SqlCommand = New SqlCommand(delquery, connect)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        connect.Open()
        If resulft = Windows.Forms.DialogResult.Yes Then
            If System.IO.File.Exists(Application.StartupPath & "\data\hinh\" & masach & ".jpg") Then
                Kill(Application.StartupPath & "\data\hinh\" & masach & ".jpg")
            End If
            delete.Parameters.AddWithValue("@MS", masach)
            delete.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Xóa thành công")
        End If
        If connect.State = ConnectionState.Open Then
            connect.Close()
        End If
        'làm mới bảng
        frmQuanLy_Load(Nothing, Nothing)
    End Sub
    'tìm kiếm trong form
    Private Sub btnTimKiemTK_Click(sender As Object, e As EventArgs) Handles btnTimKiemTK.Click
        Dim sql As String = "select MASACH as 'Mã sách', MATL as 'Thể loại', TENSACH as 'Tên sách',  NOIDUNG as 'Nội dung',TACGIA as 'Tác giả', NGAYDANG as 'Ngày đăng' , TRANGTHAI as 'Trạng thái' from SACH where MASACH like  '%" & txtMaSachTK.Text & "%' and TENSACH like '%" & txtTenSachTK.Text & "%' and TACGIA like '%" & txtTacGia.Text & "%' "
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter(sql, connect)
        dgvXemDanhSach.DataSource = db.DefaultView
        db.Clear()
        timkiem.Fill(db)
        connect.Close()
        masach = dgvXemDanhSach.Item(0, 0).Value
        ten = dgvXemDanhSach.Item(2, 0).Value
        noidung = dgvXemDanhSach.Item(3, 0).Value
        tacgia = dgvXemDanhSach.Item(4, 0).Value
        ngaydang = dgvXemDanhSach.Item(5, 0).Value
        trangthai = dgvXemDanhSach.Item(6, 0).Value
        theloai = dgvXemDanhSach.Item(1, 0).Value
        Try
            fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & masach & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSachQL.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSachQL.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
    End Sub

    'click hiện frmthem
    Private Sub btnThemQL_Click(sender As Object, e As EventArgs) Handles btnThemQL.Click
        frmThem.Show()
    End Sub
    'click tắt form
    Private Sub btnThoatQL_Click(sender As Object, e As EventArgs) Handles btnThoatQL.Click
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmthongke.Show()
    End Sub
End Class