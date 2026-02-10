# setup subcommand
cstojs-cli setup -h

```bash
Description:
  Setup cstojs project.

Usage:
  CSTOJS_CLI setup <folder> [options]

Arguments:
  <folder>  Output folder. Can be absolute path or relative.

Options:
  -?, -h, --help  Show help and usage information
```

Runs `dotnet new console -f net10.0` and `dotnet add package CSharpToJavaScript` then creates an Output folder and `cstojs_options.xml`

Specifying an output folder is required.

## Example
```bash
cstojs-cli setup "Output"
```
Output folder will be empty, and the content of 'cstojs_options.xml' will be:
```xml
<ProjectOptions>
  <Output Folder="Output" />
  <File Source="./Program.cs" />
</ProjectOptions>
```