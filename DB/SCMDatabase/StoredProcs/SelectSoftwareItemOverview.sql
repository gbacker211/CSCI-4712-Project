USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-27-2016
-- Description:	Select Software Item Overview
-- =============================================
CREATE PROCEDURE usp_Select_SoftwareItemOverview
	-- Add the parameters for the stored procedure here
	@SoftwareId INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM SoftwareDoc SD
	INNER JOIN ConfigItem CI ON CI.SoftwareID = SD.Software_Id
	INNER JOIN ConfigItemDoc CID ON CID.CI = CI.CI_ID
	WHERE SD.Software_Id = @SoftwareId
 

END
GO
