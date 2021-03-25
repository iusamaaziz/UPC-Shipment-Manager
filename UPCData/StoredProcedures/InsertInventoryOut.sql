CREATE PROCEDURE [dbo].[InsertInventoryOut]
	@name       nvarchar(128),
	@godown     nvarchar(128),
	@quantity   int,
	@remarks    nvarchar(max),
    @date       datetime2(7),
    @type       nvarchar(50)
AS
BEGIN

INSERT INTO [dbo].[Checkouts]
           ([ItemName]
           ,[Quantity]
           ,[Godown]
           ,[Remarks]
           ,[TransactionDate]
           ,[TransactionType])
     VALUES
           (@name    
           ,@quantity  
           ,@godown
           ,@remarks 
           ,@date    
           ,@type    )

UPDATE [InventoryItem]
SET [Quantity] = [Quantity] + @quantity
WHERE [InventoryItem].[ItemName] = @name AND [InventoryItem].[Godown] = @godown

END
