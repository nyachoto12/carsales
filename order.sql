CREATE TABLE[dbo].[orders]
        (
             [OrderId] INT NOT NULL PRIMARY KEY,
             [CustomerId] INT NOT NULL,
             [CustomerName;] VARCHAR(20) NOT NULL,
             [Order Date] DATE  NOT NULL,
             [Total] INT NOT NULL
		)