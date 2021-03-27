CREATE FUNCTION [dbo].[GetCourierNames]
()
RETURNS TABLE
AS RETURN
	SELECT [Value] FROM dbo.CourierName
