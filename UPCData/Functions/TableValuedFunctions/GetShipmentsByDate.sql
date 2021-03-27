CREATE FUNCTION [dbo].[GetShipmentsByDate]
(
	@start date,
	@end date
)
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE [ShipmentDate] >= @start AND [ShipmentDate] <= @end;