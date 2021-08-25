SET IMPLICIT_TRANSACTIONS ON;

SELECT @@TRANCOUNT

SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners
WHERE PersonalIdNo = 1234567890120;

SELECT @@TRANCOUNT

UPDATE Owners
SET FirstName = 'ImplicitDemo'
WHERE PersonalIdNo = 1234567890120;

ROLLBACK TRANSACTION

SELECT @@TRANCOUNT

select  
    object_name(p.object_id) as TableName, 
    resource_type, resource_description
from
    sys.dm_tran_locks l
    join sys.partitions p on l.resource_associated_entity_id = p.hobt_id
