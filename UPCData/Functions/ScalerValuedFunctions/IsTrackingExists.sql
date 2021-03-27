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
