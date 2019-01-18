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
        public StringTable(IEnumerable<string> columns, IEnumerable<IEnumerable<object>> rows, TableFormat format)
        {
            Columns = columns;

            Rows = rows.Select(row => row
                .Concat(Enumerable.Repeat<object>(
                    null,
                    Math.Max(Columns.Count() - row.Count(), 0))
                )
                .Select(cell => cell?.ToString() ?? "")
            );

            Format = format;
        }

        TableFormat Format { get; set; }

        public IEnumerable<string> Columns { get; }
        public IEnumerable<IEnumerable<string>> Rows { get; }

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
                    Format.HeadTopLeft,
                    Format.HeadTop,
                    Format.HeadTopJunction,
                    Format.HeadTopRight,
                }.Any(f => f != null))
                table.AppendLine(widths
                    .Select(w => Enumerable
                        .Repeat(Format.HeadTop, w)
                        .Aggregate((acc, str) => acc + str)
                    )
                    .Wrap(Format.HeadTopLeft, Format.HeadTopJunction, Format.HeadTopRight)
                );

            table.AppendLine(Columns
                .Select((col, i) => col.Center(widths.ElementAt(i)))
                .Wrap(Format.HeadLeft, Format.HeadSeparator, Format.HeadRight)
            );

            if (new[] {
                    Format.HeadBottomLeft,
                    Format.HeadBottom,
                    Format.HeadBottomJunction,
                    Format.HeadBottomRight,
                }.Any(f => f != null))
                table.AppendLine(widths
                    .Select(w => Enumerable
                        .Repeat(Format.HeadBottom, w)
                        .Aggregate((acc, str) => acc + str)
                    )
                    .Wrap(Format.HeadBottomLeft, Format.HeadBottomJunction, Format.HeadBottomRight)
                );

            string rowSeparator = new[] {
                Format.BodyLeftJunction,
                Format.BodyHorizontalSeparator,
                Format.BodyJunction,
                Format.BodyRightJunction,
            }.Any(f => f != null)
                ? widths
                    .Select(w => Enumerable
                        .Repeat(Format.BodyHorizontalSeparator, w)
                        .Aggregate((acc, str) => acc + str)
                    )
                    .Wrap(Format.BodyLeftJunction, Format.BodyJunction, Format.BodyRightJunction) +
                    Environment.NewLine
                : null;

            table.AppendLine(Rows
                .Select(row => row
                    .Select((cell, i) => cell.PadLeft(widths.ElementAt(i)))
                    .Wrap(Format.BodyLeft, Format.BodyVerticalSeparator, Format.BodyRight)
                )
                .Aggregate((body, row) =>
                    body + Environment.NewLine +
                    rowSeparator +
                    row
                )
            );

            if (new[] {
                    Format.BodyBottomLeft,
                    Format.BodyBottom,
                    Format.BodyBottomJunction,
                    Format.BodyBottomRight,
                }.Any(f => f != null))
                table.AppendLine(widths
                    .Select(w => Enumerable
                        .Repeat(Format.BodyBottom, w)
                        .Aggregate((acc, str) => acc + str)
                    )
                    .Wrap(Format.BodyBottomLeft, Format.BodyBottomJunction, Format.BodyBottomRight)
                );

            return table.ToString();
        }
    }
}
