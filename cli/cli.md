# CLI

---

Console frontend for the library.
Available as a [dotnet tool](https://www.nuget.org/packages/TiLied.CSTOJS_CLI/) or as a [standalone](https://github.com/TiLied/CSTOJS_CLI/releases).

## Quick start

---

### To install:
```csharp
dotnet tool install --global TiLied.CSTOJS_CLI
```
### To use:
```csharp
cstojs-cli setup "./Output"
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
  cstojs-cli [command] [options]

Options:
  --disable-console-output  Self-explanatory, Disable Console Output.
  --disable-console-colors  Self-explanatory, Disable Console Colors.
  -?, -h, --help            Show help and usage information
  --version                 Show version information

Commands:
  init <folder>   Creates a barebone project file(default 'cstojs_options.xml') in the current directory, without running 
                  the dotnet commands.
                  This command should be used if a C# project already exists.
  setup <folder>  Setup cstojs project in the current directory.
                  This command should be used if you are starting from scratch.
  translate       Translate specified files in the --project file.
  watch           Watches specified files in the --project file with an interval and translates them. 
                  Note: The --project file is not being monitored, so any changes to it require the command to be restarted.
  configure       Configure the project file without editing the xml by hand.
```

Visit separate pages for examples and explanations of what subcommands do.
