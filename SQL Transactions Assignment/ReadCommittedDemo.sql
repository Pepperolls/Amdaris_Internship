SET TRANSACTION ISOLATION LEVEL REPEATABLE READ

BEGIN TRANSACTION

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890124', 'Radu', 'Matei', 'Arad', '21');

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

ROLLBACK TRANSACTION
COMMIT TRANSACTION
