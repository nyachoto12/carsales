 CREATE TABLE[dbo].[product]
        (
             [ProductId] INT NOT NULL PRIMARY KEY,
             [ProductName] VARCHAR(20) NOT NULL,
			 [Quantity] INT NOT NULL,
			 [Price] INT NOT NULL,
			 [Category] VARCHAR(20) NOT NULL
             
        )