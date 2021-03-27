CREATE FUNCTION [dbo].[GetOutwardShipments]
()
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE [ShipmentType] = 'Outward'