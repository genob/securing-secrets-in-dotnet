# Read the client secret from the file and convert it to a secure string
$secureString = Get-Content "C:\path\to\secret.txt" | ConvertTo-SecureString
$credential = New-Object System.Management.Automation.PSCredential ('api-client-secret', $secureString)

# Use the client secret in your script
$clientSecret = $credential.GetNetworkCredential().Password
# Now you can use $clientSecret to authenticate API calls
