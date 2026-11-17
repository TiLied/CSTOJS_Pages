# watch subcommand

---

cstojs-cli watch -h

```bash
Description:
  Watches specified files in the --project file with an interval and translates them. 
  Note: The --project file is not being monitored, so any changes to it require the command to be restarted.

Usage:
  cstojs-cli watch [options]

Options:
  -p, --project <path>      Path to the project file. 
                            Note: The name of the file can be anything as long as the file ends with xml and follows 
                            structure `<ProjectOptions>...</ProjectOptions>`. [default: ./cstojs_options.xml]
  -d, --delay <ms>          Delay watching the files again by milliseconds. (1000-10000) [default: 3000]
  -?, -h, --help            Show help and usage information
  --disable-console-output  Self-explanatory, Disable Console Output.
  --disable-console-colors  Self-explanatory, Disable Console Colors.
```

Watches specified files in the project file with an interval (--delay) and translates them. 

Optionally, a path to a different project file can be specified.

> [!NOTE]
> The --project file is not being monitored, so any changes to it require the command to be restarted.

## Example

---

'cstojs_options.xml':

```xml
<ProjectOptions>
  <Output Folder="./Output" />
  <File Source="./Program.cs" />
</ProjectOptions>
```

```bash
cstojs-cli watch
```
Any changes to "Program.cs" will be translated with an interval (default 3000ms).
