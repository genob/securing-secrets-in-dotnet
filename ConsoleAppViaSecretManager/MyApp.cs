using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal record MyAppConfig(string ApiKey, string ApiSecret);
	
	internal class MyApp : IHostedService
	{
		private readonly MyAppConfig _config;

		public MyApp(MyAppConfig config)
        {
			_config = config;
		}
        public Task StartAsync(CancellationToken cancellationToken)
		{
			Console.WriteLine(_config);

			Console.WriteLine("press any key to exit");
			Console.ReadKey();
			return Task.CompletedTask;
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}
	}
}
