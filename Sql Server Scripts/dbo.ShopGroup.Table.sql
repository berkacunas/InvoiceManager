USE [Invoices]
GO
/****** Object:  Table [dbo].[ShopGroup]    Script Date: 31.01.2025 11:27:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopGroup](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[TypeId] [int] NOT NULL,
	[Owner] [nvarchar](100) NULL,
	[SellerId] [int] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShopGroup] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ShopGroup]  WITH CHECK ADD  CONSTRAINT [FK_ShopGroupSellerId_SellerId] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Seller] ([id])
GO
ALTER TABLE [dbo].[ShopGroup] CHECK CONSTRAINT [FK_ShopGroupSellerId_SellerId]
GO
ALTER TABLE [dbo].[ShopGroup]  WITH CHECK ADD  CONSTRAINT [FK_ShopGroupTypeId_ShopTypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[ShopType] ([id])
GO
ALTER TABLE [dbo].[ShopGroup] CHECK CONSTRAINT [FK_ShopGroupTypeId_ShopTypeId]
GO
