USE [Invoices]
GO
/****** Object:  Table [dbo].[Taction]    Script Date: 31.01.2025 11:27:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Dt] [datetime2](7) NOT NULL,
	[ShopId] [int] NOT NULL,
	[TotalPrice] [decimal](19, 2) NOT NULL,
	[PaymentMethodId] [int] NOT NULL,
	[No] [nvarchar](50) NULL,
	[SellerId] [int] NULL,
	[WhoDidIt] [int] NULL,
 CONSTRAINT [PK_Taction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Taction]  WITH CHECK ADD  CONSTRAINT [FK_Taction_PaymentMethodId] FOREIGN KEY([PaymentMethodId])
REFERENCES [dbo].[PaymentMethod] ([id])
GO
ALTER TABLE [dbo].[Taction] CHECK CONSTRAINT [FK_Taction_PaymentMethodId]
GO
ALTER TABLE [dbo].[Taction]  WITH CHECK ADD  CONSTRAINT [FK_Taction_SellerId] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Seller] ([id])
GO
ALTER TABLE [dbo].[Taction] CHECK CONSTRAINT [FK_Taction_SellerId]
GO
ALTER TABLE [dbo].[Taction]  WITH CHECK ADD  CONSTRAINT [FK_Taction_ShopId] FOREIGN KEY([ShopId])
REFERENCES [dbo].[Shop] ([id])
GO
ALTER TABLE [dbo].[Taction] CHECK CONSTRAINT [FK_Taction_ShopId]
GO
ALTER TABLE [dbo].[Taction]  WITH CHECK ADD  CONSTRAINT [FK_Taction_WhoDidIt] FOREIGN KEY([WhoDidIt])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Taction] CHECK CONSTRAINT [FK_Taction_WhoDidIt]
GO
