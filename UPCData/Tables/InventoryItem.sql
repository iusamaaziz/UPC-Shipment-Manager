﻿CREATE TABLE [dbo].[InventoryItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ItemName] NVARCHAR(128) NOT NULL, 
    [Godown] NVARCHAR(128) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Remarks] NVARCHAR(MAX) NULL, 
    [TransactionDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_InventoryItem_Godown] FOREIGN KEY ([Godown]) REFERENCES [Godown]([Value]) ON DELETE CASCADE ON UPDATE CASCADE
)
