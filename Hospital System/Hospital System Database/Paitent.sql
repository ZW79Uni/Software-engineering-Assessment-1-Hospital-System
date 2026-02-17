CREATE TABLE [dbo].[Paitent]
(
	[paitentID] INT NOT NULL PRIMARY KEY,
	[paitentPassword] VARCHAR(50), CHECK (CHAR_LENGTH(paitentPassword) >= 8)
)
