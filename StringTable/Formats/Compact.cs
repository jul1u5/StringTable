namespace StringTable.Formats
{
    /// <summary> MySQL-like format </summary>
    /// <example> 
    /// <code>
    /// Example |    Test
    /// --------+--------
    ///     123 | Example
    ///     abc | Example
    /// </code>
    /// </example> 
    public class Compact : ITableFormat
    {
        public string HeadTopLeft { get; } = null;
        public string HeadTop { get; } = null;
        public string HeadTopJunction { get; } = null;
        public string HeadTopRight { get; } = null;

        public string HeadLeft { get; } = null;
        public string HeadSeparator { get; } = " | ";
        public string HeadRight { get; } = null;

        public string HeadBottomLeft { get; } = null;
        public string HeadBottom { get; } = "-";
        public string HeadBottomJunction { get; } = "+";
        public string HeadBottomRight { get; } = null;


        public string BodyLeft { get; } = null;
        public string BodyVerticalSeparator { get; } = " | ";
        public string BodyRight { get; } = null;

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
