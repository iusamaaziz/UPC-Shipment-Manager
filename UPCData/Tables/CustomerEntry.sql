CREATE TABLE [dbo].[CustomerEntry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerName] NVARCHAR(128) NULL, 
    [Phone] NVARCHAR(128) NULL, 
    [Email] NVARCHAR(128) NULL, 
    [MarketPlace] NVARCHAR(128) NULL, 
    [OrderNumber] NVARCHAR(128) NULL, 
    [OrderDate] NVARCHAR(128) NULL, 
    [Product] NVARCHAR(128) NULL, 
    [Query] NVARCHAR(MAX) NULL, 
    [Action] NVARCHAR(MAX) NULL, 
    [WhatsappMessage] NVARCHAR(MAX) NULL, 
    [Status] VARCHAR(50) NOT NULL, 
    [Type] VARCHAR(50) NOT NULL
)
