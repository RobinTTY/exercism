using System;
using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        var scoreMapping = new Dictionary<string, int>
        {
            { "AEIOULNRST", 1 },
            { "DG", 2 },
            { "BCMP", 3 },
            { "FHVWY", 4 },
            { "K", 5 },
            { "JX", 8 },
            { "QZ", 10 }
        };

        var sum = 0;
        input.ToUpper().ToList().ForEach(ch => scoreMapping.ToList().ForEach(kvp =>
        {
            if (kvp.Key.Contains(ch))
                sum += scoreMapping[kvp.Key];
        }));

        return sum;
    }
}