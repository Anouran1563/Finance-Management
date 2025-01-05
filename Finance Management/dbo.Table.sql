CREATE TABLE [dbo].[USERS] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Username]    VARCHAR (100) NOT NULL,
    [Password]    VARCHAR (255) NOT NULL,
    [Date_Create] DATETIME NOT NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

Go
SELECT * FROM USERS
SELECT Username, Password, Date_Create FROM dbo.USERS;