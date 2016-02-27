USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 2-27-2016
-- Description:	Select Dataview Sofware Overview
-- =============================================
CREATE PROCEDURE usp_Select_SoftwareOverview
	-- Add the parameters for the stored procedure here
	@GroupID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT *
	FROM Software S
	INNER JOIN UserGroup UG ON S.SoftwareID = UG.SoftwareID
	INNER JOIN Groups G ON UG.GroupId = G.ID
	WHERE G.ID = @GroupID 
    
	
END
GO
