#  Dr. Sillystringz's Factory

#### By Yodel Guanzon <yodelguanzon@gmail.com>

#### This is an independent project to test our skills in Many-to-Many Relational Database using ASP .Net Core MVC with EF Core Migrations.

## Technologies Used

* .Net 6 SDK
* C#
* EF Core 6
* EF Core Migrations
* ASP.Net MVC
* Razor
* MySql 6
* MySql Workbench

## Description

### Dr. Sillystringz's Factory

You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.

#### User Stories
* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
* As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
* I should not be able to create an engineer or a machine if the form's fields are empty or contain invalid values.
* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed.
* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
* I should not be able to add a machine to an engineer if there are no machines. Likewise I should not be able to add an engineer to a machine if there are no engineers.
* When I access the application, I should see a splash page that lists all engineers and machines.

### Further Exploration

- [x] Add all CRUD methods to both classes.
- [x] Add properties to specify if a machine is operational, malfunctioning, or in the process of being repaired.
- [ ] Add properties to specify if an engineer is idle, or actively working on repairs.
- [ ] Add inspection dates to the machines, or dates of license renewal to the engineers.
- [ ] Add a table for incidents, showing which engineer repaired which machine.
- [ ] Add a table for locations, and specify which engineers or machines are located at which factory.
- [ ] Add styling to give life to the project.

## Setup/Installation Requirements


### Install Database Tools
* Download and install MySQL Community Server and MySQL Workbench using the following link: (https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi)

### Creating appsettings.json for Database Connection Setup
* Using a text editor, create a file. Paste the following code, replacing the USERNAME, PASSWORD with your own information. Make sure to also remove the enclosing braces.

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[USERNAME];pwd=[PASSWORD];",
      "TestConnection": "Server=localhost;Port=3306;database=factory;uid=[USERNAME];pwd=[PASSWORD];"
      
  }
}
```

* Save the file as ```appsettings.json``` under the project directory located at ../Factory.Solution/Factory.

### Building the Database

* Using the terminal, Navigate to the main project directory located at ../Factory.Solution/Factory
* Run ```dotnet restore``` to restore all dependencies (optional)
* Run ```dotnet ef database update``` command to automatically create the database using the migrations in the Factory Project
       - Optionally, you could run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration to create your own migration before running the database update command. You could do this if for some reason ../Factory.Solution/Factory/Migrations is missing.

### Running the project

* Navigate to the main project located in ../Factory.Solution/Factory using bash or cmd
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

Copyright (c) 01/06/2023 Yodel Guanzon

