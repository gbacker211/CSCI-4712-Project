USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Update_Software]    Script Date: 3/23/2016 3:03:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Update Software
-- =============================================
ALTER PROCEDURE [dbo].[usp_Update_Software] 
	-- Add the parameters for the stored procedure here
	@SoftwareID INT,
	@Classification VARCHAR(2),
	@DesignAuthority VARCHAR(25),
	@SystemName VARCHAR(25),
	@Engineer VARCHAR(25),
	@Description Text,
	@Owner VARCHAR(25),
	@MangingGroup INT,
	@Name VARCHAR(25)


	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF NOT EXISTS(SELECT Name FROM Software WHERE Name = @Name)
		BEGIN
			DECLARE @ReturnValue INT
			UPDATE Software
			SET SystemName = @SystemName,
				Classification = @Classification,
				Description = @Description,
				DesignAuthority = @DesignAuthority,
				 Owner = @Owner,
				Engineer = @Engineer,
				Name = @Name
	 

			WHERE SoftwareID = @SoftwareID


			UPDATE UserGroup
			SET GroupId = @MangingGroup
			WHERE SoftwareID = @SoftwareID
	
	


	
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
