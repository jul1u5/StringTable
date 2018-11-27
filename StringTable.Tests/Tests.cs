using System;
using System.Collections.Generic;
using Xunit;
using StringTable;

namespace StringTable.Tests
{
    public class Table2x2OfObjects
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        List<Point> listOfPoints;

        public Table2x2OfObjects()
        {
            listOfPoints = new List<Point> {
                new Point() { X = 1, Y = 3 },
                new Point() { X = 2, Y = 5 }
            };
        }

        [Fact]
        public void ReturnDefaultStringTable()
        {
            var stringTable = listOfPoints.ToTable().ToString();

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

    public class Table2x2OfDerivedTypes
    {
        List<dynamic> list;

        public Table2x2OfDerivedTypes()
        {
            list = new List<dynamic> {
                new { A = 1, B = 3 },
                new { C = 2, D = 5 }
            };
        }

        [Fact]
        public void ReturnDefaultStringTable()
        {
            var stringTable = list.ToTable().ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "| A/C | B/D |",
                    "| --- | --- |",
                    "| 1   | 3   |",
                    "| 2   | 5   |"
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
            var stringTable = list.ToTable().ToString();

            Assert.Equal(
                string.Join(Environment.NewLine,
                    "| Base A | Base B | Derived | Derived A/Derived B | Derived A2 |",
                    "| ------ | ------ | ------- | ------------------- | ---------- |",
                    "| 1      | 2      | 3       | 4                   | 5          |",
                    "| 5      | 6      | 7       | 8                   |            |"
                ) + Environment.NewLine,
                stringTable
            );
        }
    }
}
