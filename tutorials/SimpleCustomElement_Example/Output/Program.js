
class CustomElement extends HTMLElement
{
	constructor() 
	{
		super()
		
	}
	connectedCallback()
	{
		let shadow = this.attachShadow( { mode : "open" });
		shadow.appendChild(globalThis.window.document.createTextNode("Hello from 'my-element'."));
	}
}
class Program
{
	static 
	{
		globalThis.window.customElements.define("my-element", CustomElement);
		
		globalThis.window.document.addEventListener("DOMContentLoaded", (e) =>
		{
			let element = globalThis.window.document.createElement("my-element");
			globalThis.window.document.body.appendChild(element);
		}, true);
	}
}