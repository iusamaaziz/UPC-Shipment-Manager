CREATE PROCEDURE [dbo].[InsertShipment]
	@date       datetime2,
    @tracking   nvarchar(128),
    @courier    nvarchar(128),
    @item       nvarchar(128),
    @condition  nvarchar(128),
    @remarks    nvarchar(max),
    @type       nvarchar(128)
AS
    INSERT INTO [dbo].[Shipment]
           ([ShipmentDate]
           ,[TrackingId]
           ,[CourierName]
           ,[ItemName]
           ,[ItemCondition]
           ,[Remarks]
           ,[ShipmentType])
     VALUES
           (@date     
           ,@tracking 
           ,@courier  
           ,@item     
           ,@condition
           ,@remarks  
           ,@type  )   

