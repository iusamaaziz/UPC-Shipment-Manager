CREATE FUNCTION [dbo].[GetLast30InventoryCheckouts]
()
RETURNS TABLE
AS
RETURN
	SELECT TOP 30 * FROM Checkouts WHERE Checkouts.TransactionType = 'Single' ORDER BY Checkouts.TransactionDate DESC

