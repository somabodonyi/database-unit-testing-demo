﻿CREATE TABLE [dbo].[BookTag]
(
	[BookTagId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [BookId] UNIQUEIDENTIFIER NOT NULL, 
    [TagId] UNIQUEIDENTIFIER NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_BookTag_BookIdTagId] ON [dbo].[BookTag] ([BookId], [TagId])
