SELECT @@TRANCOUNT

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners
WHERE PersonalIdNo = 1234567890120;

SELECT @@TRANCOUNT

UPDATE Owners
SET FirstName = 'Raresh'
WHERE PersonalIdNo = 1234567890120;

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

SELECT @@TRANCOUNT

UPDATE Owners
SET FirstName = 'Rares'
WHERE PersonalIdNo = 1234567890120;

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners

SELECT @@TRANCOUNT