using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using StringTable.Utilities;

namespace StringTable
{
    public class StringTable
    {
        public IEnumerable<string> Columns { get; }
        public IEnumerable<IEnumerable<string>> Rows { get; }

        public StringTable(IEnumerable<string> columns, IEnumerable<IEnumerable<object>> rows)
        {
            Columns = columns.Select(col => col.SplitCamelCase());

            Rows = rows.Select(row => row
                .Concat(Enumerable.Repeat<object>(
                    null, 
                    Math.Max(Columns.Count() - row.Count(), 0))
                )
                .Select(cell => cell?.ToString() ?? "")
            );
        }

        public override string ToString()
        {
            int[] widths = Columns
                .Select(col => col.Length)
                .Zip(
                    Rows.Transpose().Select(row => row.Max(cell => cell?.Length ?? 0)),
                    (head, rows) => Math.Max(head, rows)
                ).ToArray();

            StringBuilder table = new StringBuilder();

            table.AppendLine(Columns
                .Select((columnName, index) => columnName.PadRight(widths[index]))
                .Wrap("|")
            );

            table.AppendLine(widths
                .Select(width => new string('-', width))
                .Wrap("|")
            );

            table.AppendLine(string.Join(Environment.NewLine, Rows
                .Select(row => row
                    .Select((cell, i) => cell.PadRight(widths[i]))
                    .Wrap("|")
                )
            ));

            return table.ToString();
        }
    }
}
