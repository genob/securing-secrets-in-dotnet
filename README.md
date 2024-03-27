# Securing Serets in .NET Applications (C# and Powershell)

This repository is a collection of projects that  provide examples of how to secure secrets in applications and scripts. The examples are provided in C# and Powershell and are generally geared toward the Microsoft stack, however the concepts can be applied more broadly. 

Additionally the projects can be used as a starting points and template for new projects. Samples include console/web applications and scripts that demonstrates how to secure secrets in a .NET Core application.

- C# Examples
  - [Secrets in appsettings.json](./ConsoleAppViaAppSettings/README.md)
  - [Environment variables](./ConsoleAppViaEnvVars/README.md)
  - [microsoft secrets mananger](./ConsoleAppViaSecretManager/README.md) (.net CORE apps)
  - [Secrets in Cred Stash](./ConsoleAppViaCredStash/README.md) 
  - [Prompt user for secret on](./ConsoleAppViaPrompt/README.md)
    - prompt on each run 
    - prompt and persist (Windows DPAPI)
  - [interacting with AWS services](./ConsoleAppViaAws/README.md)
- [Powershell Examples](./Powershell/README.md)



