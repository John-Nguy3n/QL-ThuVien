Create database QL_SachThuVien
USE [QL_SachThuVien]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 08/14/2016 21:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MATL] [varchar](10) NOT NULL,
	[TENTL] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'SDSXH', N'Đời sống xã hội')
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'SGT', N'Giáo trình')
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'SKD', N'Kinh doanh - Đầu tư')
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'SKH', N'Khoa học')
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'STT', N'Tiểu thuyết')
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 08/14/2016 21:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[ID] [varchar](15) NOT NULL,
	[PASS] [varchar](24) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TAIKHOAN] ([ID], [PASS]) VALUES (N'admin', N'admin@123')
INSERT [dbo].[TAIKHOAN] ([ID], [PASS]) VALUES (N'nn1994', N'8632522')
/****** Object:  Table [dbo].[SACH]    Script Date: 08/14/2016 21:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MASACH] [varchar](15) NOT NULL,
	[MATL] [varchar](10) NULL,
	[TENSACH] [nvarchar](40) NULL,
	[NOIDUNG] [nvarchar](255) NULL,
	[TACGIA] [nvarchar](50) NULL,
	[NGAYDANG] [smalldatetime] NULL,
	[TRANGTHAI] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SACH] ([MASACH], [MATL], [TENSACH], [NOIDUNG], [TACGIA], [NGAYDANG], [TRANGTHAI]) VALUES (N'TSV004', N'SDSXH', N'Đắc Nhân Tâm', N'Cuốn Sách Hay Nhất Của Mọi Thời Đại Đưa Bạn Đến Thành Công Đắc nhân tâm – How to win friends and Influence People của Dale Carnegie là quyển sách nổi tiếng nhất, bán chạy nhất và có tầm ảnh hưởng nhất của mọi thời đại. Tác phẩm đã được ... ', N'Dale Carnegie', CAST(0xA4320000 AS SmallDateTime), N'Còn sách')
INSERT [dbo].[SACH] ([MASACH], [MATL], [TENSACH], [NOIDUNG], [TACGIA], [NGAYDANG], [TRANGTHAI]) VALUES (N'TSV005', N'SDSXH', N'Tư Duy Kẻ Lập Dị', N'Một cuốn sách siêu hài hước hướng dẫn bạn:- Học cách nói tôi không biết.- Gạt phăng đạo đức của bạn sang một bên.- Suy nghĩ giản đơn như một đứa trẻ.- Thuyết phục những người không muốn được thuyết phục.- Buông bỏ những khó khăn ngày ... ', N'Stephen J. Dubner', CAST(0xA48C0000 AS SmallDateTime), N'Còn sách')
INSERT [dbo].[SACH] ([MASACH], [MATL], [TENSACH], [NOIDUNG], [TACGIA], [NGAYDANG], [TRANGTHAI]) VALUES (N'TVS001', N'STT', N'Nhà Giả Kim', N'Tất cả những trải nghiệm trong chuyến phiêu du theo đuổi vận mệnh của mình đã giúp Santiago thấu hiểu được ý nghĩa sâu xa nhất của hạnh phúc, hòa hợp với vũ trụ và con người.Tiểu thuyết Nhà giả kim của Paulo Coelho như một câu chuyện cổ tích ...', N'Paulo Coelho', CAST(0xA6460000 AS SmallDateTime), N'Còn sách')
INSERT [dbo].[SACH] ([MASACH], [MATL], [TENSACH], [NOIDUNG], [TACGIA], [NGAYDANG], [TRANGTHAI]) VALUES (N'TVS002', N'SGT', N'Photoshop', N'Cuốn sách này được biên soạn kiểu “cầm tay chỉ việc”, các bài tập đều có các hướng dẫn từng bước minh họa bằng hình để các bạn hiểu và khai thác Photoshop ở mức độ nâng cao, tiết kiệm nhiều thời gian khi học. Đi kèm với sách là các đĩa ...', N'Phạm Quang Huy', CAST(0xA51C0000 AS SmallDateTime), N'Còn sách')
INSERT [dbo].[SACH] ([MASACH], [MATL], [TENSACH], [NOIDUNG], [TACGIA], [NGAYDANG], [TRANGTHAI]) VALUES (N'TVS003', N'SKH', N'Horrible Science', N'Đây là tập tiếp theo trong series Horrible science rất được các bạn đọc yêu thích. Tập sách về các loài côn trùng vẫn sống quanh ta nhưng có bao điều thú vị chưa được biết đến như: Con sên làm gì với chất nhầy của nó? Tại sao ruồi lại ói vào ...', N'Nick Arnold', CAST(0xA52B0000 AS SmallDateTime), N'Còn sách')
INSERT [dbo].[SACH] ([MASACH], [MATL], [TENSACH], [NOIDUNG], [TACGIA], [NGAYDANG], [TRANGTHAI]) VALUES (N'TVS006', N'STT', N'Thời Thơ Ấu', N'Macxim Gorki (1868-1936) là nhà văn lớn của nước Nga, mở đầu trào lưu văn học hiện thực xã hội chủ nghĩa. Ông còn là nhà hoạt động văn hóa - xã hội nổi tiếng thế giới. "Đọc “Thời thơ ấu” các em sẽ thấy rằng tôi hoàn toàn là một con người ...', N'Maxim Gorky', CAST(0xA5780000 AS SmallDateTime), N'Còn sách')
INSERT [dbo].[SACH] ([MASACH], [MATL], [TENSACH], [NOIDUNG], [TACGIA], [NGAYDANG], [TRANGTHAI]) VALUES (N'TVS007', N'SKD', N'Dám Nghĩ Lớn!', N'The Magic Of Thinking Big - Dám Nghĩ Lớn! Dám Nghĩ Lớn! - tác phẩm nổi tiếng thế giới về những ý tưởng và phương pháp tư duy độc đáo và hiệu quả đã làm thay đổi một cách kỳ diệu cuộc đời của hàng triệu người qua nhiều thế hệ. Qua quyển sách ...', N'David J. Schwartz', CAST(0xA5B20000 AS SmallDateTime), N'Còn sách')
INSERT [dbo].[SACH] ([MASACH], [MATL], [TENSACH], [NOIDUNG], [TACGIA], [NGAYDANG], [TRANGTHAI]) VALUES (N'TVS008', N'SKD', N'Thuật Bán Hàng', N'Tại sao một số nhân viên bán hàng lại dễ kiếm được nhiều tiền hơn, trong thời gian ngắn hơn, từ đó mang về nhiều doanh thu hơn? Tại sao họ thành công hơn, sống sung túc hơn với nhà lầu, xe hơi, quần áo đẹp và sự viên mãn có được từ công ...', N'Brian Tracy', CAST(0xA5B30000 AS SmallDateTime), N'Còn sách')
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 08/14/2016 21:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [varchar](15) NOT NULL,
	[TENKH] [nvarchar](30) NULL,
	[NGAYSINH] [smalldatetime] NULL,
	[DIACHI] [nvarchar](50) NULL,
	[SDT] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [NGAYSINH], [DIACHI], [SDT]) VALUES (N'nn1994', N'nguyen tran', CAST(0xA6620000 AS SmallDateTime), N'436a/63 3-2 f12 q10', N'01203254950')
/****** Object:  Table [dbo].[HOADONMUON]    Script Date: 08/14/2016 21:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADONMUON](
	[MAHD] [varchar](15) NOT NULL,
	[MAKH] [varchar](15) NULL,
	[NGAYLAP] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETMUON]    Script Date: 08/14/2016 21:47:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETMUON](
	[MAHD] [varchar](15) NOT NULL,
	[MASACH] [varchar](15) NOT NULL,
	[NGAYMUON] [smalldatetime] NULL,
	[NGAYTRA] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC,
	[MASACH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_CHITIETMUON_HOADONMUON]    Script Date: 08/14/2016 21:47:22 ******/
ALTER TABLE [dbo].[CHITIETMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETMUON_HOADONMUON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADONMUON] ([MAHD])
GO
ALTER TABLE [dbo].[CHITIETMUON] CHECK CONSTRAINT [FK_CHITIETMUON_HOADONMUON]
GO
/****** Object:  ForeignKey [FK_CHITIETMUON_SACH]    Script Date: 08/14/2016 21:47:22 ******/
ALTER TABLE [dbo].[CHITIETMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETMUON_SACH] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[CHITIETMUON] CHECK CONSTRAINT [FK_CHITIETMUON_SACH]
GO
/****** Object:  ForeignKey [FK_HOADONMUON_KHACHHANG]    Script Date: 08/14/2016 21:47:22 ******/
ALTER TABLE [dbo].[HOADONMUON]  WITH CHECK ADD  CONSTRAINT [FK_HOADONMUON_KHACHHANG] FOREIGN KEY([MAHD])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[HOADONMUON] CHECK CONSTRAINT [FK_HOADONMUON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_KHACHHANG_TAIKHOAN]    Script Date: 08/14/2016 21:47:22 ******/
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_TAIKHOAN] FOREIGN KEY([MAKH])
REFERENCES [dbo].[TAIKHOAN] ([ID])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_TAIKHOAN]
GO
/****** Object:  ForeignKey [FK_SACH_THELOAI]    Script Date: 08/14/2016 21:47:22 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI] FOREIGN KEY([MATL])
REFERENCES [dbo].[THELOAI] ([MATL])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAI]
GO
