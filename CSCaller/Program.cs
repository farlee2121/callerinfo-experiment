
using System;
using GatherCallerInfo;

var callerInfo = UsesCallerAttributes.GetCallerInfo();
// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Caller info: {callerInfo}");
