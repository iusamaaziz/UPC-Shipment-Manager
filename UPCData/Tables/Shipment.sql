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
    CONSTRAINT [CK_PaymentType] CHECK ([PaymentType] = 'Prepaid' OR [PaymentType] = 'COD')
)
