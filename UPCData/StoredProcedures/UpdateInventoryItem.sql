CREATE PROCEDURE [dbo].[UpdateInventoryItem]
	@id			int,
	@name       nvarchar(128),
	@godown     nvarchar(128),
	@quantity   int,
	@remarks    nvarchar(max),
	@date       datetime2(7)
AS
BEGIN
UPDATE [dbo].[InventoryItem]
           SET [Godown]          = @godown  
              ,[Quantity]        = @quantity
              ,[Remarks]         = @remarks 
              ,[TransactionDate] = @date  
			  ,[ItemName]		 = @name
         WHERE [Id]        = @id
END
