# Blog

## Project Description
This is a ASP.Net Core API based project where Angular was used as Front end & SSMS as database management system. In this project, user can see the multiple blogs of admin. Only Admin can create, update & delete any blog. To help user which blog would be fit for their reading, a pre-review version of tha blog will visualize first with title, summery & a detail button. With the help of the detail button, user can dive into the detail part of that blog. 


##### Table of Contents  
[How to Install and Run the Project](#How_to_Install_and_Run_the_Project)  
[How to Use the Project](#How_to_Use_the_Project)     
<a name="headers"/>

## How to Install and Run the Project
***
Installation
* [.NET 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) : SDK 7.0.102
* [Visual Studio](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false) : 2022
* [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) : 2019
* [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) : 19
* [Visual Studio Code](https://code.visualstudio.com/download) : Version 1.74
* [Node JS](https://nodejs.org/en/download/) : Version: 18.13.0
Command 
* In CMD "npm install -g @angular/cli"
To run the project  
* Open SQL Server Management Studio & connect using default server name with windows authentication
* Edit server name in appsettings.json file along with yout preferable Database Name 
* Run backend version of the project & note the port number of localhost
* Add the port number in Frontend\TheDevBlog\src\environments\environment.ts
* Locate Frontend\TheDevBlog\tsconfig.json in CMD &
* Finally run frontent of the project by "ng serve -o" command 

## How to Use the Project
* User can see all the blog that stored in database
* To add any post, go to https://localhost:<Enter Web API Posrt Number>/api/Post/
 
