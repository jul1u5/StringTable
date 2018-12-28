namespace StringTable.Formats
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
    internal class Markdown : ITableFormat
    {
        public string HeadTopLeft { get; } = null;
        public string HeadTop { get; } = null;
        public string HeadTopJunction { get; } = null;
        public string HeadTopRight { get; } = null;

        public string HeadLeft { get; } = "| ";
        public string HeadSeparator { get; } = " | ";
        public string HeadRight { get; } = " |";

        public string HeadBottomLeft { get; } = "| ";
        public string HeadBottom { get; } = "-";
        public string HeadBottomJunction { get; } = " | ";
        public string HeadBottomRight { get; } = " |";


        public string BodyLeft { get; } = "| ";
        public string BodyVerticalSeparator { get; } = " | ";
        public string BodyRight { get; } = " |";

        public string BodyLeftJunction { get; } = null;
        public string BodyHorizontalSeparator { get; } = null;
        public string BodyJunction { get; } = null;
        public string BodyRightJunction { get; } = null;

        public string BodyBottomLeft { get; } = null;
        public string BodyBottom { get; } = null;
        public string BodyBottomJunction { get; } = null;
        public string BodyBottomRight { get; } = null;
    }
}
