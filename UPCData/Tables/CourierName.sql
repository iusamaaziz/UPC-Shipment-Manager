﻿CREATE TABLE [dbo].[CourierName]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Value] NVARCHAR(128) NOT NULL UNIQUE
)
