USE [Invoices]
GO
/****** Object:  Table [dbo].[UserImage]    Script Date: 31.01.2025 11:27:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserImage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[imageData] [varbinary](max) NOT NULL,
	[isDefault] [bit] NOT NULL,
 CONSTRAINT [PK_UserImage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserImage] ADD  CONSTRAINT [DF_UserImage_isDefault]  DEFAULT ((0)) FOR [isDefault]
GO
ALTER TABLE [dbo].[UserImage]  WITH CHECK ADD  CONSTRAINT [FK_UserImage_UserId] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[UserImage] CHECK CONSTRAINT [FK_UserImage_UserId]
GO
