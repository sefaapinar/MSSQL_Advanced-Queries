CREATE FUNCTINOS DBO.GET_ITEM_INFO(@ITEMID INT)
RETURNS TABLE
AS
RETURN
(
SELECT MIN(UNITPRICE) AS MINPRICE,
 MAX(UNITPRICE) AS MAXPRICE,
 AVG(UNITPRICE) AS AVGPRICE,
 SUM(UNITPRICE) AS SUMPRICE,
 SUM(LINETOTAL) AS TOTALSALE,

FROM ORDERDETAILS WHERE ITEMID = @ITEMID
)

SELECT * FROM DBO.GET_ITEM_INFO(3)
