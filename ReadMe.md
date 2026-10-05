# Caller Info Experiment

The goal is to understand how the [caller information attributes](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/caller-information) behave across language, project, and assembly boundaries. 

Particularly I want to see if we can use CallerFilePath and CallerLineNumber to locate tests for [Expecto](https://github.com/haf/expecto/)

## Findings

C# can correctly indentify file and line number across a project boundary.

Langauge mostly doesn't matter. I can get caller info with 
- C# calling F# 
- F# calling C#, but line number maybe doesn't work this way 