CREATE TABLE [dbo].[Owners]
(
	[PersonalIdNo] BIGINT NOT NULL,
	[FirstName] NVARCHAR(15) NOT NULL,
	[LastName] NVARCHAR(15) NOT NULL,
	[Age] INT NOT NULL,
	[City] NVARCHAR(15) NOT NULL,
	CONSTRAINT [PK_Owners] PRIMARY KEY ([PersonalIdNo])
);

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890123', 'Rares', 'Mladin', 'Arad', '20');

ALTER TABLE [dbo].[Owners] 
	ADD CHECK (Age > 17);

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890124', 'Rares', 'Mladin', 'Arad', '17');

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890124', 'Rares', 'Mladin', 'Arad', '18');

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

CREATE TABLE [dbo].[Vehicles]
(
	[OwnerIdNo] BIGINT NOT NULL,
	[VehicleIdNo] BIGINT NOT NULL,
	[Make] NVARCHAR(15) NOT NULL,
	[Model] NVARCHAR(15) NOT NULL,
	[FabricationYear] INT NOT NULL,
	[FuelType] NVARCHAR(15) NOT NULL,
	CONSTRAINT [PK_Vehicles] PRIMARY KEY ([OwnerIdNo])
);

ALTER TABLE [dbo].[Vehicles] 
	ADD CHECK (FabricationYear > 1985);

INSERT INTO Vehicles (OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, FuelType)
	VALUES ('1234567890123', '01', 'Dacia', 'Logan', '2020', 'Petrol');

INSERT INTO Vehicles (OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, FuelType)
	VALUES ('1234567890124', '02', 'Dacia', 'Logan', '2019', 'Diesel');

SELECT OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, FuelType
FROM Vehicles


ALTER TABLE [dbo].[Owners] ADD CONSTRAINT [Owners_PersonalIdNo] FOREIGN KEY ([PersonalIdNo]) REFERENCES [dbo].[Vehicles] ([OwnerIdNo]) ON DELETE NO ACTION ON UPDATE NO ACTION;

INSERT INTO Vehicles(OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, FuelType)
	VALUES ('1234567890125', '03', 'Audi', 'A4', '2020', 'Diesel');

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890125', 'Eduard', 'Streanga', 'Arad', '18');

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

SELECT OwnerIdNo, VehicleIdNo, Make, Model, FabricationYear, FuelType
FROM Vehicles