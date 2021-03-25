﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(128) NOT NULL UNIQUE, 
    [Password] NVARCHAR(128) NOT NULL, 
    [Role] NVARCHAR(50) NOT NULL, 
    [RegisterationDate] DATETIME2 NOT NULL DEFAULT GETDATE()
)