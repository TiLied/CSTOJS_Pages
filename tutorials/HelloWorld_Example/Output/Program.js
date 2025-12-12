
globalThis.window.document.addEventListener("DOMContentLoaded", (e) =>
{
	let body = globalThis.window.document.body;

	let paragraph = globalThis.window.document.createElement("p");
	let helloWorld = globalThis.window.document.createTextNode("Hello, World!");
	
		
	paragraph.appendChild(helloWorld);

	body.append(paragraph);
}, true);
