# Development Environment secrets

use case: while developing an app, in this case demonstrated with console

note: environment is "Development" - this is a requirement


## how does it work

this is already inclooded in the boostraping of applications. 

`Host.CreateDefaultBuilder()`  https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.host.createdefaultbuilder?view=dotnet-plat-ext-8.0

or `WebApplication.CreateBuilder`

see: https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.webapplication.createbuilder?view=aspnetcore-8.0




`DOTNET_ENVIRONMENT` with `Host.CreateDefaultBuilder` method is called
`ASPNETCORE_ENVIRONMENT` when the `WebApplication.CreateBuilder` method is called


if you already use appsettings.json, this is an easy way to override settings without coding them into the existing appsettings.json

read: https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-8.0&tabs=windows


https://learn.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-8.0

benefits: keeps secrets separate from project (so you never check it in)


`dotnet user-secrets init`

Set UserSecretsId to '62178870-3006-484c-944a-52c3d3c558fa' for MSBuild project 'C:\Users\GeneBederak\source\repos\SecuringDevEnvironmentSamples\ConsoleApp1\ConsoleApp1.csproj'.

this create a 'secret.json'

C:\Users\{profile}\AppData\Roaming\Microsoft\UserSecrets\62178870-3006-484c-944a-52c3d3c558fa


scoped to the app

`dotnet user-secrets set "apiconfig:apisecret" "12345" `

Successfully saved apiconfig:apisecret = 12345 to the secret store.



`C:\Users\GeneBederak\source\repos\SecuringDevEnvironmentSamples\ConsoleApp1>dotnet user-secrets list`


`apiconfig:apisecret = 12345`





