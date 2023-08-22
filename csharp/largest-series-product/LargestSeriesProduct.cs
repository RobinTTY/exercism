using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span != 0)
            if (span < 0 || digits.Length < 1 || span > digits.Length || digits.ToList().Any(num => !char.IsDigit(num)))
                throw new ArgumentException();

        // add each factored substring to list and return the largest value
        var results = new List<long>();

        for (var i = 0; i < digits.Length - span + 1; i++)
            results.Add(digits.Substring(i, span).Select(num => long.Parse(num.ToString())).ToArray().Aggregate((long)1, (a, b) => a * b));

        return results.Max();
    }
}