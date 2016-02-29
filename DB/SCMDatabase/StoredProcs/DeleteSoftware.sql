USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Delete Software
-- =============================================
CREATE PROCEDURE usp_Delete_Software
	@SoftwareId INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DECLARE @ReturnValue INT

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Software 
	WHERE SoftwareID = @SoftwareId


	
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
