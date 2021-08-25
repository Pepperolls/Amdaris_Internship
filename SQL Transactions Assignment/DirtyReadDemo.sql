SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

BEGIN TRANSACTION

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

INSERT INTO Owners (PersonalIdNo, FirstName, LastName, City, Age)
	VALUES ('1234567890124', 'Radu', 'Matei', 'Arad', '21');

UPDATE Owners
SET FirstName = 'DirtyRead'
WHERE PersonalIdNo = '1234567890120'

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

ROLLBACK TRANSACTION

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

COMMIT TRANSACTION

DELETE FROM Owners
WHERE PersonalIdNo = '1234567890124'