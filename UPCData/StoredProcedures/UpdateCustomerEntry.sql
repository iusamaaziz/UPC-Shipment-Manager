CREATE PROCEDURE [dbo].[UpdateCustomerEntry]
	@id int = 0,
	@status nvarchar(50)
AS
UPDATE [dbo].[CustomerEntry]
	SET [Status]          = @status
	WHERE [Id] = @id


