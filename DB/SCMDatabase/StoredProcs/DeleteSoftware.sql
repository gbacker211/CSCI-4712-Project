USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Delete_Software]    Script Date: 3/5/2016 5:04:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-29-2016
-- Description:	Delete Software
-- =============================================
ALTER PROCEDURE [dbo].[usp_Delete_Software]
	@SoftwareId INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DECLARE @ReturnValue INT

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Software 
	WHERE SoftwareID = @SoftwareId

	DELETE FROM UserGroup
	WHERE SoftwareID = @SoftwareId


	
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
