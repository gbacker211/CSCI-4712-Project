USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Select_User]    Script Date: 3/5/2016 3:16:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[usp_Select_User]
	-- Add the parameters for the stored procedure here
	@UserName VARCHAR(25),
	@PassWoard VARCHAR(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @UserID INT

	SET @UserID = (SELECT User_Id FROM AccessUser WHERE UserName = @UserName AND Password = @PassWoard)


	


    IF EXISTS( SELECT DISTINCT UserGroup.UserId  FROM UserGroup WHERE UserGroup.UserId = @UserID)
	BEGIN
	     SELECT DISTINCT AU.AccesGroup,
		  		   AU.User_Id
	 	FROM AccessUser AU
	    WHERE AU.UserName = @UserName AND AU.Password = @PassWoard


	     SELECT DISTINCT 
		  		   
				   G.GroupName ,
				   G.ID
	 	FROM AccessUser AU
	    INNER JOIN UserGroup UG ON AU.User_Id = UG.UserId
					INNER JOIN Groups G ON G.ID = UG.GroupId
					WHERE AU.UserName = @UserName AND AU.Password = @PassWoard
	END
	ELSE
	BEGIN
	     SELECT DISTINCT AU.AccesGroup,
		  		   AU.User_Id
	 	FROM AccessUser AU
	    WHERE AU.UserName = @UserName AND AU.Password = @PassWoard
	END


	--Pull Group if possible

   





END
