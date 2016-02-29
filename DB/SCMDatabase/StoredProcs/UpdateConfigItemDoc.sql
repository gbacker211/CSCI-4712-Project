USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date:  2-29-2016
-- Description:	Update ConfigItemDoc
-- =============================================
CREATE PROCEDURE usp_Update_ConfigItemDOC
	-- Add the parameters for the stored procedure here
	@ConfigItemDOC_ID INT,
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

	DECLARE @ReturnValue INT

   
	UPDATE ConfigItemDoc
	SET Name = @Name, Revision = @Revision, Date = @Date, Description= @Description, Location = @Location
	WHERE ConfigItemDoc.CID_ID = @ConfigItemDOC_ID


	IF @@ERROR <> 0
	BEGIN
	  SET @ReturnValue = -1
	END
	ELSE
	BEGIN
	  SET @ReturnValue = 0
	END


END
GO
