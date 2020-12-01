 CREATE TABLE[dbo].[products]
        (
             [ProductId] INT NOT NULL PRIMARY KEY,
             [ProductName] VARCHAR(20) NOT NULL,
			 [Quantity] INT NOT NULL,
			 [Price] FLOAT NOT NULL,
			 [Category] VARCHAR NOT NULL
             
        )