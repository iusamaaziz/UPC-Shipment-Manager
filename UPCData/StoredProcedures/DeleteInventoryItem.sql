CREATE PROCEDURE [dbo].[DeleteInventoryItem]
	@id int
AS
BEGIN
	DELETE FROM InventoryItem
	WHERE [Id] = @id

END
