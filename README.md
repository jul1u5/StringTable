# StringTable

[![Build Status](https://travis-ci.com/jul1u5/StringTable.svg?branch=master)](https://travis-ci.com/jul1u5/StringTable)
[![Build status](https://ci.appveyor.com/api/projects/status/x18cnrlliw91gauc/branch/master?svg=true)](https://ci.appveyor.com/project/jul1u5/StringTable/branch/master)

NuGet Package for formatting enumerables as string tables.

## Examples

### List

```c#
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

var list = new List<Point> {
    new Point() { X = 1, Y = 3 },
    new Point() { X = 2, Y = 5 }
};

Console.WriteLine(list.ToTable());
```
```
| X | Y |
| - | - |
| 1 | 3 |
| 2 | 5 |
```

### Dictionary

```c#
var dict = new Dictionary<int, string> {
    { 1, "Test" },
    { 2, "Example" }
};

Console.WriteLine(dict.ToTable(Format.MySQL));
```
```
+-----+---------+
| Key |  Value  |
+-----+---------+
|   1 |    Test |
|   2 | Example |
+-----+---------+
```

## Table Formats

* [Compact](https://github.com/jul1u5/StringTable/blob/master/StringTable/Formats/Compact.cs)
* [Markdown](https://github.com/jul1u5/StringTable/blob/master/StringTable/Formats/Markdown.cs)
* [MySQL](https://github.com/jul1u5/StringTable/blob/master/StringTable/Formats/MySQL.cs)
* [Unicode](https://github.com/jul1u5/StringTable/blob/master/StringTable/Formats/Unicode.cs)
* [UnicodeSingle](https://github.com/jul1u5/StringTable/blob/master/StringTable/Formats/UnicodeSingle.cs)
* [UnicodeDouble](https://github.com/jul1u5/StringTable/blob/master/StringTable/Formats/UnicodeDouble.cs)
