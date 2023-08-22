using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        // Split the input string by separators and get first char that is letter
        var abbrev = "";
        phrase.Split(' ', '-').ToList().ForEach(str => abbrev += str.ToArray().FirstOrDefault(char.IsLetter));

        // remove control chars and convert to upper
        return new string(abbrev.Where(c => !char.IsControl(c)).ToArray()).ToUpper();
    }
}