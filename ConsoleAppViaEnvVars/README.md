# Reading Secrets from Environment Variables


- works with default configuration builders
- keeps secrets out of `appsettings.json` 
- let's the environment control the secret

```csharp
var host = Host.CreateDefaultBuilder().Build();
var config = host.Services.GetService<IConfiguration>();

// make sure you have the environment variable set first
var apiKey = config["MY_API_KEY"];
```




## Setting the Secret Environment Variable

Before running the application, you need to set the environment variable `MY_SECRET_KEY` to the desired value. How you set this depends on your operating system:

### Windows (Command Prompt)

On Windows, you can set an environment variable in the command prompt 

#### Temporary env variable in current command prompt session
```
set MY_API_KEY=1234567
```

#### Permanent env variable

##### For the current user

```
setx MY_API_KEY "1234567"
```

##### For the system (requires administrative privileges)

```
setx MY_API_KEY "1234567" /M
```

Note that changes made with setx will not affect existing Command Prompt sessions, only new ones.


### Powershell

#### Temporary Variables
In PowerShell, to set an environment variable for the current session:


```
$env:MY_API_KEY = "1234567"
```

### Linux/MacOS

On Linux or macOS, you can use the following in the terminal
```
export MY_API_KEY=1234567
```

After setting the environment variable, when you run the application, it should read and display the secret. Remember, environment variables are a suitable place for storing configuration values but ensure they are managed securely, especially when dealing with secrets or sensitive information.


references:

- [Environment Variables in .NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-8.0#environment-variables)


## Pros and Cons of storing Dev secrets in Environment Variables

### Pros

- **Security**: Environment variables are often considered more secure than settings files as they can be managed separately from the application code, reducing the risk of accidental exposure in source control.
- **Flexibility**: Easy to change and manage across different environments without needing to change application code or configuration files.
Isolation: Keeps sensitive keys out of the application's codebase and configuration files, reducing the risk of leaking sensitive data.
- **12-factor-friendly** - follows [12-Factor app](https://12factor.net/) principles even on the local development environment

### Cons

- **Less Convenient**: Managing and setting environment variables can be more cumbersome (than simply editing a settings file) local in development environments.
- **Exposure Risk** - could be exposed in command line history (when setting the variable)
