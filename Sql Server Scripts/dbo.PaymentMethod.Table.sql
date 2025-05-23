USE [Invoices]
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 31.01.2025 11:27:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CardOwnerId] [int] NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[BankCardId] [int] NULL,
 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PaymentMethod]  WITH CHECK ADD  CONSTRAINT [FK_PaymentMethod_BankCardId] FOREIGN KEY([BankCardId])
REFERENCES [dbo].[BankCard] ([id])
GO
ALTER TABLE [dbo].[PaymentMethod] CHECK CONSTRAINT [FK_PaymentMethod_BankCardId]
GO
ALTER TABLE [dbo].[PaymentMethod]  WITH CHECK ADD  CONSTRAINT [FK_PaymentMethodCardOwnerId_PersonId] FOREIGN KEY([CardOwnerId])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[PaymentMethod] CHECK CONSTRAINT [FK_PaymentMethodCardOwnerId_PersonId]
GO
