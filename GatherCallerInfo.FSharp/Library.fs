namespace GatherCallerInfo.FSharp
open  System.Runtime.CompilerServices
open System.Runtime.InteropServices
open System

type CallerInfoFS = {
    filePath: string option
    lineNumber: int option
}

type CallerInfoFSClass () =

    // Offical docs say this is supposed to work: https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/caller-information
    static member GetCallerInfo (
        [<CallerFilePath; Optional; DefaultParameterValue("")>] ?path: string,
        [<CallerLineNumber; Optional; DefaultParameterValue(0)>] ?line: int) = 
        { 
            filePath = path; 
            lineNumber = line 
        }

    static member GetCallerInfoNoOptions (
        [<CallerFilePath; Optional; DefaultParameterValue("")>] path: string,
        [<CallerLineNumber; Optional; DefaultParameterValue(0)>] line: int) = 
        { 
            filePath = if String.IsNullOrEmpty(path) then None else Some path; 
            lineNumber = if line = 0 then None else Some line
        }


module CallerInfoModule = 
    let getCallerInfo = CallerInfoFSClass.GetCallerInfo