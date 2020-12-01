CREATE TABLE[dbo].[Order]
        (
             [OrderId] INT NOT NULL PRIMARY KEY,
             [CustomerName] VARCHAR(20) NOT NULL,
             [OrderDate] DATETIME NOT NULL,
             [Total] INT NOT NULL,
        )