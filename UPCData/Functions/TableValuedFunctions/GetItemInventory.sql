CREATE FUNCTION [dbo].[GetItemInventory]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [InventoryItem] WHERE [InventoryItem].[ItemName] = @name;