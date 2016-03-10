USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 3-9-2016
-- Description:	Select Groups by user id
-- =============================================
CREATE PROCEDURE usp_Select_GroupsByUserID
	-- Add the parameters for the stored procedure here
	@UserID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT 
		  		   
				   G.GroupName ,
				   G.ID
	 	FROM AccessUser AU
	    INNER JOIN UserGroup UG ON  UG.UserId =  AU.User_Id
					INNER JOIN Groups G ON G.ID = UG.GroupId
					WHERE AU.User_Id = @UserID
END
GO
