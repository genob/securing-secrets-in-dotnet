using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder().Build();

var config = host.Services.GetService<IConfiguration>();

var apiKey = config["apiconfig:apikey"];
var apiSecret = config["apiconfig:apisecret"];

Console.WriteLine($"API Key: {apiKey}, {apiSecret}");


