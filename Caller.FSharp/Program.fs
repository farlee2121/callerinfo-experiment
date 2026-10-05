// For more information see https://aka.ms/fsharp-console-apps
namespace Caller.FSharp

open System

module Program =
    [<EntryPoint>]
    let main args : int = 
        let fsCallerInfo = GatherCallerInfo.FSharp.CallerInfoFSClass.GetCallerInfo()
        Console.WriteLine($"CallerInfo FS: {fsCallerInfo}")

        let fsmoduleCallerInfo = GatherCallerInfo.FSharp.CallerInfoModule.getCallerInfo()
        Console.WriteLine($"FS Module CallerInfo: {fsmoduleCallerInfo}")

        let csCallerInfo = GatherCallerInfo.UsesCallerAttributes.GetCallerInfo()
        Console.WriteLine($"CS Caller Info: {csCallerInfo}")
        0
