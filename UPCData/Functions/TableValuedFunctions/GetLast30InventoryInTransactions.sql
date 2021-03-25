CREATE FUNCTION [dbo].[GetLast30InventoryInTransactions]
()
RETURNS TABLE
AS
RETURN
	SELECT * FROM InventoryItem
