USE [Invoices]
GO
/****** Object:  Table [dbo].[TactionDetails]    Script Date: 31.01.2025 11:27:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TactionDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TransactionId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[ItemSubTypeId] [int] NULL,
	[Unit] [decimal](19, 3) NOT NULL,
	[UnitPrice] [decimal](19, 2) NOT NULL,
	[Vat] [int] NOT NULL,
	[DiscountRate] [decimal](19, 2) NULL,
	[DiscountedPrice] [decimal](19, 2) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_TactionDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[TactionDetails]  WITH CHECK ADD  CONSTRAINT [FK_TactionDetails_ItemId] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([id])
GO
ALTER TABLE [dbo].[TactionDetails] CHECK CONSTRAINT [FK_TactionDetails_ItemId]
GO
ALTER TABLE [dbo].[TactionDetails]  WITH CHECK ADD  CONSTRAINT [FK_TactionDetails_ItemSubTypeId] FOREIGN KEY([ItemSubTypeId])
REFERENCES [dbo].[ItemSubType] ([id])
GO
ALTER TABLE [dbo].[TactionDetails] CHECK CONSTRAINT [FK_TactionDetails_ItemSubTypeId]
GO
ALTER TABLE [dbo].[TactionDetails]  WITH CHECK ADD  CONSTRAINT [FK_TactionDetails_TactionId] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Taction] ([id])
GO
ALTER TABLE [dbo].[TactionDetails] CHECK CONSTRAINT [FK_TactionDetails_TactionId]
GO
