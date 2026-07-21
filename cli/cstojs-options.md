# cstojs_options.xml

Simple configuration file for a cli. The name of the file can be anything as long as the file ends with xml and follows structure `<ProjectOptionx>...</ProjectOptions>`.
> [!NOTE]
> To specify a different configuration file use the `--project` option. For example, if you have `./cstojs_debug.xml` then you would run `cstojs-cli translate --project "./cstojs_debug.xml"`.

## Elements
### Output element
The Output element is a path for outputting JS files.

The Folder argument is required, the path can be absolute or relative.

Example with "Output" as an argument:
```xml
<Output Folder="Output" />
```

### File element
The File element is a path for a single cs file.

The Source argument is required, the path can be absolute or relative.

Example with "./Program.cs" as an argument:
```xml
<File Source="./Program.cs" />
```

### Option element
The Option element is an options for a file or a global.

See all arguments at <xref:CSharpToJavaScript.CSTOJSOptions>.

Global example, any file that follows will have this option:
```xml
<Option NormalizeWhitespace="true" />
```
Local option for the file example:
```xml
<File Source="./Test.cs">
    <Option Debug="true" />
</File>
```

## Example:
```xml
<ProjectOptions>
  <!-- This specifies an output folder for js files. This example is "Output". -->
  <Output Folder="Output" />

  <!-- This is the default option which will be applied to every file that follows. -->
  <!-- See all available options at https://github.com/TiLied/CSharpToJavaScript/blob/master/CSharpToJavaScript/CSTOJSOptions.cs -->
  <Option NormalizeWhitespace="true" />

  <!-- This is a file that will be translated to js. -->
  <File Source="./Program.cs" />

  <!-- This is a file that will be translated to js with overridden options. -->
  <File Source="./Test.cs">
     <!-- This is the "Debug" option, applying only to this file. -->
    <Option Debug="true" />
  </File>

</ProjectOptions>
```
