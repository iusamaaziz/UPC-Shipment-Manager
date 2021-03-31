CREATE FUNCTION [dbo].[GetEntriesByPhone]
(
	@phone nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [CustomerEntry] WHERE [CustomerEntry].[Phone] = @phone;

