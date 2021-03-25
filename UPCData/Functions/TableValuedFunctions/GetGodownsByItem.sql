CREATE FUNCTION [dbo].[GetGodownsByItem]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT [Value] FROM Godown
	INNER JOIN [InventoryItem] ON [InventoryItem].[Godown] = [Godown].[Value]
	WHERE [InventoryItem].[ItemName] = @name
