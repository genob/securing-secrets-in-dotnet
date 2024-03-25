using System.Text;

var passwordBuilder = new StringBuilder();

ConsoleKeyInfo key;

Console.Write("Enter password: ");
do
{
    key = Console.ReadKey(true);

    // Check if the key is not Enter (to end password input)
    if (key.Key != ConsoleKey.Enter)
    {
        // Append the character to the password builder
        passwordBuilder.Append(key.KeyChar);
        Console.Write("*");
    }
} while (key.Key != ConsoleKey.Enter);

string password = passwordBuilder.ToString();

Console.WriteLine($"\nConnecting to API via key {password}");
