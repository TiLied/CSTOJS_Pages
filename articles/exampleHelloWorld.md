# Example "Hello World!"

Create new c# project.
> [!NOTE]
> Make sure to use full path in "GenerateOneAsync" method! 

Program.cs
```csharp
using CSharpToJavaScript;

namespace TestNuget;

public class Program
{
	public static async Task Main()
	{
		CSTOJS cstojs = new();
		await cstojs.GenerateOneAsync("C:\\GitReps\\TestNuget\\TestNuget\\CSharp\\Test.cs");
		
		Console.ReadKey();
	}
}
```

Add new folder "CSharp" and new file name "Test".

CSharp/Test.cs
```csharp
using static CSharpToJavaScript.APIs.JS.GlobalObject;
namespace TestNuget.CSharp;

public class Test
{
	public Test()
	{
		GlobalThis.Console.Log("Hello World!");
	}
}
```

Run. Above code will generate Test.js file that contains:

```javascript
class Test
{
	constructor()
 	{
   		globalThis.console.log("Hello World!");
 	}
}
```