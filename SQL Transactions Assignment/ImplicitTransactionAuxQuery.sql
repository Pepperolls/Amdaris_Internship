SELECT PersonalIdNo, FirstName, LastName, Age, City 
FROM Owners
WHERE PersonalIdNo = 1234567890120;

-- Running this after executing a transaction from ImplicitTransaction without committing the transaction will have us waiting, because a lock has been created.
-- For example, when running:   UPDATE Owners
--								SET FirstName = 'ImplicitDemo'
--								WHERE PersonalIdNo = 1234567890120;

-- This does not happen in AutoCommitTransactions, because they commit them automatically for us (as the name suggests)