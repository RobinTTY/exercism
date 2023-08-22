using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public static class Grains
{
    public static ulong Square(int n) => n <= 0 || n > 64 ?
        throw new ArgumentOutOfRangeException() : n == 1 ? 1 : (ulong)Math.Pow(2, n - 1);

    public static ulong Total() => Enumerable.Range(1, 64).Select(Square).Aggregate((a, b) => a + b);


}