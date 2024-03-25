using ConsoleApp1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using System.Reflection;

var builder = Host.CreateDefaultBuilder()
	// automatically calls ConfigureAppConfiguration and configures default
	//.ConfigureAppConfiguration((a) => { 
	//	a.AddUserSecrets
	//})
	.ConfigureServices((hostingContext, services) =>
	{
		services.AddHostedService<MyApp>(
			x => new MyApp(
				new MyAppConfig(hostingContext.Configuration["apiconfig:apikey"], hostingContext.Configuration["apiconfig:apisecret"]))
			);
		//IoC config
	});



using var builtHost = builder.Build();


await builtHost.RunAsync();

