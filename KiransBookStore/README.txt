2023-11-13 

11:43
Created the new app named Kiran Book Store and uploaded into github.
this time i have used dotnet5.0 and did the individual authentication.

11:45
edited the startup.cs file by deleting one line inside the bracket.
services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)

services.AddDefaultIdentity<IdentityUser>()


11:45
Created the github repo

11:47
i addded the breakpoints on the home controller file at line 22 and 27 
trying to run the program

11:50
