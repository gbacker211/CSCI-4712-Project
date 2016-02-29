USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Update User
-- =============================================
CREATE PROCEDURE usp_Update_User
	-- Add the parameters for the stored procedure here
	@UserID INT,
	@UserName VARCHAR,
	@Password VARCHAR,
	@AccessGroup INT,
	@FirstName VARCHAR,
	@LastName VARCHAR
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @ReturnValue INT

	UPDATE AccessUser
	SET UserName = @UserName, Password = @Password, AccesGroup = @AccessGroup, FirstName = @FirstName, LastName = @LastName 
	WHERE User_Id = @UserID

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
GO
