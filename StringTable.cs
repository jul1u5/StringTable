using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StringTable
{
    public class StringTable : DataTable
    {
        public StringTable() : base() { }
        public StringTable(string tableName) : base(tableName) { }
        public StringTable(string tableName, string tableNamespace) : base(tableName, tableNamespace) { }

        public override string ToString()
        {
            int[] widths = Columns.Cast<DataColumn>()
                .Select(col => col.ColumnName.Length)
                .Zip(Rows.Cast<DataRow>()
                    .Select(row => row.ItemArray
                        .Select(cell => Enumerable.Repeat(cell, 1))
                    )
                    .Aggregate((a, b) => a.Zip(b, Enumerable.Concat))
                    .Select(col => col
                        .Max(cell => cell?.ToString().Length)
                    ),
                    (head, rows) => Math.Max(head, rows ?? 0)
                ).ToArray();

            StringBuilder table = new StringBuilder();

            table.AppendLine(Columns.Cast<DataColumn>()
                .Select(col => col.ColumnName)
                .Select((text, index) =>
                    text.PadRight(widths[index])
                ).Wrap("|")
            );

            table.AppendLine(widths
                .Select(width => new string('-', width))
                .Wrap("|")
            );

            table.AppendLine(string.Join(Environment.NewLine,
                Rows.Cast<DataRow>()
                .Select(row => row.ItemArray
                    .Select((cell, i) =>
                        cell.ToString().PadRight(widths[i])
                    ).Wrap("|")
                )
            ));

            return table.ToString();
        }
    }
}
