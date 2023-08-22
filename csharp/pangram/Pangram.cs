using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // case insensitive is required
        input = input.ToLower();
        var set = "abcdefghijklmnopqrstuvwxyz".ToArray();

        // Check if all characters in the set are contained in the input using linq
        // "All" will only return true if every element of the array fulfills the condition
        return set.All(s => input.Contains(s));
    }
}
