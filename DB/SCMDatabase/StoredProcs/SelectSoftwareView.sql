USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Select_SoftwareView]    Script Date: 3/20/2016 10:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-27-2016
-- Description:	Select Software View
-- =============================================
ALTER PROCEDURE [dbo].[usp_Select_SoftwareView]
	-- Add the parameters for the stored procedure here
	@GroupID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

;WITH 
     
	 Software_Name(Name, SoftwareID, GroupID)
	  AS
	 (
	    SELECT S.Name,S.SoftwareID, UG.GroupId
		FROM Software S
		INNER JOIN UserGroup UG ON UG.SoftwareID = S.SoftwareID

	 ),

      Software_DOC_Count(SoftwareDocCount, SoftwareId)
	  AS
	  (
	     SELECT COUNT(SD.SoftwareDocID), Software_Id
		 FROM SoftwareDoc SD
		 GROUP BY Software_Id
		 
	  ),
	  ConfigItem_Count(ItemCount, CI_SoftwareID, CI_ID)
	  AS
	  (
	       SELECT COUNT(CI.CI_ID), Ci.SoftwareID, CI.CI_ID
		   FROM ConfigItem CI
		   GROUP BY CI.SoftwareID,CI.CI_ID
		  
	  ),
	  ConfigItemDOC_Count(CID_Count, CI)
	  AS
	  (
	      SELECT COUNT(CIDOC.CI), Ci.CI_ID
		  FROM ConfigItemDoc CIDOC
		  INNER JOIN ConfigItem CI ON CI.CI_ID = CIDOC.CI
		  GROUP BY Ci.CI_ID
		
	  ),

	    SoftwareView(Name, Software_DOC_Count, Software_CI_Count, Software_CID_Count, SoftwareID)
	  AS
	  (
	           SELECT S.Name,
			    ISNULL(SDOC.SoftwareDocCount,0),
				ISNULL(CICOUNT.ItemCount, 0),
				ISNULL(CIDCOUNT.CID_Count, 0),
				S.SoftwareID

			   FROM Software_Name S
			   LEFT OUTER JOIN Software_DOC_Count SDOC ON SDOC.SoftwareId = S.SoftwareID
			   LEFT OUTER JOIN ConfigItem_Count CICOUNT ON CICOUNT.CI_SoftwareID = S.SoftwareID
			   LEFT OUTER JOIN ConfigItemDOC_Count CIDCOUNT ON CIDCOUNT.CI = CICOUNT.CI_ID
			   WHERE S.GroupID = @GroupID 
	  )



  SELECT *
  FROM SoftwareView




END
