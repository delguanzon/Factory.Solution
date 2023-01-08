#  Eau Claire's Salon

#### By Yodel Guanzon <yodelguanzon@gmail.com>

#### This is an independent project to test our skills in Web Application with a Database using ASP .Net Core MVC.

## Technologies Used

* .Net 6 SDK
* C#
* EF Core
* ASP.Net MVC
* Razor
* MySql 6
* MySql Workbench

## Description

Eau Claire's Salon
You've been referred by Pierre to his friend Claire who is the owner of a hair salon called Eau Claire's Salon. She has contracted you out to create an MVC web application to help her manage her employees (stylists) and their clients. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist.

User Stories
As the salon owner, I need to be able to see a list of all stylists.
As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
As the salon owner, I need to add new stylists to our system when they are hired.
As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.


## Setup/Installation Requirements


### Install Database Tools
* Download and install MySQL Community Server and MySQL Workbench using the following link: (https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi)

### Database Import

* Clone this repository on your desktop
* Open MySQL WorkBench, Look for the Navigator Panel and then click on the Administration Tab.
* From the Administration Tab, click on Data Import/Restore under the Management Section.
* A data import tab would appear, choose Import from Self-Contained File under Import Options.
* Navigate to the top directory of the solution folder and double click on yodel_guanzon.sql file.
* Click on Start Import to create the needed Database Schema and tables in your server.

### Database Connection Setup
* Using a text editor, create a file. Paste the following code, replacing the USERNAME, PASSWORD with your own information. Make sure to also remove the enclosing braces.

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=yodel_guanzon;uid=[USERNAME];pwd=[PASSWORD];",
      "TestConnection": "Server=localhost;Port=3306;database=yodel_guanzon;uid=[USERNAME];pwd=[PASSWORD];"
      
  }
}
```
* Save the file as ```appsettings.json``` under the project directory located at ../HairSalon.Solution/HairSalon.

### Running the project

* Navigate to the main project located in ../HairSalon.Solution/HairSalon using bash or cmd
* Use ``` dotnet restore ``` to install/restore dependencies.
* For Building, use ```dotnet build```
* For running the console application with a watcher, use ```dotnet watcher run```
* After running the project, you can also open the webapp using your browser manually using the following url (https://localhost:5001/) or (http://localhost:5000/)

## Known Bugs

* None

Found a bug? Email me at <yodelguanzon@gmail.com>

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 12/23/2022 Yodel Guanzon

