using Xunit;
using StringTable;
using System.Collections.Generic;
using System;

namespace StringTable.Tests
{
    public class Table2x2
    {
        class ExampleClass
        {
            public object Example { get; set; }
            public string Test { get; set; }
        }

        List<ExampleClass> list;

        public Table2x2()
        {
            list = new List<ExampleClass> {
                new ExampleClass() { Example = 123, Test = "Example" },
                new ExampleClass() { Example = "abc", Test = "Example" }
            };
        }

        [Fact]
        public void ReturnCompactStringTable()
        {
            var stringTable = list.ToTable(Format.Compact).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "Example |  Test  ",
                    "--------+--------",
                    "    123 | Example",
                    "    abc | Example"
                ) + Environment.NewLine,
                stringTable
            );
        }

        [Fact]
        public void ReturnMarkdownStringTable()
        {
            var stringTable = list.ToTable(Format.Markdown).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "| Example |  Test   |",
                    "| ------- | ------- |",
                    "|     123 | Example |",
                    "|     abc | Example |"
                ) + Environment.NewLine,
                stringTable
            );
        }

        [Fact]
        public void ReturnMySQLStringTable()
        {
            var stringTable = list.ToTable(Format.MySQL).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "+---------+---------+",
                    "| Example |  Test   |",
                    "+---------+---------+",
                    "|     123 | Example |",
                    "|     abc | Example |",
                    "+---------+---------+"
                ) + Environment.NewLine,
                stringTable
            );
        }

        [Fact]
        public void ReturnUnicodeStringTable()
        {
            var stringTable = list.ToTable(Format.Unicode).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "┏━━━━━━━━━┳━━━━━━━━━┓",
                    "┃ Example ┃  Test   ┃",
                    "┡━━━━━━━━━╇━━━━━━━━━┩",
                    "│     123 │ Example │",
                    "├─────────┼─────────┤",
                    "│     abc │ Example │",
                    "└─────────┴─────────┘"
                ) + Environment.NewLine,
                stringTable
            );
        }

        [Fact]
        public void ReturnUnicodeDoubleStringTable()
        {
            var stringTable = list.ToTable(Format.UnicodeDouble).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "╔═════════╦═════════╗",
                    "║ Example ║  Test   ║",
                    "╠═════════╬═════════╣",
                    "║     123 ║ Example ║",
                    "║     abc ║ Example ║",
                    "╚═════════╩═════════╝"
                ) + Environment.NewLine,
                stringTable
            );
        }

        [Fact]
        public void ReturnUnicodeSingleStringTable()
        {
            var stringTable = list.ToTable(Format.UnicodeSingle).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "┌─────────┬─────────┐",
                    "│ Example │  Test   │",
                    "├─────────┼─────────┤",
                    "│     123 │ Example │",
                    "│     abc │ Example │",
                    "└─────────┴─────────┘"
                ) + Environment.NewLine,
                stringTable
            );
        }
    }
}
