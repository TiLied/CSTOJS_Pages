using CSharpToJavaScript.APIs.JS;
using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;
GlobalThis.Window.Document.AddEventListener("DOMContentLoaded", (Event e) =>
{
	HTMLCanvasElement canvas = (GlobalThis.Window.Document.Body as ParentNode).QuerySelector<HTMLCanvasElement>("canvas");
	//hack
	dynamic ctx = canvas.GetContext("2d");

	ctx.fillStyle = "rgb(180 0 180)";
	ctx.fillRect(50, 50, 50, 50);
}, true);
