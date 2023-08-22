using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        // strip the input of hyphens and spaces and then compare the number of distinct characters to the total count of chars
        // Where will filter the input (our sentence) into a new form using our condition (no hyphens or spaces)
        // Distinct will return all the distinct elements of the new form, which we can then count

        var strippedString = word.ToLower().Where(character => character != '-' && character != ' ').ToArray();
        return strippedString.Distinct().Count() == strippedString.Length;
    }
}
