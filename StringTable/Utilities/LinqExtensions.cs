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

        public static string Wrap(this IEnumerable<string> enumerable, string left, string middle, string right) =>
            left +
            enumerable.Aggregate((acc, value) => acc + middle + value) +
            right;
    }
}
