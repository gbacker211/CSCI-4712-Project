USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Insert_NewSoftware]    Script Date: 3/20/2016 9:48:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 02/24/2016
-- Description:	Insert new Software
-- =============================================
ALTER PROCEDURE [dbo].[usp_Insert_NewSoftware]
	-- Add the parameters for the stored procedure here
	@SoftwareName VARCHAR(25),
	@Description TEXT,
	@Classification CHAR(2),
	@SystemName VARCHAR(25),
	@Engineer VARCHAR(25),
	@Owner VARCHAR(25),
	@DesignAuthority VARCHAR(25),
	@GroupID INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DECLARE @ReturnValue INT

	SET NOCOUNT ON;
    INSERT INTO dbo.Software(Name, Description, Classification, SystemName, Engineer, Owner, DesignAuthority)
	VALUES(@SoftwareName, @Description, @Classification, @SystemName, @Engineer, @Owner, @DesignAuthority)


	
	DECLARE @SoftwareID INT
	--DECLARE @GroupID INT

	SET @SoftwareID = (SELECT TOP 1 SoftwareID  FROM Software ORDER BY SoftwareID DESC)
	


	--IF(@GroupID IS NULL)
	--BEGIN
	--   INSERT INTO Groups(GroupName)
	--   VALUES(@GroupName)


	--   SET @GroupID = (SELECT TOP 1 ID FROM Groups ORDER BY ID DESC)

	--THERE MUST BE A Group Link in there already
	   
	  INSERT INTO UserGroup(SoftwareID, GroupId)
	  VALUES(@SoftwareID, @GroupID)


	     
	

	   --INSERT INTO UserGroup(SoftwareID, GroupId, UserId)
	   --VALUES(@SoftwareID, @GroupID, @UserId)
	--END

	--ELSE
	--BEGIN
	--     INSERT INTO UserGroup(SoftwareID, GroupId, UserId)
	--	 VALUES (@SoftwareID, @GroupID, @UserId)
	--END



	
	
	
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
