Options for securing

- appsettings.Development.json
- Environment variables
- microsoft secrets mananger (.net CORE apps)
- Cred stash (naroncho)
- prompt for user input on each run
- prompt for user input and persist
- powershell scripts


https://learn.microsoft.com/en-us/aspnet/core/security/data-protection/configuration/overview?view=aspnetcore-8.0





..from AG
Running Playwright...

prompt for 

    // Instantiate the secure string.
    SecureString securePwd = new SecureString();
    ConsoleKeyInfo key;

    Console.Write("Enter password: ");
    do {
       key = Console.ReadKey(true);
       
       // Ignore any key out of range.
       if (((int) key.Key) >= 65 && ((int) key.Key <= 90)) {
          // Append the character to the password.
          securePwd.AppendChar(key.KeyChar);
          Console.Write("*");
       }   
    // Exit if Enter key is pressed.
    } while (key.Key != ConsoleKey.Enter);
    Console.WriteLine();