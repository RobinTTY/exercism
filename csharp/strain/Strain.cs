using System;
using System.Collections.Generic;
using System.Linq;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate) => collection.Where(predicate);

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        // avoid multiple enumerations of linq query by assigning to variable
        var enumerable = collection as T[] ?? collection.ToArray();
        return enumerable.Except(enumerable.Keep(predicate));
    }
}