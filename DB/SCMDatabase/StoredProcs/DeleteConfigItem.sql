USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Delete Config Item 
-- =============================================
CREATE PROCEDURE usp_Delete_ConfigItem
	-- Add the parameters for the stored procedure here
	@ConfigItem_Id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @ReturnValue INT

	DELETE ConfigItem 
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
