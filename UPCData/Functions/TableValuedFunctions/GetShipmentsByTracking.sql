CREATE FUNCTION [dbo].[GetShipmentsByTracking]
(@id nvarchar(128))
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE [TrackingId] = @id
