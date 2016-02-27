USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-27-2016
-- Description:	Select Software View
-- =============================================
CREATE PROCEDURE usp_Select_SoftwareView
	-- Add the parameters for the stored procedure here
	@GroupID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT S.Name,
	       S.Engineer,
		   SOD.Name,
		   SOD.Date,
		   COUNT(CI.CI_ID) as CI_Count,
		   COUNT(CID.CID_ID) as CID_Count
    FROM Software S
	INNER JOIN SoftwareDoc SOD ON SOD.Software_Id = S.SoftwareID
	INNER JOIN ConfigItem CI ON CI.SoftwareID = S.SoftwareID
	INNER JOIN ConfigItemDoc CID ON CID.CI = CI.CI_ID
	INNER JOIN UserGroup UG ON S.SoftwareID = UG.SoftwareID
	INNER JOIN Groups G ON UG.GroupId = G.ID
	WHERE G.ID = @GroupID
	GROUP BY S.Name,
	       S.Engineer,
		   SOD.Name,
		   SOD.Date
		  
		  




END
GO
