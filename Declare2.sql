SELECT * FROM SALT

DECLARE @ISIM AS VARCHAR(100)
DECLARE @TELEFON AS VARCHAR(1OO)

SELECT
@ISIM = ISIM, @TELEFON = TELEFON * FROM SALT WHERE ID = 1


SELECT @ISIM,@TELEFON


DECLARE @TARIH AS DATETIME
SET @TARIH=GETDATE()

SELECT @TARIH