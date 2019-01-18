namespace StringTable
{
    public static partial class Format
    {
        /// <summary> Markdown format </summary>
        /// <example>
        /// <code>
        /// | Example |     Test |
        /// | ------- | -------- |
        /// |     123 |  Example |
        /// |     abc |  Example |
        /// </code>
        /// </example>
        public static TableFormat Markdown { get; } = new TableFormat(
            headTopLeft: null,
            headTop: null,
            headTopJunction: null,
            headTopRight: null,

            headLeft: "| ",
            headSeparator: " | ",
            headRight: " |",

            headBottomLeft: "| ",
            headBottom: "-",
            headBottomJunction: " | ",
            headBottomRight: " |",

            bodyLeft: "| ",
            bodyVerticalSeparator: " | ",
            bodyRight: " |",

            bodyLeftJunction: null,
            bodyHorizontalSeparator: null,
            bodyJunction: null,
            bodyRightJunction: null,

            bodyBottomLeft: null,
            bodyBottom: null,
            bodyBottomJunction: null,
            bodyBottomRight: null
        );
    }
}
