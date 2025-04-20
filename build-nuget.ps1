# Define directories
$NuGetDirectory = "c:/usr/var/nuget"
$CoverageReport = "$PSScriptRoot/coverage"

# Ensure the directories exist
New-Item -ItemType Directory -Path $NuGetDirectory -Force | Out-Null
New-Item -ItemType Directory -Path $CoverageReport -Force | Out-Null

Write-Host "Setting up .NET environment..."
dotnet --version

$timestamp = Get-Date -Format "yyyyMMdd.HHmm"

Write-Host "Determining version with MinVer..."
$Version = $(minver)
Write-Host "Version determined: $Version"

Write-Host "Building the solution..."
dotnet build BiermanTech-Canine-Health.sln --configuration Debug

Write-Host "Packing BiermanTech.CanineHealth..."
dotnet pack BiermanTech.CanineHealth --configuration Debug --output $NuGetDirectory /p:Version=$Version

Write-Host "NuGet Packages are ready in: $NuGetDirectory"
Write-Host "Coverage report is available in: $CoverageReport/html"

Write-Host "Listing NuGet packages:"
Get-ChildItem $NuGetDirectory/*.nupkg
