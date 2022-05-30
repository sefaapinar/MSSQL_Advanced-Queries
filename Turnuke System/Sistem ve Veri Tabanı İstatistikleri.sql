
SELECT * FROM sys.dm_exec_procedure_stats --SİSTEM ÜZERİNDE VAR OLAN ÇALIŞMA SÜRELERİNİ GÖSTERİR.

SELECT DB_NAME(database_id),
* FROM  sys.dm_exec_procedure_stats WHERE DB_NAME(database_id)='ETRADE'