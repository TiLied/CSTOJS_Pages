# init subcommand

cstojs-cli init -h

```bash
Description:
  Create a barebone 'cstojs_options.xml', without running the dotnet commands.

Usage:
  CSTOJS_CLI init <folder> [options]

Arguments:
  <folder>  Output folder. Can be absolute path or relative.

Options:
  -?, -h, --help  Show help and usage information
```

Creates a bare-bones 'cstojs_options.xml' in the current directory and output folder, without running the dotnet commands.

> [!IMPORTANT]
> Specifying an output folder is required.

> [!NOTE]
> Specifying files in the 'cstojs_options.xml' needed before running `cstojs-cli translate`.

## Example
```bash
cstojs-cli init "Output"
```
Output folder will be empty, and the content of 'cstojs_options.xml' will be:
```xml
<ProjectOptions>
  <Output Folder="Output" />
</ProjectOptions>
```

