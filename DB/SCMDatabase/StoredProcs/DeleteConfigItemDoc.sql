USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Delete Config Item Doc
-- =============================================
CREATE PROCEDURE usp_Delete_ConfigItemDoc
	-- Add the parameters for the stored procedure here
	@ConfigItemDoc_Id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @ReturnValue INT


	DELETE ConfigItemDoc
	WHERE ConfigItemDoc.CID_ID = @ConfigItemDoc_Id

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
