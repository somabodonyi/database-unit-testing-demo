﻿CREATE TABLE [dbo].[Book]
(
	[BookId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [PublicationDate] DATE NOT NULL 
)