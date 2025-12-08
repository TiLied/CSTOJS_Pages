[CLI](https://github.com/TiLied/CSTOJS_CLI) | [Dotnet tool](https://www.nuget.org/packages/TiLied.CSTOJS_CLI) | [Core](https://github.com/TiLied/CSharpToJavaScript) | [Nuget package](https://www.nuget.org/packages/CSharpToJavaScript/) | [Try it online!](https://tilied.github.io/CSTOJS_Pages/BWA/)


## Quick start for a CLI
### To install:
```csharp
dotnet tool install --global TiLied.CSTOJS_CLI
```
### To use:
```csharp
cstojs-cli setup "Output"
```
```csharp
cstojs-cli translate
```
### To update:
```csharp
dotnet tool update --global TiLied.CSTOJS_CLI
```
### To delete:
```csharp
dotnet tool uninstall --global TiLied.CSTOJS_CLI
```

## Using as a library
- Install [nuget package](https://www.nuget.org/packages/CSharpToJavaScript/) or download a [specific version](https://github.com/TiLied/CSharpToJavaScript/releases).
- Skip this if using a Nuget package. Follow [the instructions on how to add a project reference](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-project-reference).
- In the Main method, add:
```csharp
FileData file = new()
{
	SourceStr = @"Console.WriteLine(""Hello world."");"
};
file = CSTOJS.Translate(file);

Console.WriteLine(file.TranslatedStr);
```
- Run a program
- Console output should be:
```javascript
console.log("Hello world.");
```