USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Update_User]    Script Date: 3/22/2016 12:29:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Update User
-- =============================================
ALTER PROCEDURE [dbo].[usp_Update_User]
	-- Add the parameters for the stored procedure here
	@UserID INT,
	@UserName VARCHAR(25),
	@Password VARCHAR(25),
	@AccessGroup INT,
	@FirstName VARCHAR(25),
	@LastName VARCHAR(25),
	@GroupID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @ReturnValue INT

	IF NOT EXISTS(SELECT UserName FROM AccessUser WHERE UserName = @UserName)
	BEGIN

	UPDATE AccessUser
	SET UserName = @UserName, Password = @Password, AccesGroup = @AccessGroup, FirstName = @FirstName, LastName = @LastName , GroupID = @GroupID
	WHERE User_Id = @UserID


	
	IF @@ERROR <> 0
	BEGIN
	 SET @ReturnValue = -1
    END
	ELSE
	 BEGIN
	    SET @ReturnValue = 0
	 END
   END

   ELSE
	BEGIN
	   SET @ReturnValue = -1
	END


   SELECT @ReturnValue

END
