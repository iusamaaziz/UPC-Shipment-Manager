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

