USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Select_SoftwareItemOverview]    Script Date: 3/16/2016 1:40:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-27-2016
-- Description:	Select Software Item Overview
-- =============================================
ALTER PROCEDURE [dbo].[usp_Select_SoftwareItemOverview]
	-- Add the parameters for the stored procedure here
	@SoftwareId INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  SD.SoftwareDocID,
	        SD.Name as SoftwareDocName,
			SD.Revision as SoftwareDocRevision,
			SD.Location as SoftwareDocLocation,
			SD.Date as SoftwareDocDate,
			SD.Description as SoftwareDocDesc,
			CI.CI_ID as ConfigItemID,
			CI.Name as ConfigItemName,
			CI.Revision as ConfigItemRev,
			CI.Location as ConfigItemLocal,
			CI.Date as ConfigItemDate,
			CI.Description as ConfigItemDes,
			CID.CID_ID as ConfigItemDocID,
			CID.Name as ConfigItemDocName,
			CID.Revision as ConfigItemDocRev,
			CID.Location as ConfigItemDocLocal,
			CID.Date as ConfigItemDocDate,
			CID.Description as ConfigItemDocDesc

		
	FROM SoftwareDoc SD
	INNER JOIN ConfigItem CI ON CI.SoftwareID = SD.Software_Id
	INNER JOIN ConfigItemDoc CID ON CID.CI = CI.CI_ID
	WHERE SD.Software_Id = @SoftwareId
 

END
