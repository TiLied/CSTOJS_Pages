# translate subcommand

cstojs-cli translate -h

```bash
Description:
  Translate specified files in the 'cstojs_options.xml'.

Usage:
  CSTOJS_CLI translate [options]

Options:
  -p, --project <path>  Path to the 'cstojs_options.xml'. [default: ./cstojs_options.xml]
  -?, -h, --help        Show help and usage information
```

Translates specified files in the 'cstojs_options.xml'. 

Optionally, a path to the 'cstojs_options.xml' can be specified.

## Example
'cstojs_options.xml':

```xml
<ProjectOptions>
  <Output Folder="Output" />
  <File Source="./Program.cs" />
</ProjectOptions>
```

```bash
cstojs-cli translate
```

"Program.js" will be in an "Output" folder. 
