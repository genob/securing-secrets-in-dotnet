# Reading Secrets from CredStash

This sample illustrates reading secrets from [CredStash](https://github.com/fugue/credstash) in a C# app. It utilizes the [Narochno.Credstash](https://github.com/Narochno/Narochno.Credstash) (Nuget package) library's CredStash implementation of the `IConfigurationProvider'.

- no need to store secrets in appsettings.json
- reads secrets directly from secret store
- can ease secret rotation

## CredStash

CredStash is described as.. 
> "a very simple, easy to use credential management and distribution system that uses AWS Key Management Service (KMS) for key wrapping and master-key storage, and DynamoDB for credential storage and sharing." 

see: https://github.com/fugue/credstash

### CredStash library for .NET/C#

https://github.com/Narochno/Narochno.Credstash


