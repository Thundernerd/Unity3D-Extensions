using System.Collections.Generic;

namespace System.Linq
{
    public static class LinqExtensions
    {
        public static bool None<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return !source.Any(predicate);
        }
    }
}
