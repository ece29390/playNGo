Basically you don't need to worry about the database because the project will do that for you 
during the first run, but if for whatever reason the db failed to creat, then you need 
to go to the package manager console and type in "Update-Database" then press enter.
But be sure to check the connection string in the web.config, I already configured the connection string
in generic format. But you are welcome to modify it based on your choice.
Thanks