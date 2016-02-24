USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 02/24/2016
-- Description:	Insert new Software
-- =============================================
CREATE PROCEDURE usp_Insert_NewSoftware
	-- Add the parameters for the stored procedure here
	@SoftwareName VARCHAR(25),
	@Description TEXT,
	@Classification CHAR(2),
	@SystemName VARCHAR(25),
	@Engineer VARCHAR(25),
	@Owner VARCHAR(25),
	@DesignAuthority VARCHAR(25),
	@AccessGroup INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DECLARE @ReturnValue INT

	SET NOCOUNT ON;
    INSERT INTO dbo.Software(Name, Description, Classification, SystemName, Engineer, Owner, DesignAuthority)
	VALUES(@SoftwareName, @Description, @Classification, @SystemName, @Engineer, @Owner, @DesignAuthority)
	
	DECLARE @SoftwareID INT

	SET @SoftwareID = (SELECT TOP 1 SoftwareID  FROM Software)

	INSERT INTO UserGroup(SoftwareID, AccessGroup)
	VALUES (@SoftwareID, @AccessGroup)

	
	
	
	IF @@ERROR <> 0
	BEGIN
	  SET @ReturnValue = -1
	END
	ELSE
	 BEGIN
	  SET @ReturnValue = 0
	END 

	SELECT @ReturnValue

    -- Insert statements for procedure here

END
GO
