USE [Invoices]
GO
/****** Object:  Table [dbo].[Shop]    Script Date: 31.01.2025 11:27:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](512) NOT NULL,
	[GroupId] [int] NOT NULL,
	[Nickname] [nvarchar](512) NULL,
	[No] [nvarchar](512) NULL,
	[Address] [nvarchar](512) NULL,
	[Tel] [nvarchar](512) NULL,
	[Web] [nvarchar](512) NULL,
	[Email] [nvarchar](512) NULL,
 CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Shop]  WITH CHECK ADD  CONSTRAINT [FK_ShopGroupId_ShopGroupId] FOREIGN KEY([GroupId])
REFERENCES [dbo].[ShopGroup] ([id])
GO
ALTER TABLE [dbo].[Shop] CHECK CONSTRAINT [FK_ShopGroupId_ShopGroupId]
GO
