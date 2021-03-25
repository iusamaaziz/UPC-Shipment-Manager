CREATE FUNCTION [dbo].[GetLast30InventoryInTransactions]
()
RETURNS TABLE
AS
RETURN
	SELECT TOP 30 * FROM InventoryItem ORDER BY InventoryItem.TransactionDate DESC
