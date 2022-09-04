XP_CMDSHELL 'dir c:\' --Bu komut içerisine cmd komutlarýný alýr.

sp_configure 'show advanced options',1
reconfigure with override;


sp_configure 'XP_CMDSHELL',1
reconfigure with override;


