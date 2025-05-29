# DotnetNoProject

New feature of .NET 10 Preview 4 to run single `.cs` files.

To run it put in command line:
```
dotnet run hello.cs
```

This will print text to the console.

For now it supports only single file, `#:include` directive is not supported yet, however docs in PR states that such feature will be provided soon.