USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Select_SoftwareView]    Script Date: 3/3/2016 4:16:27 PM ******/
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

	DECLARE @SoftwareID INT 

SET @SoftwareID = (
                    SELECT S.SoftwareID
					FROM Software S
					INNER JOIN UserGroup UG ON S.SoftwareID = UG.SoftwareID
	                INNER JOIN Groups G ON UG.GroupId = G.ID
					WHERE G.ID = @GroupID
					)




    -- Insert statements for procedure here
SELECT S.Name,
	       S.Engineer,
		   COALESCE((SELECT SOD.Name FROM SoftwareDoc SOD WHERE SOD.Software_Id = @SoftwareID), 'No Software Documents') as SoftwareDocsName,
		    COALESCE((SELECT SOD.Date FROM SoftwareDoc SOD WHERE SOD.Software_Id = @SoftwareID), 'No Software Documents') as SoftwareDocsDate,
			COALESCE((SELECT COUNT(CI.CI_ID) FROM ConfigItem CI WHERE CI.SoftwareID = @SoftwareID), 0) as CI_Count,
		    COALESCE((SELECT COUNT(CI.CI_ID) FROM ConfigItemDoc CID INNER JOIN ConfigItem CI ON CI.CI_ID = CID.CI WHERE CI.SoftwareID = @SoftwareID), 0) as CID_Count
    FROM Software S
	INNER JOIN UserGroup UG ON S.SoftwareID = UG.SoftwareID
	INNER JOIN Groups G ON UG.GroupId = G.ID
	WHERE G.ID = @GroupID
	GROUP BY S.Name,
	       S.Engineer
		  




END
