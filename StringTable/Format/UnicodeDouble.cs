namespace StringTable
{
    public static partial class Format
    {
        /// <summary> Unicode format with double stroke </summary>
        /// <example>
        /// <code>
        /// ╔═════════╦═════════╗
        /// ║ Example ║    Test ║
        /// ╠═════════╬═════════╣
        /// ║     123 ║ Example ║
        /// ║     abc ║ Example ║
        /// ╚═════════╩═════════╝
        /// </code>
        /// </example>
        public static TableFormat UnicodeDouble { get; } = new TableFormat(
            headTopLeft: "╔═",
            headTop: "═",
            headTopJunction: "═╦═",
            headTopRight: "═╗",

            headLeft: "║ ",
            headSeparator: " ║ ",
            headRight: " ║",

            headBottomLeft: "╠═",
            headBottom: "═",
            headBottomJunction: "═╬═",
            headBottomRight: "═╣",

            bodyLeft: "║ ",
            bodyVerticalSeparator: " ║ ",
            bodyRight: " ║",

            bodyLeftJunction: null,
            bodyHorizontalSeparator: null,
            bodyJunction: null,
            bodyRightJunction: null,

            bodyBottomLeft: "╚═",
            bodyBottom: "═",
            bodyBottomJunction: "═╩═",
            bodyBottomRight: "═╝"
        );
    }
}
