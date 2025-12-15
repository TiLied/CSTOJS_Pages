using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;

namespace SimpleModule_Example;

public class Hello
{
	public static void Module()
	{
		GlobalThis.Console.Log("Hello from module!");
	}
}
