using System.Collections.Generic;
using System.Linq;

namespace StringTable.Utilities
{
    static class LinqExtensions
    {
        public static IEnumerable<IEnumerable<T>> Transpose<T>(this IEnumerable<IEnumerable<T>> matrix) => matrix
            .Any(row => row.Count() > 0)
                ? new[] { matrix.Select(row => row.FirstOrDefault()) }
                    .Concat(matrix.Select(row => row.Skip(1)).Transpose())
                : Enumerable.Empty<IEnumerable<T>>();

        public static string Wrap(this IEnumerable<string> text, string sep) =>
            $"{sep} {string.Join($" {sep} ", text)} {sep}";
    }
}
