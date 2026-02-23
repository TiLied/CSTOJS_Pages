using CSharpToJavaScript.APIs.JS;
using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;
GlobalThis.Window.Document.AddEventListener("DOMContentLoaded", (Event e) =>
{
	HTMLCanvasElement canvas = ((ParentNode)GlobalThis.Window.Document.Body).QuerySelector<HTMLCanvasElement>("canvas");

	CanvasRenderingContext2D ctx = canvas.GetContext("2d");

	((CanvasFillStrokeStyles)ctx).FillStyle = "rgb(180 0 180)";
	((CanvasRect)ctx).FillRect(50, 50, 50, 50);
}, true);
