USE SCMDatabase;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE usp_Select_User
	-- Add the parameters for the stored procedure here
	@UserName VARCHAR(25),
	@PassWoard VARCHAR(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


    SELECT AU.FirstName + ' ' + AU.LastName AS Employee,
	       AU.AccesGroup,
		   G.GroupName,
		   AU.User_Id
	       
	FROM AccessUser AU
	INNER JOIN UserGroup UG ON UG.UserId = AU.User_Id 
	INNER JOIN Groups G ON G.ID = UG.GroupId

END
GO
