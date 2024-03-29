using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Text.Json;


public class Program
{

    private static string UserSettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".myapp1", "usersettings.json");

    public static void Main(string[] args)
    {
        // add data protection services
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddDataProtection();
        var services = serviceCollection.BuildServiceProvider();

        // create an instance of MyClass using the service provider
        var instance = ActivatorUtilities.CreateInstance<MyClass>(services);
        instance.RunSample();
    }

    public class MyClass
    {
        IDataProtector _protector;

        // the 'provider' parameter is provided by DI
        public MyClass(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("Contoso.MyClass.v1");
        }

        public void RunSample()
        {

            var key = GetOrSave();

            Console.WriteLine($"Unprotect returned: {key}");
        }
        private string GetOrSave()
        {
            if (File.Exists(UserSettingsPath))
            {
                
                var settings = JsonSerializer.Deserialize<MyAppSettings>(File.ReadAllText(UserSettingsPath));
                var protectedKey = settings.ApiKey;
                var unprotectedKey = _protector.Unprotect(protectedKey);
                Console.WriteLine($"found key in settings: {unprotectedKey}");
                return unprotectedKey;
            }
            else
            {
                Console.Write("Enter your API key: ");
                var key = Console.ReadLine();
                string Protectedkey = _protector.Protect(key);

                if (!File.Exists(UserSettingsPath)) {
                    Directory.CreateDirectory(Path.GetDirectoryName(UserSettingsPath));
                }
               
                var appSettings = new MyAppSettings() { ApiKey = Protectedkey };

                var serializedSettings = JsonSerializer.Serialize(appSettings);
   
                File.WriteAllText(UserSettingsPath, serializedSettings);

                return key;
            }
        }



    }

    public class MyAppSettings
    {
        public string ApiKey { get; set; }
    }
}