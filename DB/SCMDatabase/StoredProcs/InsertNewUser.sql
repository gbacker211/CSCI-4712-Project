USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Insert_NewUser]    Script Date: 3/20/2016 11:06:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-24-2016
-- Description:	Insert new User
-- =============================================
ALTER PROCEDURE [dbo].[usp_Insert_NewUser]
(
	-- Add the parameters for the stored procedure here
	@UserName VARCHAR(10),
	@Password VARCHAR(10),
	@FirstName VARCHAR(10),
	@LastName VARCHAR(10),
	@AccessGroup INT,
	@GroupName VARCHAR(25) 
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DECLARE @ReturnValue INT

	SET NOCOUNT ON;

	INSERT INTO dbo.AccessUser(FirstName, LastName, Password, UserName, AccesGroup)
	VALUES(@FirstName, @LastName, @Password, @UserName, @AccessGroup)


	DECLARE @UserID INT
	 DECLARE @GroupID INT

	SET @UserID = (SELECT TOP 1 User_Id FROM AccessUser WHERE UserName = @UserName)

	IF EXISTS(SELECT ID FROM Groups G WHERE G.GroupName = @GroupName)
	BEGIN
	      
		   SET @GroupID = (SELECT TOP 1  ID FROM Groups WHERE GroupName = @GroupName)
		   INSERT INTO dbo.UserGroup(UserId, GroupId)
		   VALUES(@UserID, @GroupID)

	END
	ELSE
	BEGIN
	     
		   INSERT INTO dbo.Groups(GroupName)
		   VALUES (@GroupName)

		  
		   SET @GroupID = (SELECT TOP 1 ID FROM Groups WHERE GroupName = @GroupName)
		   INSERT INTO dbo.UserGroup(UserId, GroupId)
		   VALUES(@UserID, @GroupID)
	END

	IF @@ERROR <> 0
		BEGIN
		   SET @ReturnValue = -1
		END
	ELSE
		BEGIN
		   SET @ReturnValue = 0
		END

	SELECT @ReturnValue

END
