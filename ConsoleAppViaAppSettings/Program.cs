using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder().Build();

var config = host.Services.GetService<IConfiguration>();
var apiKey = config["apikey"];

Console.WriteLine($"API Key: {apiKey}");

