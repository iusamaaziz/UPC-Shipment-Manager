CREATE FUNCTION [dbo].[GetPastPicklists]
()
RETURNS TABLE
AS RETURN
	SELECT * FROM [Checkouts] WHERE [Checkouts].[TransactionType] = 'Picklist'
