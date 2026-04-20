---
name: upgrade-projects
description: Upgrade projects to the latest version of SKILL.
---

# Upgrade solution

Solution should be .slnx file. If you have .sln file, build it in dotnet command line and then do the same for .slnx file. This will upgrade the project to the latest version of SKILL. Then you can remove the old .sln file and use the new .slnx file for your development.

# Upgrade dotnet SDK

If you have an older version of dotnet SDK, you can upgrade it to the latest version of .NET 10. Each time compile solution to validate the results.

# Project names

Instead of using folder with PascalCase or camelCase, use the same name as the project in the dash-separated format. For example, if your project is named "MyProject", the folder should be named "my-project". This will help to avoid issues with case sensitivity and make it easier to manage your projects.
