# CLI
Console frontend for a CSharptoJavaScript library.
Available as a [dotnet tool](https://www.nuget.org/packages/TiLied.CSTOJS_CLI/) or as a [standalone](https://github.com/TiLied/CSTOJS_CLI/releases).

## Quick start
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

## cstojs-cli subcommands:

```bash
init <folder>   Create a barebone 'cstojs_options.xml', without running the dotnet commands.
setup <folder>  Setup cstojs project.
translate       Translate specified files in the 'cstojs_options.xml'.
watch           Watches specified files in the 'cstojs_options.xml' with an interval and translates them. Note: The 'cstojs_options.xml' file is not being monitored, so any changes require the command to be restarted.
```
Visit separate pages for examples and explanations of what they do.