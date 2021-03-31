CREATE FUNCTION [dbo].[GetCustomerPhones]
()
RETURNS TABLE
AS RETURN
	SELECT [Phone] FROM [CustomerEntry]
