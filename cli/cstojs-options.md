# cstojs_options.xml
TODO!
```xml
<ProjectOptions>
  <!-- This is specifying an output folder for a js files. This example is "Output". -->
  <Output Folder="Output" />

  <!-- This is a global "NormalizeWhitespace" option. See all available options at https://github.com/TiLied/CSharpToJavaScript/blob/master/CSharpToJavaScript/CSTOJSOptions.cs -->
  <Option NormalizeWhitespace="true" />

  <!-- This is a file that will be translated to js. -->
  <File Source="./Program.cs" />

  <!-- This is a file that will be translated to js with overridden options. -->
  <File Source="./Test.cs">
     <!-- This is a "Debug" option applying only to this file. -->
    <Option Debug="true" />
  </File>

</ProjectOptions>
```
