# Keep Local Development Secrets Secure with Microsoft Secret-Manager

Keep development secrets secure in .NET using the Secrets Manager

From [Microsoft Documentation](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-8.0&tabs=windows#secret-manager)...

> The Secret Manager tool stores sensitive data during application development. In this context, a piece of sensitive data is an app secret. App secrets are stored in a separate location from the project tree. The app secrets are associated with a specific project or shared across several projects. The app secrets aren't checked into source control.

## Supported natively

Already included in the boostraping of most .NET apps. 

- `Host.CreateDefaultBuilder()`: see [docs](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.host.createdefaultbuilder?view=dotnet-plat-ext-8.0)

- `WebApplication.CreateBuilder`:  see: [docs](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.webapplication.createbuilder?view=aspnetcore-8.0)

:notebook: This approach will only work when hosting environment is "Development" 

- `DOTNET_ENVIRONMENT` with `Host.CreateDefaultBuilder` method is used
- `ASPNETCORE_ENVIRONMENT` when the `WebApplication.CreateBuilder` method is used



### Points
- scoped to the app / project
- stored secrets in```%APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json```
- `user_secrets_id` is a guid generated on startup and embedded into `csproj` file
- the tool is used to manage secrets


### tool usage

- Initialize: `dotnet user-secrets init`  (can also be done from UI)
- List Secrets: `dotnet user-secrets list`
- Clear Secrets: `dotnet user-secrets clear`
- Set Secret: `dotnet user-secrets set "apiconfig:apisecret"`
- Remove Secret: `dotnet user-secrets remove "apiconfig:apisecret"`

:notebook:You execute the command from the folder of the project.. i.e

```command
C:\Users\GeneBederak\source\repos\SecuringDevEnvironmentSamples\ConsoleApp1>dotnet user-secrets list
```

### Pros
- **Supported Natively** - supported in the boostraping of most .NET apps
- **Separate from Project Tree**: App secrets are stored in a separate location from the project tree, reducing the risk of compromise
- **Contextual to the project**: easy isolation of secrets from other apps (vs Env variables which could be more 'global')
- 
### Cons

- **No encryption** - The Secret Manager tool doesn't encrypt the stored secrets and shouldn't be treated as a trusted store. It's for development purposes only. The keys and values are stored in a JSON configuration file in the user profile directory. 
- **Still stored in a file** on the OS: 
  ```%APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json```







