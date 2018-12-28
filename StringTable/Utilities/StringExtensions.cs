using System.Text.RegularExpressions;

namespace StringTable.Utilities
{
    static class StringExtensions
    {
        static Regex splitCamelCase = new Regex(@"(?<=[a-z])([A-Z])|(?<=[A-Z])([A-Z][a-z])");

        public static string SplitCamelCase(this string camelCaseString) =>
            splitCamelCase.Replace(camelCaseString, " $1$2");

        public static string Center(this string source, int totalWidth) =>
            source.PadLeft((totalWidth + source.Length) / 2).PadRight(totalWidth);
    }
}
