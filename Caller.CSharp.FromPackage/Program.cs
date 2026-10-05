
using System;
using GatherCallerInfo;

var csCallerInfo = GatherCallerInfo.UsesCallerAttributes.GetCallerInfo();
Console.WriteLine($"CS Caller Info: {csCallerInfo}");

var fsCallerInfo = GatherCallerInfo.FSharp.CallerInfoFSClass.GetCallerInfoNoOptions();
Console.WriteLine($"FS Caller Info: {fsCallerInfo}");

var fsmoduleCallerInfo = GatherCallerInfo.FSharp.CallerInfoModule.getCallerInfo();
Console.WriteLine($"FS Module CallerInfo: {fsmoduleCallerInfo}");