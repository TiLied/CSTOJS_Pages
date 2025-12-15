using CSharpToJavaScript.APIs.JS;
using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;

GlobalThis.Window.Document.AddEventListener("DOMContentLoaded", (Event e) =>
{
	HTMLElement body = GlobalThis.Window.Document.Body;

	HTMLFormElement todoForm = (body as ParentNode).QuerySelector<HTMLFormElement>("#TodoForm");
	HTMLUListElement ulList = (body as ParentNode).QuerySelector<HTMLUListElement>("#List");

	todoForm.AddEventListener("submit", (Event e) =>
	{
		e.PreventDefault();

		FormData data = new FormData(todoForm);
		
		AddEntry(data, ulList);
		
		Console.WriteLine(data);
	}, true);
}, true);

void AddEntry(FormData data, HTMLUListElement ulList)
{
	HTMLDivElement divElement = (HTMLDivElement)GlobalThis.Window.Document.CreateElement("div");

	string todo_str = data.Get("todo") + " ";

	Text todoText = GlobalThis.Window.Document.CreateTextNode(todo_str);

	HTMLButtonElement buttonElement = (HTMLButtonElement)GlobalThis.Window.Document.CreateElement("button");
	buttonElement.TextContent = "Done";
	
	HTMLLIElement liElement = (HTMLLIElement)GlobalThis.Window.Document.CreateElement("li");

	divElement.AppendChild(todoText);
	divElement.AppendChild(buttonElement);

	liElement.AppendChild(divElement);

	ulList.AppendChild(liElement);
	
	buttonElement.AddEventListener("click", ()=> { DeleteEntry(liElement); }, true);
}

void DeleteEntry(HTMLLIElement li)
{
	(li as ChildNode).Remove();
}
