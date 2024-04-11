# Reading secrets from appsettings.Development.json

- keep your "development" secrets out of `appsettings.json` 
- use `appsettings.Development.json` instead
- add `appsettings.Development.json` to `.gitignore`


downsides of this approach:
- secrets are store unencrypted in the settings file
- risk of checking in the file into source

## Add appsettings.Development.json to .gitignore

this will ensure you do not accidentally check in your secrets into source control

![Appsettings Development](appsettings-development.png)

## Checklist

- Add `appsettings.json` file
- Add `appsetting.Development.json` file
- On both files, set the `Copy to Output Directory` setting to `Copy if Newer` or `Always`
- Ensure the Environment varialble is set to `Development`
    - For console host apps, use `DOTNET_ENVIRONMENT`
    - For web apps, use `ASPNETCORE_ENVIRONMENT`
- :exclamation: add `appsettings.Development.json` to .gitignore
- (optional) add `appsettings.Development.json.sample` in csproj to visually nest the settings files
- (optional) add nesting in csproj to visually nest the settings files

## Add file nesting 

add the following to .csproj

```xml
 <ItemGroup>
    <None Update="appsettings.Development.json">
      <DependentUpon>appsettings.json</DependentUpon>
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
   <None Update="appsettings.Development.example.json">
     <DependentUpon>appsettings.json</DependentUpon>
     <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
   </None>
  </ItemGroup>
  ```