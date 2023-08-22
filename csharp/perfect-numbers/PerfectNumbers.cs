using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException();

        var aliquotSum = CalculateAliquotSum(number);

        return aliquotSum == number ? Classification.Perfect :
            aliquotSum > number ? Classification.Abundant : Classification.Deficient;
    }

    private static int CalculateAliquotSum(int n)
    {
        var sum = 0;

        // get the factors of n by dividing and only taking results that are natural numbers
        for (var i = 1; n / 2 >= i; i++)
        {
            var result = (double)n / i;
            if (result % 1 == 0)
                sum += i;
        }

        return sum;
    }
}
