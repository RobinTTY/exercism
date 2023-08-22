using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2 || outputBase < 2 || !inputDigits.All(num => num < inputBase && num >= 0))
            throw new ArgumentException();

        return inputDigits.ToDecimal(inputBase).FromDecimalToBase(outputBase);
    }

    private static int ToDecimal(this IReadOnlyCollection<int> inputDigits, int inputBase) => inputDigits.Select((t, i) => t * (int)Math.Pow(inputBase, inputDigits.Count - i - 1)).Sum();

    private static int[] FromDecimalToBase(this int input, int outputBase)
    {
        var result = new List<int>();

        while (input != 0)
        {
            result.Add(input % outputBase);
            input /= outputBase;
        }

        if(result.Count == 0)
            result.Add(0);
        return result.ToArray().Reverse().ToArray();
    }
}