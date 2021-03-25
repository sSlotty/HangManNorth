CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [username] VARCHAR(255) NOT NULL, 
    [password] TEXT NOT NULL, 
    [point] INT NOT NULL DEFAULT 0
)
