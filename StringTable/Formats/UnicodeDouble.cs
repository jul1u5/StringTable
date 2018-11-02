namespace StringTable.Formats
{
    /// <summary> Simple unicode format with double stroke </summary>
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
    public class UnicodeDouble : ITableFormat
    {
        public string HeadTopLeft { get; } = "╔";
        public string HeadTop { get; } = "═";
        public string HeadTopJunction { get; } = "╦";
        public string HeadTopRight { get; } = "╗";

        public string HeadLeft { get; } = "║ ";
        public string HeadSeparator { get; } = " ║ ";
        public string HeadRight { get; } = " ║";

        public string HeadBottomLeft { get; } = "╠";
        public string HeadBottom { get; } = "═";
        public string HeadBottomJunction { get; } = "╬";
        public string HeadBottomRight { get; } = "╣";


        public string BodyLeft { get; } = "║ ";
        public string BodyVerticalSeparator { get; } = " ║ ";
        public string BodyRight { get; } = " ║";

        public string BodyLeftJunction { get; } = "╠";
        public string BodyHorizontalSeparator { get; } = "═";
        public string BodyJunction { get; } = "╬";
        public string BodyRightJunction { get; } = "╣";

        public string BodyBottomLeft { get; } = "╚";
        public string BodyBottom { get; } = "═";
        public string BodyBottomJunction { get; } = "╩";
        public string BodyBottomRight { get; } = "╝";
    }
}