using System;
using System.Collections.Generic;
using Xunit;
using StringTable;

namespace StringTable.Tests
{
    public class Table2x2OfPoints
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        List<Point> list;

        public Table2x2OfPoints()
        {
            list = new List<Point> {
                new Point { X = 1, Y = 3 },
                new Point { X = 2, Y = 5 }
            };
        }

        [Fact]
        public void ReturnDefaultStringTable()
        {
            var stringTable = list.ToTable(Format.Markdown).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "| X | Y |",
                    "| - | - |",
                    "| 1 | 3 |",
                    "| 2 | 5 |"
                ) + Environment.NewLine,
                stringTable
            );
        }
    }

    public class Table2x2Dictionary
    {
        Dictionary<int, string> dict;

        public Table2x2Dictionary()
        {
            dict = new Dictionary<int, string> {
                { 1, "Test" },
                { 2, "Example" }
            };
        }

        [Fact]
        public void ReturnDefaultStringTable()
        {
            var stringTable = dict.ToTable(Format.Markdown).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "| Key |  Value  |",
                    "| --- | ------- |",
                    "|   1 |    Test |",
                    "|   2 | Example |"
                ) + Environment.NewLine,
                stringTable
            );
        }
    }

    public class Table2x2OfDynamicTypes
    {
        List<dynamic> list;

        public Table2x2OfDynamicTypes()
        {
            list = new List<dynamic> {
                new { A = 1, B = 3 },
                new { C = 2, D = 5 }
            };
        }

        [Fact]
        public void ReturnDefaultStringTable()
        {
            var stringTable = list.ToTable(Format.Markdown).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "| A/C | B/D |",
                    "| --- | --- |",
                    "|   1 |   3 |",
                    "|   2 |   5 |"
                ) + Environment.NewLine,
                stringTable
            );
        }
    }

    public class Table5x2OfDerivedObjects
    {
        class Base
        {
            public int BaseA { get; set; }
            public int BaseB { get; set; }
        }

        class Derived1 : Base
        {
            public int Derived { get; set; }
            public int DerivedA { get; set; }
            public int DerivedA2 { get; set; }
        }

        class Derived2 : Base
        {
            public int Derived { get; set; }
            public int DerivedB { get; set; }
        }

        List<Base> list;

        public Table5x2OfDerivedObjects()
        {
            list = new List<Base> {
                new Derived1() { BaseA = 1, BaseB = 2, Derived = 3, DerivedA = 4, DerivedA2 = 5 },
                new Derived2() { BaseA = 5, BaseB = 6, Derived = 7, DerivedB = 8 },
            };
        }

        [Fact]
        public void ReturnDefaultStringTable()
        {
            var stringTable = list.ToTable(Format.Markdown).ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "| Base A | Base B | Derived | Derived A/Derived B | Derived A2 |",
                    "| ------ | ------ | ------- | ------------------- | ---------- |",
                    "|      1 |      2 |       3 |                   4 |          5 |",
                    "|      5 |      6 |       7 |                   8 |            |"
                ) + Environment.NewLine,
                stringTable
            );
        }
    }
}
