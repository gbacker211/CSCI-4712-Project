USE [SCMDatabase]
GO

/****** Object:  Table [dbo].[ConfigItemDoc]    Script Date: 2/24/2016 3:03:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ConfigItemDoc](
	[CID_ID] [int] NOT NULL,
	[CI] [int] NOT NULL,
	[Name] [nchar](25) NOT NULL,
	[Revision] [nchar](25) NOT NULL,
	[Date] [nchar](10) NOT NULL,
	[Description] [text] NOT NULL,
	[Location] [nchar](25) NOT NULL,
 CONSTRAINT [PK_ConfigItemDoc] PRIMARY KEY CLUSTERED 
(
	[CID_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


