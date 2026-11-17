# Model example

---

For example this model:
```csharp
public partial class User
{
	private int _ID = 0;
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
}
```
Will be translated as:
```javascript
class User
{
	_ID = 0;
	#_FirstName_= String.raw``;
	get FirstName(){return this.#_FirstName_;}
	set FirstName(value){this.#_FirstName_ = value;}
	#_LastName_= String.raw``;
	get LastName(){return this.#_LastName_;}
	set LastName(value){this.#_LastName_ = value;}
}
```

The library provides various tools to improve or change the output.

For example, if you want to ignore "_ID", you can use [IgnoreAttribute](xref:CSharpToJavaScript.Utils.IgnoreAttribute):
```csharp
using CSharpToJavaScript.Utils;
public partial class User
{
	[Ignore]
	private int _ID = 0;
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
}
```
> [!IMPORTANT]
> A C# project must have a CSharpToJavaScript reference, you can add it through NuGet.

```javascript
class User
{
	#_FirstName_= String.raw``;
	get FirstName(){return this.#_FirstName_;}
	set FirstName(value){this.#_FirstName_ = value;}
	#_LastName_= String.raw``;
	get LastName(){return this.#_LastName_;}
	set LastName(value){this.#_LastName_ = value;}
}
```
With [IgnoreAttribute](xref:CSharpToJavaScript.Utils.IgnoreAttribute) you can ignore fields, properties, methods, or even classes!

With <xref:CSharpToJavaScript.CSTOJSOptions> you can change formating.
For example, with "KeepBraceOnTheSameLine":
```csharp
using CSharpToJavaScript.Utils;
public partial class User
{
	[Ignore]
	private int _ID = 0;
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
}
```
```javascript
class User {
	#_FirstName_= String.raw``;
	get FirstName(){return this.#_FirstName_;}
	set FirstName(value){this.#_FirstName_ = value;}
	#_LastName_= String.raw``;
	get LastName(){return this.#_LastName_;}
	set LastName(value){this.#_LastName_ = value;}
}
```
Another useful option is "MakePropertiesEnumerable", properties in JS are NOT enumerable and JSON will ignore them. This option defines properties with "Object.defineProperty".
> [!IMPORTANT]
> Class must have constructor!
```csharp
using CSharpToJavaScript.Utils;
public partial class User
{
	[Ignore]
	private int _ID = 0;
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	
	public User(){}
}
```
```javascript
class User {
	#_FirstName_= String.raw``;
	#_LastName_= String.raw``;
	
	constructor(){Object.defineProperty(this, 'LastName', { enumerable: true, get: function() { return this.#_LastName_; }, set: function (value) { this.#_LastName_ = value; } });
Object.defineProperty(this, 'FirstName', { enumerable: true, get: function() { return this.#_FirstName_; }, set: function (value) { this.#_FirstName_ = value; } });
}
}
```
Formatting is not that great... You can use "NormalizeWhitespace" to improve it.
 ```javascript
class User {
     #_FirstName_ = String.raw``;
     #_LastName_ = String.raw``;
    constructor() {
        Object.defineProperty(this, 'LastName', { enumerable: true, get: function() { return this.#_LastName_; }, set: function (value) { this.#_LastName_ = value; } });
        Object.defineProperty(this, 'FirstName', { enumerable: true, get: function() { return this.#_FirstName_; }, set: function (value) { this.#_FirstName_ = value; } });
    }
}
```

