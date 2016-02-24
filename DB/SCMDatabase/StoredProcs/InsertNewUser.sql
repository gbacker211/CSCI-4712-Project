USE SCMDatabase;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-24-2016
-- Description:	Insert new User
-- =============================================
CREATE PROCEDURE usp_Insert_NewUser
(
	-- Add the parameters for the stored procedure here
	@UserName VARCHAR(10),
	@Password VARCHAR(10),
	@FirstName VARCHAR(10),
	@LastName VARCHAR(10),
	@AccessGroup INT
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DECLARE @ReturnValue INT

	SET NOCOUNT ON;

	INSERT INTO dbo.AccessUser(FirstName, LastName, Password, UserName, AccesGroup)
	VALUES(@UserName, @Password, @FirstName, @LastName, @AccessGroup)

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

   

