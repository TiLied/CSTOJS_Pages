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
