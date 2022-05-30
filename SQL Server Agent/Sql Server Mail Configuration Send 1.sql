EXEC msdb.dbo.sp_send_dbmail
	@profile_name = 'SQLMAIL',
	@recipients = 'sefapinar224@gmail.com',
	@body = 'Merhaba bu bir test mailidir.',
	@subject = 'TEST';   --OTOMATİK TEST MAILI GONDERME
