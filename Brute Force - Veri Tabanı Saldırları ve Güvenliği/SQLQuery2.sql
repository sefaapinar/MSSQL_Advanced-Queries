EXEC msdb.dbo.sp_send_dbmail
@profile_name = 'SQLMAIL',
@recipients = 'softwarehsp@gmail.com',
@body = 'This is a test mail body',
@subject = 'test mail';