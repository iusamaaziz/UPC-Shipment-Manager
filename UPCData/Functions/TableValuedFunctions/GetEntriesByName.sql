CREATE FUNCTION [dbo].[GetEntriesByName]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [CustomerEntry] WHERE [CustomerEntry].[CustomerName] = @name;
