Author name : Shalil Dsilva
Program name : ShalilBookStore
Program purpose : Create an MVC ASP.NET application using .NET core 5.0 
Date created : 2023-10-29 8:00 pm EDT


2023-10-29

8:00 pm EDT 
Created a project an mvc asp.net core web app named ShalilBookStore
Changed the authentication to individual accounts
Updated the Startup.cs file
created a git repository and pushed.

8:18 pm EDT
Added two breakpoints in the HomeController.cs file to debug the project
Ran the project and got the output with zero errors

8:34 pm EDT
Selected the Quartz theme from Bootswatch.com
replaced the existing themes with my Quartz theme
Changed the navigation bar from light to dark and background from white to primary from _Layout.cshtml
Changed css from _loginPartial.cshtml
Ran the project to view changes 

9:10 pm EDT
Added additional stylesheets and scripts provided to _Layout.cshtml
Added a dropdown feature to the navbar
ran the project 


2023-10-30

10:30 am EDT
Created three new projects named ShalilsBooks.DataAccess, ShalilsBooks.Models and ShalilsBooks.Utility in the current project
Copied data folder from the main project and pasted it to the .DataAccess folder
Installed Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages

11:15 am EDT
Installed NuGet package
Deleted the default Class1.cs file in all the projects
Build the project and got some errors
Moved Models from ShalilBookStore to ShalilsBooks.Models
Modified Error.cshtml file

11:49 am EDT
Added ShalilsBooks.DataAccess, ShalilsBooks.Models to ShalilBookStore using Reference Manager
Modified Startup.cs file by adding an AddContext with using statement
Removed unwanted using statements
Correxted the default reference view of ErrorViewModel
All the errors were resolved
Ran the application successfully

9:15 pm EDT
Created a class called SD.cs in Utility project
Added project reference to the main project

9:33 pm EDT
Added a Customers area to the Areas folder
Updates the routes in the startup.cs according to the ScaffoldingReadMe.txt
Move the HomeController.cs to the Area->Customer->Controller folder
Ran the application which outputed as a page with no styles

10:14pm EDT
Copied the _ViewImport and _ViewStart to Customer Area
Ran the application which resulted in app running with the required css

11:30pm EDT
Added a new admin area in the Areas folder
Updated the files in a similar way as the Customer folder
Updated the Github repo with a completed part 1 of the project

12:49pm EDT
updated the home page


2023-11-06

11:27am EDT
Edited the appsettings.json to show ShalilsBookStore as database name
ran "add-migration AddDefaultIdentityMigration" command in the package manager console by selecting ShalilsBooks.DataAccess as default project

12:22pm EDT
Updated the database by running update-database cmd
ran the project to check if runs successfully

1:06pm EDT
Added a new class to the models project
added migration via pm console
the new migartion file was empty because it was not added to db context file
update the db context file and rerunned the command 
got an error for duplicate file 
deleted the previously created migration file and ran the add migartion cmd again
ran the update-database cmd
project run successfully without errors