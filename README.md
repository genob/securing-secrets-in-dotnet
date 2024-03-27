# Securing Secrets in .NET Applications (C# and Powershell)

This repository is a collection of projects that  provide examples of how to secure secrets in applications and scripts. The examples are provided in C# and Powershell and are generally geared toward the Microsoft stack, however the concepts can be applied more broadly. 

Additionally the projects can be used as a starting points and template for new projects. Samples include console/web applications and scripts that demonstrates how to secure secrets in a .NET Core application.

- C# Examples
  - [Secrets in appsettings.json](./ConsoleAppViaAppSettings/README.md)
  - [Secrets in Environment variables](./ConsoleAppViaEnvVars/README.md)
  - [Secrets in Microsoft Secrets Mananger](./ConsoleAppViaSecretManager/README.md)
  - [Secrets in Cred Stash](./ConsoleAppViaCredStash/README.md) (with AWS)
  - [Prompt user for secret on](./ConsoleAppViaPrompt/README.md)
    - prompt on each run 
    - prompt and persist (Windows DPAPI)
  - [interacting with AWS services](./ConsoleAppViaAws/README.md)
- [Powershell Examples](./Powershell/README.md)

## No Perfect Implementation

The examples in this repository illustrate various approaches to securing secrets in applications.  The degrees of 'level of security' vary, as does the level complexity.  There is no perfec / secure implementation.  Use your brain and tailor implementation to the context at hand.  Additionally, remain vigilant, continuously update your security knowledge, and adapt to evolving threats to maintain the integrity and confidentiality of your applications' secrets.


