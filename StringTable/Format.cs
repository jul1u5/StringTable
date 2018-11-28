namespace StringTable
{
    public enum Format
    {
        /// <summary> Compact format </summary>
        /// <example>
        /// <code>
        /// Example |    Test
        /// --------+--------
        ///     123 | Example
        ///     abc | Example
        /// </code>
        /// </example>
        Compact,
        /// <summary> Markdown format </summary>
        /// <example>
        /// <code>
        /// | Example |    Test |
        /// | ------- | ------- |
        /// |     123 | Example |
        /// |     abc | Example |
        /// </code>
        /// </example>
        Markdown,
        /// <summary> MySQL-like format </summary>
        /// <example>
        /// <code>
        /// +---------+---------+
        /// | Example |    Test |
        /// +---------+---------+
        /// |     123 | Example |
        /// |     abc | Example |
        /// +---------+---------+
        /// </code>
        /// </example>
        MySQL,
        /// <summary> Unicode format with bold head </summary>
        /// <example>
        /// <code>
        /// ┏━━━━━━━━━┳━━━━━━━━━┓
        /// ┃ Example ┃    Test ┃
        /// ┡━━━━━━━━━╇━━━━━━━━━┩
        /// │     123 │ Example │
        /// ├─────────┼─────────┤
        /// │     abc │ Example │
        /// └─────────┴─────────┘
        /// </code>
        /// </example>
        Unicode,
        /// <summary> Unicode format with double stroke </summary>
        /// <example>
        /// <code>
        /// ╔═════════╦═════════╗
        /// ║ Example ║    Test ║
        /// ╠═════════╬═════════╣
        /// ║     123 ║ Example ║
        /// ╠═════════╬═════════╣
        /// ║     abc ║ Example ║
        /// ╚═════════╩═════════╝
        /// </code>
        /// </example>
        UnicodeDouble,
        /// <summary> Unicode format with single stroke </summary>
        /// <example>
        /// <code>
        /// ┌─────────┬─────────┐
        /// │ Example │    Test │
        /// ├─────────┼─────────┤
        /// │     123 │ Example │
        /// ├─────────┼─────────┤
        /// │     abc │ Example │
        /// └─────────┴─────────┘
        /// </code>
        /// </example>
        UnicodeSingle,
    }
}
