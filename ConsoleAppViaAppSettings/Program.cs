using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder().Build();

var config = host.Services.GetService<IConfiguration>();
var apiKey = config["apikey"];

var environment = host.Services.GetService<IHostEnvironment>();
Console.WriteLine($"Current Environment: {environment.EnvironmentName}");

Console.WriteLine($"API Key: {apiKey}");

