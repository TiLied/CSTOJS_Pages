# CLI

---

Console frontend for a CSharptoJavaScript library.
Available as a [dotnet tool](https://www.nuget.org/packages/TiLied.CSTOJS_CLI/) or as a [standalone](https://github.com/TiLied/CSTOJS_CLI/releases).

## Quick start

---

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
### To uninstall:
```csharp
dotnet tool uninstall --global TiLied.CSTOJS_CLI
```

## cstojs-cli -h:

---

```bash
Description:
  Dotnet tool/cli frontend for a CSharpToJavaScript library.

Usage:
  CSTOJS_CLI [command] [options]

Options:
  --disable-console-output  Self-explanatory, Disable Console Output.
  --disable-console-colors  Self-explanatory, Disable Console Colors.
  -?, -h, --help            Show help and usage information
  --version                 Show version information

Commands:
  init <folder>   Create a barebone 'cstojs_options.xml' in the current directory, without running the dotnet commands.
                  This command should be used if a C# project already exists.
  setup <folder>  Setup cstojs project in the current directory.
                  This command should be used if you are starting from scratch.
  translate       Translate specified files in the 'cstojs_options.xml'.
  watch           Watches specified files in the 'cstojs_options.xml' with an interval and translates them. 
                  Note: The 'cstojs_options.xml' file is not being monitored, so any changes require the command to be 
                  restarted.
```
Visit separate pages for examples and explanations of what subcommands do.
