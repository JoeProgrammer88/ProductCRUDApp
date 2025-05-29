-- Switch to master in case the
-- dev has a current connection open
-- to the ProductDb
use master

DROP DATABASE IF EXISTS ProductDb
GO

CREATE DATABASE ProductDb
GO

use ProductDb
GO

CREATE TABLE Product 
(
    ProductId    int            IDENTITY(1,1) PRIMARY KEY
    ,Name        varchar(50)    NOT NULL UNIQUE
    ,Price       numeric(10, 2) NOT NULL CHECK (Price >= 0 AND Price <= 10000000)
)
GO

SET IDENTITY_INSERT Product ON

INSERT INTO Product (ProductId, Name, Price) VALUES
    (1, 'Wireless Mouse', 29.99)
    ,(2, 'Mechanical Keyboard', 89.50)
    ,(3, '27-inch Monitor', 249.99)

SET IDENTITY_INSERT Product OFF
