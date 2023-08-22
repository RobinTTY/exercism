using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    // most starred answer is shorter code but not efficient for big max values,
    // since a loop is executed with as many iterations as the passed in max value
    // (testing with stopwatch results in most starred answer being up to 8 times slower)
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var result = new HashSet<int>();

        multiples.ToList().ForEach(num =>
        {
            if (num == 0)
                return;

            for (var i = 1; num * i < max; i++)
                result.Add(num * i);
        });

        return result.Sum();
    }
}