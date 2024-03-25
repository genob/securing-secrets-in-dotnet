using Amazon;
using Amazon.Runtime;
using Microsoft.Extensions.Configuration;
using Narochno.Credstash.Configuration;

var builder = new ConfigurationBuilder();

var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

AWSCredentials creds = new StoredProfileAWSCredentials();

if (!environmentName.Equals("Development"))
{
	creds = new InstanceProfileAWSCredentials();
	builder.AddCredstash(creds, new CredstashConfigurationOptions()
	{
		EncryptionContext = new Dictionary<string, string>()
		{
			{"environment", environmentName}
		},
		Region = RegionEndpoint.USEast1
	});
}
