# cstojs_options.xml
TODO!
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
