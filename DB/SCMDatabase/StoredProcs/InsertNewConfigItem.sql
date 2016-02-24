USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 02/24/2016
-- Description:	Insert new ConfigItem
-- =============================================
CREATE PROCEDURE usp_Insert_NewConfigItem
	-- Add the parameters for the stored procedure here
	 @SoftwareID INT,
	 @Name VARCHAR(25),
	 @Revision VARCHAR(10),
	 @Date VARCHAR(10),
	 @Description TEXT,
	 @Location TEXT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
DECLARE @ReturnValue INT

	SET NOCOUNT ON;
	IF EXISTS(SELECT Software.SoftwareID FROM Software WHERE Software.SoftwareID = @SoftwareID)
	BEGIN
	      INSERT INTO ConfigItem(SoftwareID, Name, Revision, Date, Description, Location)
		  VALUES(@SoftwareID, @Name, @Revision, @Date, @Description, @Location)

	END
    ELSE
	BEGIN
	  SET @ReturnValue = -1
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
GO
