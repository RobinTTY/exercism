using System.Collections.Generic;
using System.Threading.Tasks;

// This code is performance oriented and can calculate the triplets for 30000 in ~0.2ms and for 268430050 in ~600ms
// This is a simple implementation of Euclid's formula (rearranged to the given task)
public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int N)
    {
        var set = new HashSet<(int, int, int)>();

        // If the given sum is odd, return immediately.
        // No Pythagorean triple will have an odd sum.
        if (N % 2 == 1)
            return new List<(int a, int b, int c)>();

        // parallel operation has a certain overhead and won't be effective until N is a certain size
        // 1 000 000 is just an estimate and might be a bad cutoff to start using parallel execution
        // the cutoff point where it pays off to use parallel execution also depends on the CPU
        var aBound = N / 2;
        if (N < 1_000_000)
            for (var a = 1; a <= aBound; a++)
                AddIfTriplet(set, a, N);
        else
            Parallel.For(1, aBound + 1, a =>
            {
                AddIfTriplet(set, a, N);
            });

        return set;
    }

    private static void AddIfTriplet(ISet<(int, int, int)> set, int a, int N)
    {
        // Check whether b would be a whole number
        if ((int)(a * (long)N % (a - N)) != 0)
            return;

        // rearranged Euclid's formula
        var b = (int)((long)N * (2 * a - N) / (2 * a - 2 * (long)N));
        var c = N - a - b;

        if (a < b)
            set.Add((a, b, c));
    }
}