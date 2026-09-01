# CSharpToJavaScript

---

[CLI github](https://github.com/TiLied/CSTOJS_CLI) | [Dotnet tool](https://www.nuget.org/packages/TiLied.CSTOJS_CLI) | [Core github](https://github.com/TiLied/CSharpToJavaScript) | [Nuget package](https://www.nuget.org/packages/CSharpToJavaScript/) | [Try it online!](https://tilied.github.io/CSTOJS_Pages/BWA/)

## Features

---

### Web api included by default.

# [Example 1](#tab/web1)
CS:
```csharp
HTMLElement body = GlobalThis.Window.Document.Body;
HTMLFormElement todoForm = (body as ParentNode).QuerySelector<HTMLFormElement>("#TodoForm");
```
JS:
```javascript
let body = globalThis.window.document.body;
let todoForm = body.querySelector("#TodoForm");
```

# [Example 2](#tab/web2)
CS:
```csharp
Element paragraph = GlobalThis.Window.Document.CreateElement("p");
```
JS:
```javascript
let paragraph = globalThis.window.document.createElement("p");
```

# [Example 3](#tab/web3)
CS:
```csharp
(GlobalThis.Window as WindowOrWorkerGlobalScope).SetTimeout(async () =>
	{
		...
	}, 1000);
```
JS:
```javascript
globalThis.window.setTimeout(async () =>
	{
		...
	}, 1000);
```

---

### ECMA api included by default.

# [Example 1](#tab/ecma1)
CS:
```csharp
GlobalThis.Console.Log("Hello");
```
JS:
```javascript
globalThis.console.log("Hello");
```
# [Example 2](#tab/ecma2)
CS:
```csharp
Date.Now();
```
JS:
```javascript
Date.Now();
```

---

### Special methods to emulate js features.

# [Example 1](#tab/special1)
CS:
```csharp
Delete(a);
```
JS:
```javascript
delete a;
```

# [Example 2](#tab/special2)
CS:
```csharp
EqualsStrict(1, 1);
```
JS:
```javascript
1 === 1;
```

---

### Basic/partial net api translation.

# [Example 1](#tab/net1)
CS:
```csharp
Console.WeriteLine("Hello");
```
JS:
```javascript
console.log("Hello");
```

# [Example 2](#tab/net2)
CS:
```csharp
var a = int.MinValue;
```
JS:
```javascript
let a = Number.parseInt("-2147483648");
```

# [Example 3](#tab/net3)
CS:
```csharp
var a = new System.Collections.Generic.List<int>();
```
JS:
```javascript
let a = new Array();
```

---

### Basic "interop" for JS calling.

For example, if you have a JS file located in "./lib/test.js" with an export,
you can use [ImportAttribute](xref:CSharpToJavaScript.Utils.ImportAttribute) with [IgnoreAttribute](xref:CSharpToJavaScript.Utils.IgnoreAttribute) and
[ValueAttribute](xref:CSharpToJavaScript.Utils.ValueAttribute) (optionally).

./lib/test.js:
```javascript
	export function helloWorld() {}
```
./Program.cs:
```csharp
	using CSharpToJavaScript.Utils;
	class C
	{
		[Import("helloWorld","../lib/test.js")]
		[Ignore]
		[Value("helloWorld")]
		void HelloWorld(){}
		C() { HelloWorld(); }
	}
```
The translated file will be:

./Output/Program.js:
```javascript
	import { helloWorld } from '../lib/test.js';
	class C
	{
		constructor(){ helloWorld(); }
	}
```
For a slightly more complex example using the node api visit [tutorial](./tutorials/node-api.md).

### Automatic modules by default.

Can be disabled, see [EnableModules](xref:CSharpToJavaScript.CSTOJSOptions#CSharpToJavaScript_CSTOJSOptions_EnableModules).
See the [tutorial](./tutorials/simple-module.md) for an example.

---

> [!WARNING]
> Because translation is happening as-is, there are many (BIG!) limitations.
> 
> For example, namespaces are ignored, if you have 2 identical classes but in different namespaces, both will be translated with the same name!
> 
> Structs/Interfaces and many more are completely ignored.
> 
> The output is not tied to the ECMA standard, meaning if you use a static constructor in cs it will be translated as a static constructor even though it is ECMA 13th.

## Quick start for a CLI

---

### To install:
```csharp
dotnet tool install --global TiLied.CSTOJS_CLI
```
### To use:
```csharp
cstojs-cli setup "Output"
```
```csharp
cstojs-cli translate
```
### To update:
```csharp
dotnet tool update --global TiLied.CSTOJS_CLI
```
### To uninstall:
```csharp
dotnet tool uninstall --global TiLied.CSTOJS_CLI
```

## Using as a library

---

- Install [nuget package](https://www.nuget.org/packages/CSharpToJavaScript/) or download a [specific version](https://github.com/TiLied/CSharpToJavaScript/releases).
- Skip this if using a Nuget package. Follow [the instructions on how to add a project reference](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-project-reference).
- In the Main method, add:
```csharp
FileData file = new()
{
	SourceStr = @"Console.WriteLine(""Hello world."");"
};
file = CSTOJS.Translate(file);

Console.WriteLine(file.TranslatedStr);
```
- Run a program
- Console output should be:
```javascript
console.log("Hello world.");
```
