# Work Application homework

This is a simple Rest-API for storing information about devices and their attachments. For a scenario where you have many diffrent devices spread out in a location, and need to keep track on what I/O they have. The whole project is based on multiple available tutorials on dotnet.

Devices= devices

Extra= Attachments to devices, input/output

Application= software/apps installed on the device, in this case sender/receiver


## implemented:

-Framework: ASP.NET

-Data access: Entity Framework Core

-Database: SQLite

-API documentation : Swagger at [address]/swagger

-Database migrations



This build is to be run locally.
```
dotnet run
```



this would be all extra added.
```
dotnet tool install -g Microsoft.dotnet-httprepl
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Screenshot of the swagger api documentation

![Swagger api doc](swagger_screenshot.png)