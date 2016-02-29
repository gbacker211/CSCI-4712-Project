USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Update Software
-- =============================================
CREATE PROCEDURE usp_Update_Software 
	-- Add the parameters for the stored procedure here
	@SoftwareID INT,
	@Classification VARCHAR,
	@DesignAuthority VARCHAR,
	@SystemName VARCHAR,
	@Engineer VARCHAR,
	@Description VARCHAR,
	@Owner VARCHAR,
	@MangingGroup VARCHAR


	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @ReturnValue INT
    UPDATE Software
	SET SystemName = @SystemName,
	    Classification = @Classification,
		Description = @Description,
		DesignAuthority = @DesignAuthority,
		 Owner = @Owner,
		Engineer = @Engineer
	 

	WHERE SoftwareID = @SoftwareID
	
	DECLARE @GroupID INT

	SET @GroupID =(SELECT ID FROM Groups WHERE GroupName = @MangingGroup)

	UPDATE UserGroup 
	SET GroupId = @GroupID
	WHERE SoftwareID = @SoftwareID


	
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
