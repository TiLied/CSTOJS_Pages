
globalThis.window.document.addEventListener("DOMContentLoaded", (e) => {
	let body = globalThis.window.document.body;

	let todoForm = body.querySelector("#TodoForm");
	let ulList = body.querySelector("#List");

	
	todoForm.addEventListener("submit", (e) => {
		
				
		e.preventDefault();

		let data = new FormData(todoForm);
		
				
		AddEntry(data, ulList);
		
		console.log(data);
	}, true);
}, true);

function AddEntry(data, ulList) {
	let divElement = globalThis.window.document.createElement("div");

	//Hack, "Union237" is not converting to a string implicitly.
	//I need another way around "Union237" to string, not string to "Union237"
	//Union237 test = "str";
	let todo_str = data.get("todo") + " ";

	let todoText = globalThis.window.document.createTextNode(todo_str);

	let buttonElement = globalThis.window.document.createElement("button");
	
		
	buttonElement.textContent = "Done";
	
	let liElement = globalThis.window.document.createElement("li");

	
	divElement.appendChild(todoText);
	
		
	divElement.appendChild(buttonElement);

	
	liElement.appendChild(divElement);

	
	ulList.appendChild(liElement);
	
		
	buttonElement.addEventListener("click", ()=> { DeleteEntry(liElement); }, true);
}

function DeleteEntry(li) {
	li.remove();
}
