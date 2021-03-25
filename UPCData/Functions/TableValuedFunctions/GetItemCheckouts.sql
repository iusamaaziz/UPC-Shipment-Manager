CREATE FUNCTION [dbo].[GetItemCheckouts]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [Checkouts] WHERE [Checkouts].[ItemName] = @name;
