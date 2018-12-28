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
        ITableFormat format;

        public StringTable(IEnumerable<string> columns, IEnumerable<IEnumerable<object>> rows, Format format)
        {
            Columns = columns.Select(col => col.SplitCamelCase());

            Rows = rows.Select(row => row
                .Concat(Enumerable.Repeat<object>(
                    null,
                    Math.Max(Columns.Count() - row.Count(), 0))
                )
                .Select(cell => cell?.ToString() ?? "")
            );

            Format = format;
        }

        public IEnumerable<string> Columns { get; }
        public IEnumerable<IEnumerable<string>> Rows { get; }

        public Format Format
        {
            set
            {
                format = Activator.CreateInstance(Type.GetType("StringTable.Formats." + value.ToString())) as ITableFormat;
            }
        }

        public override string ToString()
        {
            var widths = Columns
                .Select(col => col.Length)
                .Zip(
                    Rows.Transpose().Select(row => row.Max(cell => cell?.Length ?? 0)),
                    (head, rows) => Math.Max(head, rows)
                );

            var table = new StringBuilder();

            if (new[] {
                    format.HeadTopLeft,
                    format.HeadTop,
                    format.HeadTopJunction,
                    format.HeadTopRight,
                }.Any(f => f != null))
                table.AppendLine(widths
                    .Select(w => Enumerable
                        .Repeat(format.HeadTop, w)
                        .Aggregate((acc, str) => acc + str)
                    )
                    .Wrap(format.HeadTopLeft, format.HeadTopJunction, format.HeadTopRight)
                );

            table.AppendLine(Columns
                .Select((col, i) => col.PadLeft(widths.ElementAt(i)))
                .Wrap(format.HeadLeft, format.HeadSeparator, format.HeadRight)
            );

            if (new[] {
                    format.HeadBottomLeft,
                    format.HeadBottom,
                    format.HeadBottomJunction,
                    format.HeadBottomRight,
                }.Any(f => f != null))
                table.AppendLine(widths
                    .Select(w => Enumerable
                        .Repeat(format.HeadBottom, w)
                        .Aggregate((acc, str) => acc + str)
                    )
                    .Wrap(format.HeadBottomLeft, format.HeadBottomJunction, format.HeadBottomRight)
                );

            string rowSeparator = new[] {
                format.BodyLeftJunction,
                format.BodyHorizontalSeparator,
                format.BodyJunction,
                format.BodyRightJunction,
            }.Any(f => f != null)
                ? widths
                    .Select(w => Enumerable
                        .Repeat(format.BodyHorizontalSeparator, w)
                        .Aggregate((acc, str) => acc + str)
                    )
                    .Wrap(format.BodyLeftJunction, format.BodyJunction, format.BodyRightJunction) +
                    Environment.NewLine
                : null;

            table.AppendLine(Rows
                .Select(row => row
                    .Select((cell, i) => cell.PadLeft(widths.ElementAt(i)))
                    .Wrap(format.BodyLeft, format.BodyVerticalSeparator, format.BodyRight)
                )
                .Aggregate((body, row) =>
                    body + Environment.NewLine +
                    rowSeparator +
                    row
                )
            );

            if (new[] {
                    format.BodyBottomLeft,
                    format.BodyBottom,
                    format.BodyBottomJunction,
                    format.BodyBottomRight,
                }.Any(f => f != null))
                table.AppendLine(widths
                    .Select(w => Enumerable
                        .Repeat(format.BodyBottom, w)
                        .Aggregate((acc, str) => acc + str)
                    )
                    .Wrap(format.BodyBottomLeft, format.BodyBottomJunction, format.BodyBottomRight)
                );

            return table.ToString();
        }
    }
}
