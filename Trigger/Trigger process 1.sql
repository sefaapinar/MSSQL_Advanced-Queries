SELECT * FROM ITEMS

SELECT IOTYPE,SUM(AMOUNT),COUNT(IOTYPE) FROM ITEMTRANSACTIONS WHERE ITEMID = 1 
GROUP BY IOTYPE 

SELECT *, (SELECT SUM(AMOUNT) FROM ITEMTRANSACTIONS WHERE ITEMID=ITM.ID AND IOTYPE =1) AS GIRISMIKTARI FROM ITEMS ITM
WHERE ID = 1

SELECT *, (SELECT SUM(AMOUNT) FROM ITEMTRANSACTIONS WHERE ITEMID=ITM.ID AND IOTYPE =2) AS CIKISMIKTARI FROM ITEMS ITM
WHERE ID = 1

SELECT COUNT(*) FROM ITEMTRANSACTIONS