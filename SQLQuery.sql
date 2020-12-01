CREATE TABLE [dbo].[users]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [uname] VARCHAR(30) NOT NULL,
    [fullname] VARCHAR(40) NOT NULL,
    [upassword] VARCHAR(8) NOT NULL,
    [email] VARCHAR(30) NOT NULL,

)