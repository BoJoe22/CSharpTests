using System;
using System.Collections.Generic;

namespace FunctionalCSharp
{
    public static class FunctionalUtilities
    {
        public static IEnumerable<U> Map<T, U>(this IEnumerable<T> myEnumerable, Func<T, U> f)
        {
            foreach (var item in myEnumerable)
                yield return f(item);
        }
    }
}
