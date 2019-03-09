CREATE FUNCTION [dbo].[GetAuthorsByTagId]
(
	@TagId uniqueidentifier
)
RETURNS @returntable TABLE
(
	AuthorId uniqueidentifier,
	AuthorName nvarchar(50)
)
AS
BEGIN
	INSERT	@returntable

	SELECT	DISTINCT A.AuthorId,
			A.Name [AuthorName]
	FROM	Author A
			INNER JOIN BookAuthor BA ON A.AuthorId = BA.AuthorId
			INNER JOIN BookTag BT ON BA.BookId = BT.BookId
	WHERE	BT.TagId = @TagId
	
	RETURN
END
