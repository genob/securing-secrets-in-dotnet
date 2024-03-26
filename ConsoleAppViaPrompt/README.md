# Prompt user password

- works well with interactive console-hosted apps

## on each run

- user must enter secret on each run
- 
![Command Prompt Password](command-prompt-password.png)

## prompt once and persist (Windows DPAPI)

- encrypted file is stored in the user profile
- file is not portable to other machines (or profiles)

references: https://learn.microsoft.com/en-us/aspnet/core/security/data-protection/configuration/overview?view=aspnetcore-8.0