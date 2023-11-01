using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string separator)
    {
        int position = str.IndexOf(separator);
        return str.Substring(position + separator.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string start, string end)
    {
        int startPosition = str.IndexOf(start);
        int endPosition = str.IndexOf(end);
        return str.Substring(startPosition + start.Length, endPosition - startPosition - start.Length);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}