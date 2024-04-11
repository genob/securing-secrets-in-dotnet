using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder().Build();

var config = host.Services.GetService<IConfiguration>();

var apiKey = config["MY_API_KEY"];

Console.WriteLine($"API Key: {apiKey}");

