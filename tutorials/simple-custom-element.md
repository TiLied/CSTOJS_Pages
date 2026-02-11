# Simple Custom Element

## As of CSharpToJavaScript 0.1.6

cstojs_options.xml:
[!code-xml[](./SimpleCustomElement_Example/cstojs_options.xml)]

Program.cs:
[!code-csharp[](./SimpleCustomElement_Example/Program.cs)]

Translated Program.js:
[!code-javascript[](./SimpleCustomElement_Example/Output/Program.js)]

See the full source code: https://github.com/TiLied/CSTOJS_Pages/tree/main/tutorials/SimpleCustomElement_Example

Live example:

<iframe src="./SimpleCustomElement_Example/Output/index.html"></iframe>

## As of CSharpToJavaScript 0.1.5

Using special syntax `//...\\`.
```csharp
...
//customElements.define("my-element", CustomElement);\\
...
```
Will be translated as:
```javascript
customElements.define("my-element", CustomElement);
```

## Modifying `cstojs_options.xml`.

```xml
 <File Source="./Program.cs">
	<Option AddSBAtTheBottom="customElements.define('my-element', CustomElement);" />
 </File>
```
