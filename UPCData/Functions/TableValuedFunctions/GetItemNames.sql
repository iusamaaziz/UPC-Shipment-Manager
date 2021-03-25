CREATE FUNCTION [dbo].[GetItemNames]
()
RETURNS TABLE
AS RETURN
	SELECT [ItemName] FROM [dbo].[InventoryItem]
