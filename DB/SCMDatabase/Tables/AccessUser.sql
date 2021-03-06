USE [SCMDatabase]
GO

/****** Object:  Table [dbo].[AccessUser]    Script Date: 2/27/2016 5:09:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AccessUser](
	[User_Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](10) NULL,
	[LastName] [nchar](10) NULL,
	[Password] [nchar](10) NOT NULL,
	[UserName] [nchar](10) NOT NULL,
	[AccesGroup] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


