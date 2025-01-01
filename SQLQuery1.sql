CREATE TABLE [dbo].[Table]
(
	[Id] INT PRIMARY KEY IDENTITY(1, 1),
	[Username] VARCHAR (MAX) NULL,
	[Password] VARCHAR (MAX) NULL,
	Date_Create DATE NULL
)

SELECT * FROM [Table]