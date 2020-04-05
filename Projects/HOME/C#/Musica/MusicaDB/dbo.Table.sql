CREATE TABLE [dbo].[Users]
(
	[UserID] INT NOT NULL PRIMARY KEY, 
    [firstName] NVARCHAR(50) NOT NULL, 
    [lastName] NVARCHAR(50) NOT NULL, 
    [username] NVARCHAR(25) NOT NULL, 
    [email] NVARCHAR(200) NOT NULL, 
    [password] NVARCHAR(32) NOT NULL
)
