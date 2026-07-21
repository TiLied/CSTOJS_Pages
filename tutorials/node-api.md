## Node api

## As of CSharpToJavaScript 0.2.3

There are a couple of ways to call node js using attributes, but the simplest that I found is to use [ImportAttribute](xref:CSharpToJavaScript.Utils.ImportAttribute) with [IgnoreAttribute](xref:CSharpToJavaScript.Utils.IgnoreAttribute) and
[ValueAttribute](xref:CSharpToJavaScript.Utils.ValueAttribute).

cstojs_options.xml:
[!code-xml[](./NodeApi_Example/cstojs_options.xml)]

Program.cs:
[!code-csharp[](./NodeApi_Example/Program.cs)]

Translated js:
[!code-javascript[](./NodeApi_Example/Output/Program.js)]

See the full source code: https://github.com/TiLied/CSTOJS_Pages/tree/main/tutorials/NodeApi_Example
