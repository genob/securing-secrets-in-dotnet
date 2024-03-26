param (
    [Parameter(Mandatory=$true)]
    [System.Security.SecureString]$apikey
)

$credential = New-Object System.Net.NetworkCredential("", $apikey)
$plainTextKey = $credential.Password

Write-Host "The provided API key is: $plainTextKey"  # For demonstration, we'll just print the APIKey value