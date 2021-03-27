CREATE FUNCTION [dbo].[GetInwardShipments]
()
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE [ShipmentType] = 'Inward'
