CREATE VIEW VW_TOP10_KATEGORI
AS

SELECT 
KATEGORI1,SUM(SATIRTOPLAMI) AS TOPLAMTUTAR
 FROM VW_SIPARIS_DETAYLI

 GROUP BY KATEGORI1
 ORDER BY SUM(SATIRTOPLAMI) DESC

 SELECT * FROM VW_TOP10_KATEGORI