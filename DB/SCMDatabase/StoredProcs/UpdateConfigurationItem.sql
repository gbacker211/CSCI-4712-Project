USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Update Configuration Item
-- =============================================
CREATE PROCEDURE usp_Update_ConfigItem
	-- Add the parameters for the stored procedure here
	@ConfigItem_Id INT,
	@Name VARCHAR,
	@Revision VARCHAR,
	@Date VARCHAR,
	@Description TEXT,
	@Location VARCHAR

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @ReturnValue INT

	UPDATE ConfigItem
	SET ConfigItem.Name = @Name,
	    ConfigItem.Revision = @Revision,
		ConfigItem.Description = @Description,
		Date = @Date,
		Location = @Location
	WHERE ConfigItem.CI_ID = @ConfigItem_Id



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
