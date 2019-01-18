namespace StringTable
{
    public static partial class Format
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
        public static readonly TableFormat Compact = new TableFormat(
            headTopLeft: null,
            headTop: null,
            headTopJunction: null,
            headTopRight: null,

            headLeft: null,
            headSeparator: " | ",
            headRight: null,

            headBottomLeft: null,
            headBottom: "-",
            headBottomJunction: "-+-",
            headBottomRight: null,

            bodyLeft: null,
            bodyVerticalSeparator: " | ",
            bodyRight: null,

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
