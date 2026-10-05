# Caller Info Experiment

The goal is to understand how the [caller information attributes](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/caller-information) behave across language, project, and assembly boundaries. 

Particularly I want to see if we can use CallerFilePath and CallerLineNumber to locate tests for [Expecto](https://github.com/haf/expecto/)

## Findings

C# can correctly indentify file and line number across a project boundary.

Langauge mostly doesn't matter. I can get caller info with 
- C# calling F# 
- F# calling C#, but line number maybe doesn't work this way 


Q: What about across package boundaries?
- A: all the previous scenarios behave the same when referenced as a package as they did when referenced as a project


Q: The attributes can only be on type members, but can I proxy them through a module?
- A: No, it returns the line number of the module where it's proxied

CONCLUSION: If I want to try this with expecto, it'll require migrating all of the test functions like `testCase` to type members 