﻿CREATE FUNCTION [dbo].[GetGodowns]
()
RETURNS TABLE
AS RETURN
	SELECT [Value] FROM dbo.Godown