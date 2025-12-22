
class Program
{
	static 
	{
		globalThis.window.document.addEventListener("DOMContentLoaded", (e) =>
		{
			let element = globalThis.window.document.body.querySelector("#Element");
			let shadow = element.attachShadow({ mode : "open" });

			let template = globalThis.window.document.body.querySelector("#tempElement");

			shadow.appendChild(template.content);
		}, true);
	}
}