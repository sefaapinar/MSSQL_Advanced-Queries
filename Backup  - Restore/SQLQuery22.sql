﻿DECLARE @I AS INT = 0
WHILE @I<1000
BEGIN

	INSERT INTO DATES (DATE_)
	VALUES (GETDATE())
	WAITFOR DELAY '00:00:01'  -- BİR SANIYE BEKLETME KOMUTU


END

SELECT * FROM DATES ORDER BY 1 DESC
