# configure subcommand

---

cstojs-cli configure -h

```bash
Description:
  Configure the project file without editing the xml by hand.

Usage:
  cstojs-cli configure [command] [options]

Options:
  -p, --project <path>      Path to the project file. 
                            Note: The name of the file can be anything as long as the file ends with xml and follows 
                            structure `<ProjectOptions>...</ProjectOptions>`. [default: ./cstojs_options.xml]
  -?, -h, --help            Show help and usage information
  --disable-console-output  Self-explanatory, Disable Console Output.
  --disable-console-colors  Self-explanatory, Disable Console Colors.

Commands:
  option              Represents an Option element in the xml.
  file <file-source>  Represents a File element in the xml.
  output              Represents an Output element in the xml.
```

Editing an xml file by hand can be a chore, so here is the "configure" command to make it easier.
With this command you can --add, --remove, or --change xml elements in the --project file.

cstojs-cli configure option -h

```bash
Description:
  Represents an Option element in the xml.

Usage:
  cstojs-cli configure option [options]

Options:
  --file <file-source>                     Represents a File element where an Option element is located in the xml.
  --Debug
  --DisableDiagnostics
  --UseVarOverLet
  --KeepBraceOnTheSameLine
  --NormalizeWhitespace
  --MakePropertiesEnumerable
  --DisableTranslation
  --DisableNameOfProcessing
  --EnableModules <EnableModules>
  --CustomPathToDLLs <CustomPathToDLLs>
  --CustomCSNamesToJS <CustomCSNamesToJS>
  --AddSBAtTheTop <AddSBAtTheTop>
  --AddSBAtTheBottom <AddSBAtTheBottom>
  --add                                    Adds an element to the --project file.
  --remove                                 Removes an element from the --project file.
  --change <change>                        Changes an element in the --project file.
  -?, -h, --help                           Show help and usage information
  --disable-console-output                 Self-explanatory, Disable Console Output.
  --disable-console-colors                 Self-explanatory, Disable Console Colors.
```

> [!NOTE]
> cstojs options on purpose do not have descriptions, for easier maintaining. Visit the <xref:CSharpToJavaScript.CSTOJSOptions> to see descriptions and values they accept.

cstojs-cli configure file -h

```bash
Description:
  Represents a File element in the xml.

Usage:
  cstojs-cli configure file <file-source> [options]

Arguments:
  <file-source>  The path to the cs file.

Options:
  --add                     Adds an element to the --project file.
  --remove                  Removes an element from the --project file.
  --change <change>         Changes an element in the --project file.
  -?, -h, --help            Show help and usage information
  --disable-console-output  Self-explanatory, Disable Console Output.
  --disable-console-colors  Self-explanatory, Disable Console Colors.
```

cstojs-cli configure output -h

```bash
Description:
  Represents an Output element in the xml.

Usage:
  cstojs-cli configure output [options]

Options:
  --change <change>         Changes an element in the --project file.
  -?, -h, --help            Show help and usage information
  --disable-console-output  Self-explanatory, Disable Console Output.
  --disable-console-colors  Self-explanatory, Disable Console Colors.
```
> [!NOTE]
> An Output element can only be changed.


## Example

---

- To add a File element to the project file:
```cstojs-cli configure file "./test.cs" --add```
- To change a File element:
```cstojs-cli configure file "./test.cs" --change "./Program.cs"```
- To add a global Option element to the project file:
```cstojs-cli configure option --NormalizeWhitespace true --add```
- To use a different project file:
```cstojs-cli configure --project "./test.xml" option --NormalizeWhitespace true --add```
- To change an Option element:
```cstojs-cli configure --project "./test.xml" option --NormalizeWhitespace --change "false"```
- To remove an Option element:
```cstojs-cli configure --project "./test.xml" option --NormalizeWhitespace --remove```
- To add a nested Option element to the File element:
```cstojs-cli configure --project "./test.xml" option --file "./test.cs" --NormalizeWhitespace --add```
- To change an Output element:
```cstojs-cli configure --project "./test.xml" output --change "./Output"```
