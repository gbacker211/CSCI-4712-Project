/*
   Sunday, February 21, 20165:05:16 PM
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
CREATE TABLE dbo.AccessGroup
	(
	ID int NOT NULL,
	Name nchar(10) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.AccessGroup ADD CONSTRAINT
	PK_AccessGroup PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.AccessGroup SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
