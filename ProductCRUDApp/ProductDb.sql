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