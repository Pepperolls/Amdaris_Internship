CREATE TABLE [dbo].[Owners]
(
	[PersonalIdNo] BIGINT NOT NULL,
	[FirstName] NVARCHAR(15) NOT NULL,
	[LastName] NVARCHAR(15) NOT NULL,
	[Age] INT NOT NULL,
	[City] NVARCHAR(15) NOT NULL,
	CONSTRAINT [PK_Owners] PRIMARY KEY ([PersonalIdNo])
);

ALTER TABLE [dbo].[Owners] 
	ADD CHECK (Age > 17);

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890120', 'Rares', 'Mladin', 'Arad', '20');

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890121', 'Alex', 'Ionescu', 'Timisoara', '41');

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890122', 'John', 'Smith', 'Boston', '35');

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890123', 'Eduard', 'Streanga', 'Arad', '18');

CREATE TABLE [dbo].[Vehicles]
(
	[OwnerIdNo] BIGINT NOT NULL,
	[VehicleIdNo] BIGINT NOT NULL,
	[Make] NVARCHAR(15) NOT NULL,
	[Model] NVARCHAR(15) NOT NULL,
	[FabricationYear] INT NOT NULL,
	[CubicCapacity] INT NOT NULL,
	[FuelType] NVARCHAR(15) NOT NULL,
	CONSTRAINT [PK_Vehicles] PRIMARY KEY ([VehicleIdNo])
);

ALTER TABLE [dbo].[Vehicles] 
	ADD CHECK (FabricationYear > 1985);

ALTER TABLE [dbo].[Vehicles] ADD CONSTRAINT [Vehicles_OwnerIdNo] FOREIGN KEY ([OwnerIdNo]) REFERENCES [dbo].[Owners] ([PersonalIdNo]) ON DELETE NO ACTION ON UPDATE NO ACTION;


INSERT INTO Vehicles (OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, CubicCapacity, FuelType)
	VALUES ('1234567890120', '01', 'Dacia', 'Logan', '2008', '1600', 'Petrol'),
		   ('1234567890120', '02', 'Audi', 'A6', '2009', '3000', 'Petrol');

INSERT INTO Vehicles(OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, CubicCapacity, FuelType)
	VALUES ('1234567890121', '03', 'Audi', 'A8', '2020', '3000', 'Diesel'),
		   ('1234567890121', '04', 'BMW', '5 series', '2016', '2000', 'Diesel'),
	       ('1234567890121', '05', 'Volvo', 'XC90', '2018', '2000', 'Diesel');


INSERT INTO Vehicles(OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, CubicCapacity, FuelType)
	VALUES ('1234567890122', '06', 'Chevrolet', 'Camaro SS', '2019', '6200', 'Petrol');


INSERT INTO Vehicles(OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, CubicCapacity, FuelType)
	VALUES ('1234567890123', '07', 'Audi', 'A4', '2013', '2000', 'Diesel');

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

SELECT OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, CubicCapacity, FuelType
FROM Vehicles

SELECT City,
	AVG(Age) as AverageAge
	FROM Owners 
	GROUP BY City

SELECT Make,
	AVG(FabricationYear) as AverageFabrYear
	FROM Vehicles 
	GROUP BY Make
	HAVING AVG(FabricationYear) > 2014


CREATE TABLE [dbo].[VehiclesAux]
(
	[Make] NVARCHAR(15) NOT NULL,
	[Model] NVARCHAR(15) NOT NULL,
	[FabricationYear] INT NOT NULL,
);

INSERT INTO VehiclesAux (Make, Model, FabricationYear)
SELECT Make, Model, FabricationYear FROM Vehicles

SELECT Make, Model, FabricationYear
FROM VehiclesAux

TRUNCATE TABLE VehiclesAux

DELETE FROM Vehicles
FROM Vehicles INNER JOIN Owners ON Vehicles.OwnerIdNo = Owners.PersonalIdNo
WHERE Owners.Age < 30

INSERT INTO Vehicles (OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, CubicCapacity, FuelType)
	VALUES ('1234567890120', '01', 'Dacia', 'Logan', '2008', '1600', 'Petrol'),
		   ('1234567890120', '02', 'Audi', 'A6', '2009', '3000', 'Petrol');

INSERT INTO Vehicles(OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, CubicCapacity, FuelType)
	VALUES ('1234567890123', '07', 'Audi', 'A4', '2013', '2000', 'Diesel');

SELECT Make, Model, FabricationYear
FROM Vehicles 
WHERE
	2000 < (SELECT 
			CubicCapacity
			)

SELECT Make, Model, FabricationYear, CubicCapacity
FROM Vehicles
WHERE OwnerIdNo IN (SELECT PersonalIdNo 
					FROM Owners
					WHERE (FirstName LIKE 'R%')
						)

SELECT Make, Model,
	CASE Make 
	WHEN 'Audi' THEN CubicCapacity / 1000
	ELSE CubicCapacity
	END AS DividedCc,
	FuelType
FROM Vehicles