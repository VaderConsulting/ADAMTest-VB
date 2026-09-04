# ADAMTest

VB.NET WinForms harness for exercising ADAM / Active Directory Application Mode (AD LDS) password checks via System.DirectoryServices.AccountManagement. Form1 builds a PrincipalContext against an application-directory host and container, creates a UserPrincipal, and runs CheckPassword for simple-bind scenarios. Aimed at developers validating AD LDS connectivity and bind options before wiring the same pattern into production tools.

**Source last updated:** 2010-03-13

---

## Contents

- `ADAMTest.sln`
- `Test/` - application source and forms

## Attribution and provenance

This codebase includes default Visual Studio template assembly metadata in `Test/My Project/AssemblyInfo.vb` (including Microsoft template values). No third-party source-code attribution markers were identified.

## Requirements

- Visual Studio 2008, .NET Framework 3.5

## License

MIT. See `LICENSE`.
