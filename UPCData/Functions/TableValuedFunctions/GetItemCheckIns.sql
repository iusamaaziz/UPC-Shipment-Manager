CREATE FUNCTION [dbo].[GetItemCheckIns]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [CheckIns] WHERE [CheckIns].[ItemName] = @name;
