Imports System.Data.SqlClient
Imports System.Data
Public Class frmTimKiem
    'khai báo biến
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=HAINGUYEN;Initial Catalog=QL_SachThuVien;Integrated Security=True"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim ten As String
    Dim noidung As String
    Dim masach As String
    Dim trangthai As String
    Dim ngaydang As Date
    Dim tacgia As String
    Dim theloai As String
    Dim fs As System.IO.FileStream
    Dim image As Image



    Private Sub btnTimKiemTK_Click(sender As Object, e As EventArgs) Handles btnTimKiemTK.Click
        '   Try
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
            Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSachTK.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSachTK.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
        '  Catch ex As Exception
        '   MessageBox.Show("Không tìm thấy dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '   txtMaSachTK.Clear()
        '   txtTacGia.Clear()
        '   txtTenSachTK.Clear()
        '   End Try
    End Sub

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
                frmChiTiet.ptbHinhSachND.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
            End Try
        Catch ex As Exception
            MessageBox.Show("Vui lòng chọn sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
            Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            ptbHinhSachTK.BackgroundImage = image
        Catch ex As Exception
            ptbHinhSachTK.BackgroundImage = image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
        End Try
        click = Nothing
    End Sub

    Private Sub btnThoatTK_Click(sender As Object, e As EventArgs) Handles btnThoatTK.Click
        Me.Close()
    End Sub
End Class