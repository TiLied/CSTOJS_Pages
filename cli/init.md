# init subcommand

---

cstojs-cli init -h

```bash
Description:
  Creates a barebone project file(default 'cstojs_options.xml') in the current directory, without running the dotnet 
  commands.
  This command should be used if a C# project already exists.

Usage:
  cstojs-cli init <folder> [options]

Arguments:
  <folder>  Output folder. Can be absolute path or relative.

Options:
  -n, --name <fileName>       The name of the project file, without the extension. [default: cstojs_options]
  -fs, --file-source <paths>  Adds file sources(paths) to the project file. Multiple paths can be specified.
  -?, -h, --help              Show help and usage information
  --disable-console-output    Self-explanatory, Disable Console Output.
  --disable-console-colors    Self-explanatory, Disable Console Colors.
```

Creates a barebone project file in the current directory and optionally creates an output folder without running the dotnet commands. If c# already exists, you may want to add the CSharpToJavaScript package.

The name of the project file can be changed with `--name`, without the extension.

To add default cs files to the project, use `--file-source`, can accept multiple paths. See the example below.

> [!IMPORTANT]
> Specifying an output folder is required.

> [!NOTE]
> Specifying files in the project file needed before running `cstojs-cli translate`.

## Example

---

### Example without options.
```bash
cstojs-cli init "./Output"
```
Output folder will be empty, and the content of 'cstojs_options.xml' will be:
```xml
<ProjectOptions>
  <Output Folder="./Output" />
</ProjectOptions>
```

### Example with a different project file name.
```bash
cstojs-cli init "./Output" --name "test"
```
Will create 'test.xml' with the content:
```xml
<ProjectOptions>
  <Output Folder="./Output" />
</ProjectOptions>
```

### Example with a different project file name and multiple cs files.
```bash
cstojs-cli init "./Output" --name "test" --file-source "./Program.cs" "../Main.cs"
```
Will create 'test.xml' with the content:
```xml
<ProjectOptions>
  <Output Folder="./Output" />
  <File Source="./Program.cs"/>
  <File Source="../Main.cs"/>
</ProjectOptions>
```
