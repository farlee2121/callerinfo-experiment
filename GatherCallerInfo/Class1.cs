namespace GatherCallerInfo;

using System.Runtime.CompilerServices;

public record CallerInfo (
    string? CallerFileName,
    int? CallerLineNumber
);
public static class UsesCallerAttributes
{
    public static CallerInfo GetCallerInfo([CallerFilePath] string? filePath = null, [CallerLineNumber] int? lineNumber = null)
    {
        return new CallerInfo(filePath, lineNumber);
    }
}
