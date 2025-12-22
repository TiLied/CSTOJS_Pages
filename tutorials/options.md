## Options showcase

> [!NOTE]
> cstojs-cli 0.1.3 is used, with csharptojavascript 0.1.3

See all options: <xref:CSharpToJavaScript.CSTOJSOptions>.

cstojs_options.xml:
[!code-xml[](./Options_Example/cstojs_options.xml)]

All options applying to the file. If you what global options, for example `NormalizeWhitespace`, change "cstojs_options.xml" to:

```xml
<ProjectOptions>
  <Output Folder="Output" />
  <Option NormalizeWhitespace="true"/>
  <File Source="./Program.cs">
	<Option AddSBAtTheBottom="//comment at the bottom" />
	<Option AddSBAtTheTop="/*comment at the top*/"/>
	<Option CustomCSNamesToJS="Console-console,Beep-log"/>
	<Option KeepBraceOnTheSameLine="true"/>
	<Option UseVarOverLet="true"/>
  </File>
</ProjectOptions>
```

Program.cs:
[!code-csharp[](./Options_Example/Program.cs)]

Translated js:
[!code-javascript[](./Options_Example/Output/Program.js)]

See the full source code: https://github.com/TiLied/CSTOJS_Pages/tree/main/tutorials/Options_Example
