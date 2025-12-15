## Simple Module

> [!NOTE]
> cstojs-cli 0.1.3 is used.

As of 0.1.3, the only way to use modules is by modifying "cstojs_options.xml".

Program.cs:
[!code-csharp[](./SimpleModule_Example/Program.cs)]

Module.cs:
[!code-csharp[](./SimpleModule_Example/Module.cs)]

cstojs_options.xml:
[!code-xml[](./SimpleModule_Example/cstojs_options.xml)]

Translated Program.js:
[!code-javascript[](./SimpleModule_Example/Output/Program.js)]

Translated Module.js:
[!code-javascript[](./SimpleModule_Example/Output/Module.js)]

Now, if you run `node ./Program.js`, you will see "Hello from module!" in the console.
![console](../images/SimpleModule_Images/0.png)

See the full source code: https://github.com/TiLied/CSTOJS_Pages/tree/main/tutorials/SimpleModule_Example
