USE [SCMDatabase]
GO

/****** Object:  Table [dbo].[UserGroup]    Script Date: 2/24/2016 3:24:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserGroup](
	[ID] [int] NOT NULL,
	[SoftwareID] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_ConnectGroupToSoftware] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


