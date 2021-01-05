CREATE TABLE [dbo].[Questions]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [UserId] INT NOT NULL
)
