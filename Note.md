# C-12-and-.Net8
Learning C # and .NET
## Chapter 1 - Hello, C#! Welcome, .NET!

### Terminology

- modern .NET → .NET8
- legacy .NET → .NET Framework, Mono, Xamarin, and .NET standard

### Environment Setup

- IDE - Visual Studio Code for Windows
- Extensions
    - C# Dev Kit (Official C# extension from Microsoft)
- **Issue - Cannot install .NET SDK 8 (Other Program installation in progress issue)**
    - **Fix: close *Windows Install* progress through Task Manager, then start Windows *Install service***
- **Issue 2 - .NET SDK cannot be found after .NET Installation process finished.**
    - **Fix: Remove all contents under directory C:\Program Files (x86)\dotnet**

### .NET

- Versions - LTS (≥3 years support), STS (≥ 18 months after GA), Preview
- SDK
    - Runtime
    - Compilers (Roslyn)
        - C# →  Intermediate Language (IL) as assembly .IL code
        - IL code executed by .NET’s VM (These IL codes can be run on any platforms - Windows, Mac, Linux, etc.)
    - etc.
- .NET technologies
    - **Modern .NET** - Windows, macOS, Linux, Android, IOS, tvOS, Tizen
    - .NET Framework - Windows
    - Xamarin - Android, IOS, macOS

## New Project

Steps:

1. New Fold for the solution (PS: .NET has a solution that’s above projects)
2. Create a solution file in the folder: **dotnet new sln**
3. Create a folder and project using a template: **dotnet new console -o HelloCS (HelloCS is a template in C#)**
4. Add the folder and its project to the solution: **dotnet sln add HelloCS**
5. Repeat steps 3 & 4 to create and add any other projects
6. Open the folder containing the solution using Visual Studio Code: **.code**