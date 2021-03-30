CREATE FUNCTION [dbo].[GetCustomerNames]
()
RETURNS TABLE
AS RETURN
	SELECT [CustomerName] FROM [CustomerEntry]
