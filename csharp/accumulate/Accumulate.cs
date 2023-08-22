using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    // using Select would be better syntax but per instructions without linq
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (var item in collection)
            yield return func(item);
    }
}