using CSharpToJavaScript.APIs.JS;
using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;

namespace SimpleShadowDom_Example;

public class Program
{
	static Program()
	{
		GlobalThis.Window.Document.AddEventListener("DOMContentLoaded", (Event e) =>
		{
			HTMLDivElement element = (GlobalThis.Window.Document.Body as ParentNode).QuerySelector<HTMLDivElement>("#Element");
			ShadowRoot shadow = element.AttachShadow(new ShadowRootInit() { Mode = ShadowRootMode.Open });

			HTMLTemplateElement template = (GlobalThis.Window.Document.Body as ParentNode).QuerySelector<HTMLTemplateElement>("#tempElement");

			shadow.AppendChild(template.Content);
		}, true);
	}
}