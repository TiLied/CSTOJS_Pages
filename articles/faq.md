# FAQ
Q. Why did you write this library?

A. The whole purpose is to learn and understand better c# and js at the same time.

Q. For what is the use case for this library?

A. The only use case I can think of is converting models/DTO/etc. as is from c# to js.(You can do it in web version: https://tilied.github.io/CSTOJS_Pages/BWA/). Anything else is just an extra.

Q. How to use methods that in Interfaces? Like [Append](xref:CSharpToJavaScript.APIs.JS.ParentNode.Append(CSharpToJavaScript.APIs.JS.Union29[])) etc.

A. Currently only supported is through [as operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator). Example:
```csharp
(GlobalThis.Window.Document.Head as ParentNode).Append(...);
```

Q. Is this library used in any "real" projects?

A. You can check one of [my script(Pinterest Plus)](https://github.com/TiLied/Pinterest_Plus), if its count as project.