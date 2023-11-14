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

12:40
created a new class inside the kiranBooks.utility called SD.cs

Added project reference for utility in KiranBook store

12:43
Added refernce in Dataaccess project for utility and model

12:45
Added the area as customer

12:47
added the startup routes.


12:49
Moved the home controller to Area>Cutsomer>Controller folder and deleted the Data and model folder.

ran the program 

12:51
Moved the home controller to Area>Cutsomer>Controller folder and deleted the Data and model folder.

12:55
modfied the viewStart.cshtml file to reflect new path

1:00 

Added the new Area called Admin 

deleted the controllers folder 


1:07
Updated the github repo

----------------------------------------------------------------------------------------------

2023-11-13

10-07
Started to do the project again.

10:08
Build the solution to check the project error and whather it is running properly or not 

10:09
reviewed the appsettings.json

Modified the database name and saved it

10:12
Added new migration by running the code given below in pacakage manager console
add-migration AddDefultIdentityMigration

10-14
udpdated the database
update-database

10-18
checked for the sql server explorer and 
ran the application 

10:45
Added a new class called category.cs 
and modidied it

10:50
added the migration 
add-migration AddCategoryToDb

10:52
modified the applicationdbcontext.cs:

public DbSet<Category> Categories { get; set; }

10:55
again have to delete the pervious addCategoryToDb and again ran the add-migration 
after that the db was populated 

11:06
now stared to do it again 

made a Repository folder inside .dataaccess and inside repository made IRepository 


and inside that folder made a new class called IRepository and modified it 
so that it can be used in category class to do all the CRUD operation


11:22
Added the method to:
Get item from the DB
List of Categories
add object
remove object

11:52
added the new class called repository 
and modified the class 

added the code given in assignment folder
to create the contructor and dependency injection


12:05
modified the CategoryRepository.cs

12:06
modidfing the ICategoryRepository.cs

now after modifing had error in CategoryRepository.cs

now implemented the reference

12:10
now again modifing the code

built the project and it build succesfully

12:21
added a new interface inside iRepository folder and modified 

and install package daper

and again modified the code


12:28
made a new class called SP_Call.cs
--------------------------------------------------------------------------------------------


2023-11-14

11-13
Added the using in the SP_Call

using KiransBooks.DataAccess.Repository.IRepository;

and added the interface

11:43
modified the SP_call.cs


11:47
created the new interface item as UnitOfWork.cs and modififed it.

11:52
created a new class inside the Repository folder and modified it 


12:23
modified the startup.cs to make it accessible by the project 

12:26
bulid the project and corrected the errors
