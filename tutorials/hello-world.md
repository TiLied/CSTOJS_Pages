> [!NOTE]
> cstojs-cli 0.1.2 is used.

I assume that the cli installed as a dotnet tool, that way, the cli can be called as "cstojs-cli".

## Hello world
First, let's create a folder where the project will be, I called it "HelloWorld_Example".
Now, inside that folder, open a terminal and type:

```bash
cstojs-cli setup "Output"
```
The command will create a dotnet project with an "Output" folder as an output for js files.

![Folder structure](../images/HelloWorld_Images/0.png)

"Output" - folder where js files will be placed.
"cstojs_options.xml" - various options for a csharptojavascript library.

Now before we start "coding" hello world :) let's create an HTML file inside of "Output", I called "index.html"

```html
<!DOCTYPE html>
<html>
	<head>
		<title>Hello, world!</title>
		<script src="./Program.js" type="text/javascript"></script>
	</head>
	<body>
	</body>
</html> 
```
Now in the opened terminal type:

```bash
cstojs-cli translate
```
Once translated, open "index.html" and open a console, you should see a message "Hello, World!"

![Folder structure](../images/HelloWorld_Images/1.png)

Now, let's code!

Open "Program.cs" in your favorite ide, delete everything, and add this code.
```csharp
using CSharpToJavaScript.APIs.JS;
using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;

GlobalThis.Window.Document.AddEventListener("DOMContentLoaded", (Event e) =>
{
	HTMLElement body = GlobalThis.Window.Document.Body;

	Element paragraph = GlobalThis.Window.Document.CreateElement("p");
	Text helloWorld = GlobalThis.Window.Document.CreateTextNode("Hello, World!");
	
	paragraph.AppendChild(helloWorld);

	(body as ParentNode).Append(paragraph);
}, true);

```
Now, let me explain line by line. In the meantime, you can run `cstojs-cli translate` and see a "Hello, World!" message on a reloaded "index.html".

> [!NOTE]
> You can ignore warnings as of 0.1.2, something regressed...

![Folder structure](../images/HelloWorld_Images/2.png)

First using static, this is needed if you want (you do!) to use ECMA api/web api:
```csharp
...
using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;
...
```

Second, adding an event listener to make sure the body is loaded before js execution:
```csharp
...
GlobalThis.Window.Document.AddEventListener("DOMContentLoaded", (Event e) =>
...
```

Third, keeping reference to the body:
```csharp
...
HTMLElement body = GlobalThis.Window.Document.Body;
...
```

Fourth, this shows how to create an element and textnode, explore other methods in "Document":
```csharp
...
Element paragraph = GlobalThis.Window.Document.CreateElement("p");
Text helloWorld = GlobalThis.Window.Document.CreateTextNode("Hello, World!");
...
```

Fifth, appendChild is easy:
```csharp
...
paragraph.AppendChild(helloWorld);
...
```

Sixth, but what about "Append"??? 
Well, you need to cast to the "ParentNode" interface before you can use methods like "Append" and "QuerySelector".
See <xref:CSharpToJavaScript.APIs.JS.ParentNode>.

> [!NOTE]
> As of 0.1.2, explicit cast `(ParentNode(body))` is broken, I need to fix it..

```csharp
...
(body as ParentNode).Append(paragraph);
...
```

Translated js:
```javascript
globalThis.window.document.addEventListener("DOMContentLoaded", (e) =>
{
	let body = globalThis.window.document.body;

	let paragraph = globalThis.window.document.createElement("p");
	let helloWorld = globalThis.window.document.createTextNode("Hello, World!");
		
	paragraph.appendChild(helloWorld);

	body.append(paragraph);
}, true);

```

See the full source code: https://github.com/TiLied/CSTOJS_Pages/tree/main/tutorials/HelloWorld_Example

Live example:

<iframe src="./HelloWorld_Example/Output/index.html"></iframe>