# AGENTS.md

Three independent WinForms apps. No shared code, no dependencies beyond the .NET SDK, no tests/lint/CI.

- `Dasar/` (`Dasar.sln`) — C# basics demo. Entry `Program.cs` → `Form1`. Logic in `ContohDasar.cs`, `ContohPerulangan.cs`.
- `Kalkulator/` (`Kalkulator.sln`) — calculator. Entry `Program.cs` → `Form1`.
- `ContohSoal/` (`ContohSoal.sln`) — login/register/dashboard + `UcBandara` user control. Entry `Program.cs` → `FormLogin`.

## Stack

- `net10.0-windows`, `OutputType WinExe`, `UseWindowsForms`, `Nullable enable`, `ImplicitUsings enable` (all three `.csproj` identical apart from name).
- Windows-only. Requires Windows + .NET 10 SDK (verified with 10.0.401). There is no root solution. Git root is the parent `D:\KELAS-XII` (this code dir is currently untracked).

## Build

There is no root solution — build per project from this directory (`Tugas Video C# Development\`):

```powershell
dotnet build Kalkulator\Kalkulator.csproj
dotnet build Dasar\Dasar.csproj
dotnet build ContohSoal\ContohSoal.csproj
```

Or open the matching `*.sln` in Visual Studio. `dotnet run --project <Name>\<Name>.csproj` needs an interactive Windows desktop session.

## WinForms conventions in this repo

- Entry pattern is always `ApplicationConfiguration.Initialize(); Application.Run(new <Form>());` in `Program.cs`.
- Each form is split: `FormX.cs` (hand-written logic, edit this) + `FormX.Designer.cs` (generated layout, do not hand-edit) + optional `.resx`.
- Navigation pattern: `Show()`/`Hide()` between forms and injecting `UserControl` into a panel — see `ContohSoal/FormDashboard.cs` (`MuatKonten`) and `ContohSoal/FormLogin.cs` (`linkDaftar_LinkClicked`).
- No test projects or fixtures exist; verify with `dotnet build` for the touched project.
