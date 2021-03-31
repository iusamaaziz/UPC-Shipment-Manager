CREATE TABLE [dbo].[CheckIns]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemName] NVARCHAR(128) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Godown] NVARCHAR(128) NOT NULL, 
    [Remarks] NVARCHAR(MAX) NULL, 
    [TransactionDate] DATETIME2 NOT NULL DEFAULT GETDATE()
)
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
CREATE TABLE [dbo].[CourierName]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Value] NVARCHAR(128) NOT NULL UNIQUE
)
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
CREATE TABLE [dbo].[Godown]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Value] NVARCHAR(128) UNIQUE NOT NULL
)
CREATE TABLE [dbo].[InventoryItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ItemName] NVARCHAR(128) NOT NULL, 
    [Godown] NVARCHAR(128) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Remarks] NVARCHAR(MAX) NULL, 
    [TransactionDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_InventoryItem_Godown] FOREIGN KEY ([Godown]) REFERENCES [Godown]([Value]) ON DELETE CASCADE ON UPDATE CASCADE
)
CREATE TABLE [dbo].[Shipment]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShipmentDate] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    [TrackingId] NVARCHAR(128) NOT NULL, 
    [CourierName] NVARCHAR(128) NOT NULL, 
    [ItemName] NVARCHAR(128) NOT NULL, 
    [ItemCondition] NVARCHAR(128) NOT NULL, 
    [Remarks] NVARCHAR(MAX) NULL, 
    [ShipmentType] NVARCHAR(128) NOT NULL, 
    [CustomerName] NVARCHAR(128) NULL, 
    [Amount] NVARCHAR(50) NULL, 
    [PaymentType] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [CK_Shipment_Type] CHECK ([ShipmentType] = 'Inward' OR [ShipmentType] = 'Outward'),
    CONSTRAINT [CK_PaymentType] CHECK ([PaymentType] = 'Prepaid' OR [PaymentType] = 'COD' OR [PaymentType] = 'N/A')
)
CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(128) NOT NULL UNIQUE, 
    [Password] NVARCHAR(128) NOT NULL, 
    [Role] NVARCHAR(50) NOT NULL, 
    [RegisterationDate] DATETIME2 NOT NULL DEFAULT GETDATE()
)
--------STORED PROCEDURES
GO

CREATE PROCEDURE [dbo].[DeleteInventoryItem]
	@id int
AS
BEGIN
	DELETE FROM InventoryItem
	WHERE [Id] = @id

END

GO

CREATE PROCEDURE [dbo].[InsertCourierName]
	@name nvarchar(128)
AS
	INSERT INTO [dbo].[CourierName]([Value]) VALUES (@name)

GO
CREATE PROCEDURE [dbo].[InsertCustomerEntry]
	@name       NVARCHAR(128),
    @phone      NVARCHAR(128),
    @email      NVARCHAR(128),
    @market     NVARCHAR(128),
    @order      NVARCHAR(128),
    @date       NVARCHAR(128),
    @product    NVARCHAR(128),
    @query      NVARCHAR(128),
    @action     NVARCHAR(128),
    @message    NVARCHAR(128),
    @status     NVARCHAR(128),
    @type       NVARCHAR(128)
AS
INSERT INTO [dbo].[CustomerEntry]
           ([CustomerName]
           ,[Phone]
           ,[Email]
           ,[MarketPlace]
           ,[OrderNumber]
           ,[OrderDate]
           ,[Product]
           ,[Query]
           ,[Action]
           ,[WhatsappMessage]
           ,[Status]
           ,[Type])
     VALUES
           (@name   
           ,@phone  
           ,@email  
           ,@market 
           ,@order  
           ,@date   
           ,@product
           ,@query  
           ,@action 
           ,@message
           ,@status 
           ,@type   )

GO
CREATE PROCEDURE [dbo].[InsertGodown]
	@godown nvarchar(128)
AS
BEGIN
	INSERT INTO Godown([Value])VALUES(@godown);
END
GO
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
GO
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
GO
CREATE PROCEDURE [dbo].[InsertShipment]
	@date       datetime2,
    @tracking   nvarchar(128),
    @courier    nvarchar(128),
    @item       nvarchar(128),
    @condition  nvarchar(128),
    @remarks    nvarchar(max),
    @type       nvarchar(128),
    @customer   nvarchar(128),
    @payment    nvarchar(50),
    @amount     nvarchar(50)
AS
    INSERT INTO [dbo].[Shipment]
           ([ShipmentDate]
           ,[TrackingId]
           ,[CourierName]
           ,[ItemName]
           ,[ItemCondition]
           ,[Remarks]
           ,[ShipmentType]
           ,[CustomerName]
           ,[PaymentType]
           ,[Amount])
     VALUES
           (@date     
           ,@tracking 
           ,@courier  
           ,@item     
           ,@condition
           ,@remarks  
           ,@type
           ,@customer
           ,@payment
           ,@amount)   

GO
CREATE PROCEDURE [dbo].[InsertUser]
	@name nvarchar(128),
	@pass nvarchar(128),
	@role nvarchar(128)
AS
	INSERT INTO [dbo].[User]([Username], [Password], [Role])
	VALUES (@name, @pass, @role)
GO
CREATE PROCEDURE [dbo].[UpdateCustomerEntry]
	@id int = 0,
	@status nvarchar(50)
AS
UPDATE [dbo].[CustomerEntry]
	SET [Status]          = @status
	WHERE [Id] = @id


GO
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
GO
------------FUNCTIONS

CREATE FUNCTION [dbo].[GetQuantityByItem]
(
	@name nvarchar(128),
	@godown nvarchar(128)
)
RETURNS INT
AS
BEGIN
	RETURN (SELECT ISNULL([Quantity], 0) FROM [dbo].[InventoryItem] WHERE [InventoryItem].[ItemName] = @name AND [InventoryItem].[Godown] = @godown)
END

GO

CREATE FUNCTION [dbo].[GetUserCount]
()
RETURNS INT
AS
BEGIN
	RETURN (SELECT COUNT(*) FROM [dbo].[User])
END

GO
CREATE FUNCTION [dbo].[IsCourierNameExists]
(
	@name nvarchar(128))
RETURNS BIT
AS
BEGIN
	DECLARE @count INT = (SELECT COUNT(*) FROM CourierName WHERE CourierName.[Value] = @name)
	IF (@count > 0)
		RETURN 1
	RETURN 0;
END
GO
CREATE FUNCTION [dbo].[IsGodownExists]
(
	@godown nvarchar(128))
RETURNS BIT
AS
BEGIN
	DECLARE @count INT = (SELECT COUNT(*) FROM Godown WHERE Godown.[Value] = @godown)
	IF (@count > 0)
		RETURN 1
	RETURN 0;
END
GO
CREATE FUNCTION [dbo].[IsTrackingExists]
(
	@name nvarchar(128))
RETURNS BIT
AS
BEGIN
	DECLARE @count INT = (SELECT COUNT(*) FROM Shipment WHERE Shipment.TrackingId = @name)
	IF (@count > 0)
		RETURN 1
	RETURN 0;
END
GO
---------------TABLE VALUED FUNCTIONS
CREATE FUNCTION [dbo].[GetCODShipmentsByDate]
(
	@start date,
	@end date
)
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE CONVERT(date, [ShipmentDate]) >= @start AND CONVERT(date, [ShipmentDate]) <= @end AND [PaymentType] = 'COD';
GO
CREATE FUNCTION [dbo].[GetCourierNames]
()
RETURNS TABLE
AS RETURN
	SELECT [Value] FROM dbo.CourierName
GO
CREATE FUNCTION [dbo].[GetCustomerNames]
()
RETURNS TABLE
AS RETURN
	SELECT [CustomerName] FROM [CustomerEntry]

GO
CREATE FUNCTION [dbo].[GetCustomerPhones]
()
RETURNS TABLE
AS RETURN
	SELECT [Phone] FROM [CustomerEntry]
GO
CREATE FUNCTION [dbo].[GetEntriesByName]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [CustomerEntry] WHERE [CustomerEntry].[CustomerName] = @name;
GO
CREATE FUNCTION [dbo].[GetEntriesByPhone]
(
	@phone nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [CustomerEntry] WHERE [CustomerEntry].[Phone] = @phone;

GO
CREATE FUNCTION [dbo].[GetGodowns]
()
RETURNS TABLE
AS RETURN
	SELECT [Value] FROM dbo.Godown
GO
CREATE FUNCTION [dbo].[GetGodownsByItem]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT [Value] FROM Godown
	INNER JOIN [InventoryItem] ON [InventoryItem].[Godown] = [Godown].[Value]
	WHERE [InventoryItem].[ItemName] = @name
GO
CREATE FUNCTION [dbo].[GetGodownStock]
(
	@godown nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [dbo].[InventoryItem] WHERE [InventoryItem].[Godown] = @godown;
GO
CREATE FUNCTION [dbo].[GetInwardShipments]
()
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE [ShipmentType] = 'Inward'
GO
CREATE FUNCTION [dbo].[GetItemCheckIns]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [CheckIns] WHERE [CheckIns].[ItemName] = @name;
GO
CREATE FUNCTION [dbo].[GetItemCheckouts]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [Checkouts] WHERE [Checkouts].[ItemName] = @name;
GO
CREATE FUNCTION [dbo].[GetItemInventory]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [InventoryItem] WHERE [InventoryItem].[ItemName] = @name;
GO
CREATE FUNCTION [dbo].[GetItemNames]
()
RETURNS TABLE
AS RETURN
	SELECT [ItemName] FROM [dbo].[InventoryItem]
GO
CREATE FUNCTION [dbo].[GetItemStock]
(
	@name nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [InventoryItem] WHERE [InventoryItem].[ItemName] = @name;
GO
CREATE FUNCTION [dbo].[GetLast30InventoryCheckouts]
()
RETURNS TABLE
AS
RETURN
	SELECT TOP 30 * FROM Checkouts WHERE Checkouts.TransactionType = 'Single' ORDER BY Checkouts.TransactionDate DESC

GO
CREATE FUNCTION [dbo].[GetLast30InventoryInTransactions]
()
RETURNS TABLE
AS
RETURN
	SELECT * FROM InventoryItem
GO
CREATE FUNCTION [dbo].[GetOutwardShipments]
()
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE [ShipmentType] = 'Outward'
GO
CREATE FUNCTION [dbo].[GetPastPicklists]
()
RETURNS TABLE
AS RETURN
	SELECT * FROM [Checkouts] WHERE [Checkouts].[TransactionType] = 'Picklist'
GO
CREATE FUNCTION [dbo].[GetShipmentsByDate]
(
	@start date,
	@end date
)
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE CONVERT(date, [ShipmentDate]) >= @start AND CONVERT(date, [ShipmentDate]) <= @end;
GO
CREATE FUNCTION [dbo].[GetShipmentsByTracking]
(@id nvarchar(128))
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE [TrackingId] = @id

GO
CREATE FUNCTION [dbo].[GetUserForLogin]
(
	@name nvarchar(128),
	@pass nvarchar(128)
)
RETURNS TABLE
AS RETURN
	SELECT * FROM [dbo].[User] WHERE [Username] = @name AND [Password] = @pass
