globalThis.window.document.addEventListener("DOMContentLoaded", (e) =>
{
	let canvas = globalThis.window.document.body.querySelector("canvas");
	//hack
	let ctx = canvas.getContext("2d");

	
	ctx.fillStyle = "rgb(180 0 180)";
		ctx.fillRect(50, 50, 50, 50);
}, true);
