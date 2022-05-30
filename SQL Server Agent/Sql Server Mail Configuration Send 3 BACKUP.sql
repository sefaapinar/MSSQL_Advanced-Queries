EXEC msdb.dbo.sp_send_dbmail
	@profile_name = 'SQLMAIL',
	@recipients = 'sefapinar224@gmail.com',
	@body = 'BACKUP process succesfly',
	@subject = 'YEDEK ALINDI';