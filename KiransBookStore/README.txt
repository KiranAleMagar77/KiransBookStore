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
now trying to add the bootswatch theme to my app

downloaded the mroph theme for my app

11:52
renamed the existing bootstrap.css file inside the wwwroot directory as bootstrap1.css
and added the new theme bootstrap file which i downlaoded inside the wwwroot/lib/bootstrap/dist/css directory 

11:55
replaced the existing code inside the site.css with given code for the project

11:57
changed the nav class from navbar-light to navbar dark and bg-white to bg-primary inside the 
views>shared>_Layout.cshtml

11:59
removed the text-dark form nav class

and added the text-white-50 bg-primary in line 39 

12:01
removed the text-dark in _loginPartial.cshtml

and rn the program to check the progress.

12:04
added the addtional stylesheet and script inside the layout.cshtml

12:06
added the dropdown inside the layout.cshtml with different actions

12:20
added the 3 new projects called 
KiranBooks.DataAccess
KiranBooks.Models
KiranBooks.Utility

12:24
and copied the data folder inside the dataaccess project and deleted the original data folder

12:25
Installing the Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages

12:27
deleted the migration folder

12:29
modified the namespace and deleted the class1.cs file from each project


12:32
i cut the model folder form it original position and added it to  kiranBooks.Models project

12:33
added the project reference---- .DataAccess and .Models

renamed model folder to view model

12:36
modified startup.cs 
