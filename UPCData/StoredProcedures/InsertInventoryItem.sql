CREATE PROCEDURE [dbo].[InsertInventoryItem]
	@name       nvarchar(128),
	@godown     nvarchar(128),
	@quantity   int,
	@remarks    nvarchar(max),
	@date       datetime2(7)
AS
BEGIN
    INSERT INTO [dbo].[CheckIns]
           ([ItemName]
           ,[Godown]
           ,[Quantity]
           ,[Remarks]
           ,[TransactionDate])
        VALUES
           (@name    
           ,@godown  
           ,@quantity
           ,@remarks 
           ,@date)

    DECLARE @count INT = (SELECT COUNT(*) FROM InventoryItem WHERE InventoryItem.ItemName = @name AND InventoryItem.Godown = @godown)
    IF(@count = 0)
       INSERT INTO [dbo].[InventoryItem]
           ([ItemName]
           ,[Godown]
           ,[Quantity]
           ,[Remarks]
           ,[TransactionDate])
        VALUES
           (@name    
           ,@godown  
           ,@quantity
           ,@remarks 
           ,@date)
    ELSE
        UPDATE [dbo].[InventoryItem]
           SET [Godown]          = @godown  
              ,[Quantity]        = [Quantity] + @quantity
              ,[Remarks]         = @remarks 
              ,[TransactionDate] = @date    
         WHERE [ItemName]        = @name
END
