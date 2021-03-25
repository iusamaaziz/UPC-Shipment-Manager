CREATE TABLE [dbo].[Checkouts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemName] NVARCHAR(128) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Godown] NVARCHAR(128) NOT NULL, 
    [Remarks] NVARCHAR(MAX) NULL, 
    [TransactionDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [TransactionType] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [CK_Checkouts_TransactionType] CHECK ([TransactionType] = 'Single' OR [TransactionType] = 'Picklist')
)
