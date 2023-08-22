using System.Collections.Generic;

public static class PrimeFactors
{
    public static int[] Factors(long number)
    {
        var results = new List<int>();

        for (var divisor = 2; number != 1; divisor++)
            while (number % divisor == 0)
            {
                results.Add(divisor);
                number /= divisor;
            }

        return results.ToArray();
    }
}