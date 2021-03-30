CREATE FUNCTION [dbo].[GetCODShipmentsByDate]
(
	@start date,
	@end date
)
RETURNS TABLE
AS
RETURN
	SELECT * FROM [dbo].[Shipment] WHERE CONVERT(date, [ShipmentDate]) >= @start AND CONVERT(date, [ShipmentDate]) <= @end AND [PaymentType] = 'COD';
