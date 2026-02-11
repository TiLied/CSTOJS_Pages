using CSharpToJavaScript.APIs.JS;
using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;

namespace SimpleCustomElement_Example;

public class CustomElement : HTMLElement
{
	public CustomElement() : base()
	{
		
	}
	void connectedCallback()
	{
		ShadowRoot shadow = this.AttachShadow( new ShadowRootInit { Mode = ShadowRootMode.Open });
		shadow.AppendChild(GlobalThis.Window.Document.CreateTextNode("Hello from 'my-element'."));
	}
}
public class Program
{
	static Program()
	{
		GlobalThis.Window.CustomElements.Define<CustomElement>("my-element");
		
		GlobalThis.Window.Document.AddEventListener("DOMContentLoaded", (Event e) =>
		{
			CustomElement element = (CustomElement)GlobalThis.Window.Document.CreateElement("my-element");
			GlobalThis.Window.Document.Body.AppendChild(element);
		}, true);
	}
}