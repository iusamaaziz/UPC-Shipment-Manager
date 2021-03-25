CREATE FUNCTION [dbo].[GetItemStock]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [InventoryItem] WHERE [InventoryItem].[ItemName] = @name;
