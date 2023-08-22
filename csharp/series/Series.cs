using System;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if(sliceLength > numbers.Length || sliceLength <= 0)
            throw new ArgumentException();

        var iterations = numbers.Length - sliceLength + 1;
        return Enumerable.Range(0, iterations).ToList().Select(num => numbers.Substring(num, sliceLength)).ToArray();
    }
}