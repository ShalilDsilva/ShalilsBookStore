Author name : Shalil Dsilva
Program name : ShalilBookStore
Program purpose : Create an MVC ASP.NET application using .NET core 5.0 
Date created : 2023-10-29 8:00 pm EDT

Assignment-2 part-1

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


Assignment-2 part-2

2023-11-06

11:27am EDT
Edited the appsettings.json to show ShalilsBookStore as database name
ran "add-migration AddDefaultIdentityMigration" command in the package manager console by selecting ShalilsBooks.DataAccess as default project
a file named 20231106162113_AddDefaultIdentityMigration was created in migration folder

12:22pm EDT
Updated the database by running update-database cmd
ran the project to check if runs successfully

1:06pm EDT
Added a new class to the models project
added migration via pm console
a file named 20231106175021_AddCategoryToDb was created in migration folder
the new migartion file was empty because it was not added to db context file
update the db context file and rerunned the command 
got an error for duplicate file 
deleted the previously created migration file and ran the add migartion cmd again
ran the update-database cmd
project run successfully without errors

1:59pm EDT
Created a new folder Repository in the DataAccess Project
Created a new IRepository folder in the Repository folder
Added an interface class IRepository.cs in the folder
Modified it so it can be used on Category class to do all the CRUD operations
Added a new class Repository.cs in the Repository folder
Modified the code in Repository.cs to create constructors and DI

Added a new CategoryRepository and ICategoryRepository files in the following folders
updated the files 
Ran the code without any errors

8:35pm EDT
Created a new interface ISP_Call.cs in the IRepository folder
Added a new class SP_Class.cs 
Added new files UnitOfWork and IUnitOfWork 
Updated the startup.cs file to add the above files


9:07pm EDT
Added a new MVC Controller CategoryController in the Areas/Admin folder
Modified the code by the provided code
Added a new folder in Areas/View with name Category
Created a razor view named index.cshtml in it
Updated the _Layout.cshtml file to display new changed

9:25pm EDT
Added a category.js file to display icons from font awesome site
in index file added the @section call to get the javascript file

9:58pm EDT
Added Upsert.cshtml file to create category
added partial views named _CreateAndBackToListButton and _EditAndBackToListButton
Made changes to Index.cshtml file to view Upsert file


2023-11-12

6:42pm EDT
Created Upsert post action method in categorycontroller file
added void save method to the iunitofwork file

8:42pm EDT
Added the API call for HTTPDelete in the categorycontroller file
Implemented the HTTPDelete with a delete method in category.js file
Added Delete function in the category.js file


2023-11-13

4:42pm EDT
Delete functunality was not working because of some typo in category.js file
Comitted to github without any errors.


Assignment-2 part-3

4:45pm 
Created CoverType CRUD with the same methods used for Category CRUD
Addded CoverType to the repository
a new file 20231117194021_AddCoverTypeToDb was created
Performed CRUD operations on CoverType

5:15pm
Added a new Class Product in .Models folder
Ran cmds to add migration and update database, a new file 20231117220633_addProductToDb was created
updated the product class to make some fields required
Ran cmds to add migration and update database, a new file 20231117221117_addValidationToProduct was created

5:33pm
Added ProductRepository class to the repository folder 
Added IProduct interface
Added Product to unitofwork and Iunitofwork

9:11pm
Added Product Controller
Installed a package to include IWebHostEnvironment
Created a viewmodel for project models name ProductVM
Modified the ProductVM and installed the ViewFeatures package
Modified the productcontroller class
Added an Index view for product model similar to the category model
Modified the _layout.cshtml file to add a new link to the product
Program ran with an exception.


2023-11-22

11:35pm
Created an Upsert for the product
Added a rich text box from tiny.cloud
Added a new folder in wwwroot
In ProductController uncommented the HTTP Post API Call
Got Errors 


2023-11-28

9:04 am
Solved error by making changes in the product controller file and product.js file from the github link provided
Got Error in the Upsert file of product solved it by refering the github link provided
Created the front page, which displays the product information.

9:10 am
Edited the Upsert file in the product, to show the selectlist in black color for more visibility