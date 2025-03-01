USE [Invoices]
GO
/****** Object:  Table [dbo].[ItemGroup]    Script Date: 31.01.2025 11:27:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemGroup](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](512) NOT NULL,
	[TopGroupId] [int] NOT NULL,
 CONSTRAINT [PK_ItemGroup] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ItemGroup]  WITH CHECK ADD  CONSTRAINT [FK_ItemGroup_TopGroupId] FOREIGN KEY([id])
REFERENCES [dbo].[ItemGroup] ([id])
GO
ALTER TABLE [dbo].[ItemGroup] CHECK CONSTRAINT [FK_ItemGroup_TopGroupId]
GO
