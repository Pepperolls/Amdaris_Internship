SELECT @@TRANCOUNT

BEGIN TRANSACTION
SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners
WHERE PersonalIdNo = 1234567890120;

SELECT @@TRANCOUNT

COMMIT TRANSACTION

SELECT @@TRANCOUNT

BEGIN TRANSACTION
UPDATE Owners
SET FirstName = 'ImplicitDemo'
WHERE PersonalIdNo = 1234567890120;

SELECT @@TRANCOUNT

COMMIT TRANSACTION
-- Vom avea 'ImplicitDemo' in loc de numele cautat
ROLLBACK TRANSACTION
-- Vom avea din nou numele initial, in loc de 'ImplicitDemo'

SELECT @@TRANCOUNT