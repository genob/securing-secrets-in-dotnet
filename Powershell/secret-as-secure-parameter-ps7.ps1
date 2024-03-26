param (
    [Parameter(Mandatory=$true)]
    [System.Security.SecureString]$apikey
)

$plainTextKey = ConvertFrom-SecureString -SecureString $apikey -AsPlainText 

Write-Host "The provided API key is: $plainTextKey"  # For demonstration, we'll just print the APIKey value