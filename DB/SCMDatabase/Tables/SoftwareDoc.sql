/*
   Sunday, February 21, 20165:17:32 PM
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
CREATE TABLE dbo.SoftwareDoc
	(
	SoftwareDocID int NOT NULL,
	Software_Id int NOT NULL,
	Name nchar(25) NOT NULL,
	Revision nchar(10) NULL,
	Date nchar(10) NOT NULL,
	Description text NULL,
	Location text NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.SoftwareDoc SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
