<#
   .Synopsis
    This script gets the Salesforce Objects schema and save it as XML file
   .Description
    This script gets the Salesforce Objects schema and save it as XML file
   .Example
    Get-SalesforceSchema  -ClientId "3MVGxxxxxxxxxxxxxxxxxxxxxxxxxxx" -ClientSecret "1234567890123456789" -RefreshToken xXXXXXxXXXXXxXXXXXxXXXXX 
   .Parameter Uri
   Salesforce OAuth2 token endpoint
   .Parameter ClientId
   OAuth Consumer Key of your App in Salesforce
   .Parameter ClientSecret
   OAuth Consumer Secret of your App in Salesforce
   .Parameter RefreshToken
   Your app refresh token used to get new access tokens in Salesforce
   .Parameter Output
   The path and filename to save the Salesforce schema
   .Notes
    NAME:  Get-SalesforceSchema
    AUTHOR: Luis Rocha
    LASTEDIT: 01/04/2014 17:44:00
    KEYWORDS:
    HSG: 
   .Link
 #>
param(
		[parameter(Mandatory=$false)]
		[ValidateNotNullOrEmpty()]
		[string] $Uri = "https://login.salesforce.com/services/oauth2/token",

		[parameter(Mandatory=$true)]
		[ValidateNotNullOrEmpty()]
		[string] $ClientId,

		[parameter(Mandatory=$true)]
		[ValidateNotNullOrEmpty()]
		[string] $ClientSecret,

		[parameter(Mandatory=$true)]
		[ValidateNotNullOrEmpty()]
		[string] $RefreshToken,

		[parameter(Mandatory=$false)]
		[ValidateNotNullOrEmpty()]
		[string] $Output = (Get-Location).Path + "\SObjects.xml"

)

# Check Powershell version
If ($PSVersionTable.psversion.Major -lt 3) {
    Write-Error "This script requires Powershell 3"
    return
}

# Get Salesforce Access Token
Write-Host "Retrieving access token ..."
$body = "grant_type=refresh_token&client_id=" + $ClientId + "&client_secret=" + $ClientSecret + "&refresh_token=" + $RefreshToken
$tokenResponse = Invoke-RestMethod -Method Post -Uri $Uri -Body $body

# Get the list of Salesforce Objects
Write-Host "Retrieving list of sobjects ..."
$url = $tokenResponse.instance_url + "/services/data/v29.0/sobjects/.xml"
$authorization = "Bearer " + $tokenResponse.access_token
$sobjects = [xml] (Invoke-RestMethod -Uri $url -Headers @{"Authorization" = $authorization})

# Get the description of each Salesforce Object
$sobjects.DescribeGlobal.sobjects | % { 
    Write-Host "Retrieving"$_.Name"..."
    $url = $tokenResponse.instance_url + "/services/data/v29.0/sobjects/" + $_.Name + "/describe/.xml"
    $xml = [xml] (Invoke-RestMethod -Uri $url -Headers @{"Authorization" = $authorization})
    $name = $_.Name
    $_.InnerXml = $xml.$name.InnerXml
}

# Save Salesforce Objects schema
$sobjects.InnerXml = Format-Xml -IndentString "    " -InputObject $sobjects.InnerXml
$sobjects.Save($Output)
