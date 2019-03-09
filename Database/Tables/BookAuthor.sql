CREATE TABLE [dbo].[BookAuthor]
(
	[BookAuthorId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [BookId] UNIQUEIDENTIFIER NOT NULL, 
    [AuthorId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_BookAuthors_Book] FOREIGN KEY ([BookId]) REFERENCES [Book]([BookId]), 
    CONSTRAINT [FK_BookAuthors_Author] FOREIGN KEY ([AuthorId]) REFERENCES [Author]([AuthorId])
)

GO

CREATE UNIQUE INDEX [IX_BookAuthors_BookAuthor] ON [dbo].[BookAuthor] ([BookId], [AuthorId])
