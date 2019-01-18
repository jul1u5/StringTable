namespace StringTable
{
    public static partial class Format
    {
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
        public static readonly TableFormat Unicode = new TableFormat(
            headTopLeft: "┏━",
            headTop: "━",
            headTopJunction: "━┳━",
            headTopRight: "━┓",

            headLeft: "┃ ",
            headSeparator: " ┃ ",
            headRight: " ┃",

            headBottomLeft: "┡━",
            headBottom: "━",
            headBottomJunction: "━╇━",
            headBottomRight: "━┩",

            bodyLeft: "│ ",
            bodyVerticalSeparator: " │ ",
            bodyRight: " │",

            bodyLeftJunction: "├─",
            bodyHorizontalSeparator: "─",
            bodyJunction: "─┼─",
            bodyRightJunction: "─┤",

            bodyBottomLeft: "└─",
            bodyBottom: "─",
            bodyBottomJunction: "─┴─",
            bodyBottomRight: "─┘"
        );
    }
}
