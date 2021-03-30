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

