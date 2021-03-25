CREATE FUNCTION [dbo].[GetGodownStock]
(
	@godown nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [dbo].[InventoryItem] WHERE [InventoryItem].[Godown] = @godown;
