CREATE FUNCTION [dbo].[GetQuantityByItem]
(
	@name nvarchar(128),
	@godown nvarchar(128)
)
RETURNS INT
AS
BEGIN
	RETURN (SELECT ISNULL([Quantity], 0) FROM [dbo].[InventoryItem] WHERE [InventoryItem].[ItemName] = @name AND [InventoryItem].[Godown] = @godown)
END
