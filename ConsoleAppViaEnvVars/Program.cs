using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder().Build();

var config = host.Services.GetService<IConfiguration>();

// make sure you have the environment variable set first, see README.md
var apiKey = config["MY_API_KEY"];

Console.WriteLine($"API Key: {apiKey}");

