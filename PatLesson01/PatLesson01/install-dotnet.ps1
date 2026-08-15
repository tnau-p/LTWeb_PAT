param(
    [ValidateSet("lts","latest","preview")]
    [string]$Channel = "latest"
)

$scriptUrl = "https://dot.net/v1/dotnet-install.ps1"
$installer = Join-Path -Path $PSScriptRoot -ChildPath "dotnet-install.ps1"

Write-Host "Downloading dotnet-install script..." -ForegroundColor Cyan
Invoke-WebRequest -Uri $scriptUrl -OutFile $installer -UseBasicParsing

Write-Host "Running dotnet-install.ps1 (channel: $Channel)..." -ForegroundColor Cyan
& $installer -Channel $Channel -InstallDir "$env:USERPROFILE\.dotnet" -NoPath

$dotnetHome = "$env:USERPROFILE\.dotnet"
$dotnetTools = "$env:USERPROFILE\.dotnet\tools"
$currentUserPath = [Environment]::GetEnvironmentVariable("PATH", "User")

if ($currentUserPath -notlike "*$dotnetHome*") {
    Write-Host "Updating user PATH to include dotnet..." -ForegroundColor Cyan
    $newPath = "$dotnetHome;$dotnetTools;$currentUserPath"
    setx PATH $newPath | Out-Null
    Write-Host "Added $dotnetHome and $dotnetTools to user PATH. Restart terminal or sign out to apply." -ForegroundColor Green
} else {
    Write-Host "User PATH already contains $dotnetHome" -ForegroundColor Yellow
}

Write-Host "Done. After restarting your terminal, run: dotnet --info" -ForegroundColor Green
