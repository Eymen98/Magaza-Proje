USE [magaza]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 15.09.2022 15:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[mno] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[dtarih] [smalldatetime] NOT NULL,
	[tel] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[mno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteriurun]    Script Date: 15.09.2022 15:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteriurun](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mno] [int] NOT NULL,
	[uno] [int] NOT NULL,
	[tarih] [smalldatetime] NOT NULL,
	[miktar] [int] NOT NULL,
 CONSTRAINT [PK_musteriurun] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 15.09.2022 15:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[urunno] [int] IDENTITY(1,1) NOT NULL,
	[urun_adi] [nvarchar](100) NOT NULL,
	[fiyat] [money] NOT NULL,
	[miktar] [int] NOT NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[urunno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([mno], [ad], [soyad], [dtarih], [tel]) VALUES (1, N'mel', N'sim', CAST(N'1990-05-26T00:00:00' AS SmallDateTime), N'05335333333')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[musteriurun] ON 

INSERT [dbo].[musteriurun] ([id], [mno], [uno], [tarih], [miktar]) VALUES (2, 1, 1, CAST(N'2022-09-15T00:00:00' AS SmallDateTime), 100)
SET IDENTITY_INSERT [dbo].[musteriurun] OFF
GO
SET IDENTITY_INSERT [dbo].[Urun] ON 

INSERT [dbo].[Urun] ([urunno], [urun_adi], [fiyat], [miktar]) VALUES (1, N'Elma', 1000.0000, 400)
INSERT [dbo].[Urun] ([urunno], [urun_adi], [fiyat], [miktar]) VALUES (4, N'Ananas', 80.0000, 100)
SET IDENTITY_INSERT [dbo].[Urun] OFF
GO
ALTER TABLE [dbo].[musteriurun]  WITH CHECK ADD  CONSTRAINT [FK_musteriurun_Musteri] FOREIGN KEY([mno])
REFERENCES [dbo].[Musteri] ([mno])
GO
ALTER TABLE [dbo].[musteriurun] CHECK CONSTRAINT [FK_musteriurun_Musteri]
GO
ALTER TABLE [dbo].[musteriurun]  WITH CHECK ADD  CONSTRAINT [FK_musteriurun_Urun] FOREIGN KEY([uno])
REFERENCES [dbo].[Urun] ([urunno])
GO
ALTER TABLE [dbo].[musteriurun] CHECK CONSTRAINT [FK_musteriurun_Urun]
GO
/****** Object:  Trigger [dbo].[stok_azalt]    Script Date: 15.09.2022 15:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[stok_azalt]
   ON  [dbo].[musteriurun]
   AFTER Insert
AS 
BEGIN
declare @urunid int
declare @adet int
select @adet=miktar from inserted
select @urunid=uno from inserted
update Urun set miktar=miktar-@adet where urunno=@urunid

END
GO
ALTER TABLE [dbo].[musteriurun] ENABLE TRIGGER [stok_azalt]
GO
