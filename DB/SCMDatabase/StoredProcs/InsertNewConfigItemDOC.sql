USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE usp_Insert_NewConfigItemDOC
-- Add the parameters for the stored procedure here
	 @CI INT,
	 @Name VARCHAR(25),
	 @Revision VARCHAR(10),
	 @Date VARCHAR(10),
	 @Description TEXT,
	 @Location VARCHAR(25)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
DECLARE @ReturnValue INT

	SET NOCOUNT ON;
	IF EXISTS(SELECT ConfigItem.CI_ID FROM ConfigItem WHERE ConfigItem.CI_ID = @CI)
	BEGIN
	      INSERT INTO ConfigItemDoc(CI, Name, Revision, Date, Description, Location)
		  VALUES(@CI, @Name, @Revision, @Date, @Description, @Location)

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