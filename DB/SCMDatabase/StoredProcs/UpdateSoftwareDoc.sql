USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer	
-- Create date: 2-29-2016
-- Description:	Update Software Doc
-- =============================================
CREATE PROCEDURE usp_Update_SoftwareDoc 
	-- Add the parameters for the stored procedure here
	@SoftwareDOCID INT,
	@Name VARCHAR,
	@Revision VARCHAR,
	@Date VARCHAR,
	@Description TEXT,
	@Location TEXT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @ReturnValue INT
    -- Insert statements for procedure here
	UPDATE SoftwareDoc
	SET Name = @Name, Revision = @Revision, Date = @Date, Description = @Description, Location = @Location
	WHERE SoftwareDocID = @SoftwareDOCID
	

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
