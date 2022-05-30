--CURSOR İşlemi : Bir data setinin içerisinde bizim döngüyle dönüp, bir takım işleri yaptırmamız gerekir. Bu İşlem c#'da for döngüsüdür.

SELECT * FROM USERS 

WHERE DAY(BIRTHDATE) =25 AND MONTH(BIRTHDATE) = 4


UPDATE USERS SET EMAIL = 'sqlserver.egitim@gmail.com' WHERE DAY(BIRTHDATE) =25 AND MONTH(BIRTHDATE) = 4

msdb.dbo.sp_send_dbmail @profil_name = 'SQLMAIL',  -- Kullanıcının mail hesabına bilgi gönderme.
@SUBJECT ='MUTLU YILLAR',
@BODY = 'Sayın Sefa Pınar. Merhaba',
@recipients = 'sqlserver.egitim@gmail.com'



SELECT *,DATEDIFF(YEAR,BIRTHDATE,GETDATE()) FROM USERS
WHERE DAY (BIRTHDATE) = 25 AND MONTH(BIRTHDATE) = 4


DECLARE @NAMESURNAME AS VARCHAR(50) = 'Sefa Pınar'
DECLARE @AGE AS INT = 27
DECLARE @EMAIL AS VARCHAR(100) = 'sqlserver.egitim@gmail.com'
DECLARE @MSG AS VARCHAR(500)
SET @MSG = 'SAYIN' + @NAMESURNAME + ', Doğum Gününüz Kutlu Olsun.'+ CONVERT(VARCHAR,@AGE) + '. Yaşınızı kutlar sağlıklı yıllar dileriz.'



--CURSOR YAZIMI

--İLK ÖNCE İSİM VERİLİR = CRS, SONRA CURSOR OLDUĞU ANLATILIR, Daha sonra hangi SQL Server cümlesi için çalışacağı anlatılır.

DECLARE CRS CURSOR FOR 
SELECT NAMESURNAME, DATEDIFF(YEAR,BIRTHDATE,GETDATE()) AS AGE, EMAIL
FROM USERS WHERE DAY(BIRTHDATE) =25 AND  MONTH(BIRTHDATE) = 4
OPEN CRS --CURSOR AÇILIR.
FETCH NEXT FROM CRS INTO --CURSORUN BİR SONRAKİ SATIRINA GEÇ.
 @NAMESURNAME, @AGE,@EMAIL

 WHILE @@FETCH_STATUS = 0 --FETCH_STATUS Son satıra gelip gelmediğimizi anlar. 
 BEGIN


 SELECT @NAMESURNAME


 END
CLOSE CRS
DEALLOCATE CRS --CURSORU HAFIZADAN SİLME








