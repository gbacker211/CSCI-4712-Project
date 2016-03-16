USE [SCMDatabase]
GO
/****** Object:  StoredProcedure [dbo].[usp_Select_UserForEditing]    Script Date: 3/16/2016 2:05:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Geoffrey Backer
-- Create date: 3-16-2016
-- Description:	Select all Users 
-- =============================================
CREATE PROCEDURE [dbo].[usp_Select_AllUser] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT  AU.FirstName,
	        AU.LastName,
			AU.UserName,
			AU.Password,
			AU.AccesGroup
	FROM AccessUser AU
	
    -- Insert statements for procedure here
	
END
