﻿CREATE TABLE [dbo].[account]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [AccountNumber] VARCHAR(255) NOT NULL, 
    [AccountTypeId] INT NOT NULL, 
    [Balance] DECIMAL(30) NOT NULL DEFAULT 0.00
)
