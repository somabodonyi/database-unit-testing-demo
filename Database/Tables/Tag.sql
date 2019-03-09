﻿CREATE TABLE [dbo].[Tag]
(
	[TagId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Tag_Name] ON [dbo].[Tag] ([Name])
