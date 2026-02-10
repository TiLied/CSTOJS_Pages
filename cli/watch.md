# watch subcommand

cstojs-cli watch -h

```bash
Description:
  Watches specified files in the 'cstojs_options.xml' with an interval and translates them. Note: The
  'cstojs_options.xml' file is not being monitored, so any changes require the command to be restarted.

Usage:
  CSTOJS_CLI watch [options]

Options:
  -p, --project <path>  Path to the 'cstojs_options.xml'. [default: ./cstojs_options.xml]
  -d, --delay <ms>      Delay watching the files again by milliseconds. (1000-10000) [default: 3000]
  -?, -h, --help        Show help and usage information
```

Watches specified files in the 'cstojs_options.xml' with an interval (--delay) and translates them. 

A project file (--project) can be specified.

> [!NOTE]
> The 'cstojs_options.xml' file is not being monitored, so any changes require the command to be restarted.

## Example
'cstojs_options.xml':

```xml
<ProjectOptions>
  <Output Folder="Output" />
  <File Source="./Program.cs" />
</ProjectOptions>
```

```bash
cstojs-cli watch
```
Any changes to "Program.cs" will be translated with an interval (default 3000ms).
