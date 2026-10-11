# ADAMTest

VB.NET WinForms harness for exercising ADAM / Active Directory Application Mode (AD LDS) password checks via System.DirectoryServices.AccountManagement. Form1 builds a PrincipalContext against an application-directory host and container, creates a UserPrincipal, and runs CheckPassword for simple-bind scenarios. Aimed at developers validating AD LDS connectivity and bind options before wiring the same pattern into production tools.

**Source last updated:** 2010-03-13 · **Language:** VB.NET · **Target:** .NET Framework 3.5 · **Output:** WinForms exe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Test` (`Test/`) | VB.NET | WinForms exe | ADAM/AD LDS PrincipalContext CheckPassword harness |

## How to open

Open `ADAMTest.sln` in Visual Studio 2008 or later.

## Requirements

- Visual Studio 2008 to 2017
- .NET Framework 3.5
- Access to an ADAM / AD LDS instance for live bind tests

## Attribution and provenance

my working copy from Development folder `ADAMTest-VB`.
Default Visual Studio template assembly metadata remains in `Test/My Project/AssemblyInfo.vb` (including Microsoft template values).

## License

MIT © 2026 Vader Consulting for Dave Robinson's code. See `LICENSE`.
