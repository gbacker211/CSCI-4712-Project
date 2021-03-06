/*
   Sunday, February 21, 20165:22:00 PM
   User: 
   Server: GEOFFPC2P0\SQLEXPRESS
   Database: SCMDatabase
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.ConfigItem
	(
	CI_ID int NOT NULL,
	SoftwareID int NOT NULL,
	Name nchar(25) NOT NULL,
	Revision nchar(25) NOT NULL,
	Date nchar(10) NOT NULL,
	Description text NULL,
	Location nchar(25) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.ConfigItem ADD CONSTRAINT
	PK_ConfigItem PRIMARY KEY CLUSTERED 
	(
	CI_ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ConfigItem SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
