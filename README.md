# ASP.NET-Core-Application

Application consists of three class libraries: 
* `PresentationLayer` (Contains View Models to read or edit database models. ViewModels properties have attributes which help validate data recived from html form)
* `BusinessLayer` (Contains Interfaces and Implmementations of these interfaces. Build on Repository pattern)
* `DataLayer` (Contains database context and entities)

Also application has `Controllers` and `Views`.
In `HomeController` class I use `servicesManager` to manipulate with data. `ServicesManager` class uses `DataManager` class which stores CRUD methods.

In Startup.cs I use services collection to set dependencies between Interfaces and Implmementations

![alt text](https://i.ibb.co/G72SdMp/q.png)


