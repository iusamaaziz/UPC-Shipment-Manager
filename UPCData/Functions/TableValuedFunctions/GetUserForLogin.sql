CREATE FUNCTION [dbo].[GetUserForLogin]
(
	@name nvarchar(128),
	@pass nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [dbo].[User] WHERE [Username] = @name AND [Password] = @pass
