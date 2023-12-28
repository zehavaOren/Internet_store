# webProjeact
*The site was written in ASP.NET Core 6
*with web- API, using rest API (End poins)
*this is a monolithic server
*using layers:
application= with controllers, wwwroot, and middleware
service= for business logic
repository= for connecting to the database and performing actions
DTO= to transfer data to the client
mapping objects= using AutoMapper
*the layers are connected using dependency injection, and an ORM library of Entity Framework Core 6, using a database-first approach
*special attention was given to scaling, using async-await and adding browser caching (client-side caching)
*error handling was implemented for all server-side errors by writing an error handling middleware, and all errors are logged and the manager is notified, using NLog library
*configurations are used for future changes
*all entrance to the site are recorded using rating middleware
*The site was written in clean code