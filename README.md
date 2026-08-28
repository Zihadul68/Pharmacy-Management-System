# Pharmacy Management System

A Windows Forms application for managing a pharmacy's inventory, pharmacist sales, customer orders, and manager profile functions.

## Prerequisites

- Windows 10/11 with Visual Studio 2022 Build Tools (or Visual Studio 2022) and the **.NET desktop build tools** workload.
- .NET Framework 4.7.2 Developer Pack.
- .NET SDK 8.0 or later (for the unit tests).
- SQL Server with the application's `PharmacyManagement` database schema.

## Configuration

The application deliberately does not commit database credentials. Before launching it, set `PHARMACY_CONNECTION_STRING` to a SQL Server connection string with the least-privileged account needed by the app. Copy `PharmacyManagement/App.config.example` as a reference; do **not** add secrets to `App.config`.

PowerShell example:

```powershell
$env:PHARMACY_CONNECTION_STRING = "Data Source=localhost\SQLEXPRESS;Initial Catalog=PharmacyManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
```

## Build and run

From a fresh clone on Windows:

```powershell
nuget restore PharmacyManagement.sln
msbuild PharmacyManagement.sln /p:Configuration=Debug
./PharmacyManagement/bin/Debug/PharmacyManagement.exe
```

You can also open `PharmacyManagement.sln` in Visual Studio and press **F5** after setting the environment variable.

## Testing

The business rules are kept separate from the WinForms controls and tested with xUnit:

```powershell
dotnet restore PharmacyManagement.Tests/PharmacyManagement.Tests.csproj
dotnet test PharmacyManagement.Tests/PharmacyManagement.Tests.csproj --no-restore
```

## Architecture

- `PharmacyManagement/Manager` contains manager-facing forms and user controls for inventory and account management.
- `PharmacyManagement/Pharmacist` contains pharmacist-facing controls for browsing inventory, adding billing lines, and confirming orders.
- `DataAccess` owns SQL connection and command execution. UI code supplies typed `SqlParameter` values rather than concatenating user input into SQL.
- `BillingCalculator` contains UI-independent pricing and stock rules, which are exercised by the test project.
- `Logger` writes unexpected application errors to the current user's local application-data directory, avoiding disclosure of implementation details in UI dialogs.

## Security notes

Passwords and connection strings must not be committed. The current database schema stores login passwords directly; migrate it to a modern salted password-hash scheme before deploying the application beyond a controlled learning environment.
