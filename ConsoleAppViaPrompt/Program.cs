using System.Text;

Console.WriteLine("App ConsoleAppViaPrompt v1.0\n");

var key = GetUserPropmtedPassword("Enter your API key: ");

Console.WriteLine($"\nConnecting to API via key {key}");


static string GetUserPropmtedPassword(string prompt)
{

    var passwordStringBuilder = new StringBuilder();

    ConsoleKeyInfo key;

    Console.Write(prompt);
    do
    {
        key = Console.ReadKey(true);

        if (key.Key != ConsoleKey.Enter)
        {
            passwordStringBuilder.Append(key.KeyChar);
            Console.Write("*");
        }
    } while (key.Key != ConsoleKey.Enter);

    return passwordStringBuilder.ToString();
}
