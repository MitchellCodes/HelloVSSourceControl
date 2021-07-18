CREATE DATABASE VehicleDB
GO

USE VehicleDB
GO

CREATE TABLE Vehicle
(
    Make varchar(30) NOT NULL,
    Model varchar(30) NOT NULL,
    Quantity tinyint DEFAULT 0
)