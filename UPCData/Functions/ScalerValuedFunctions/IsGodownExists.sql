CREATE FUNCTION [dbo].[IsGodownExists]
(
	@godown nvarchar(128))
RETURNS BIT
AS
BEGIN
	DECLARE @count INT = (SELECT COUNT(*) FROM Godown WHERE Godown.[Value] = @godown)
	IF (@count > 0)
		RETURN 1
	RETURN 0;
END
