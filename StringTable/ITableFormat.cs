namespace StringTable
{
    public interface ITableFormat
    {
        string HeadLeft { get; }
        string HeadTopLeftCorner { get; }
        string HeadTop { get; }
        string HeadTopJunction { get; }
        string HeadSeparator { get; }
        string HeadTopRightCorner { get; }
        string HeadRight { get; }

        string HorizontalSeparatorLeft { get; }
        string HorizontalSeparator { get; }
        string HorizontalSeparatorJunction { get; }
        string HorizontalSeparatorRight { get; }

        string BodyLeft { get; }
        string BodyBottomLeftCorner { get; }
        string BodyBottom { get; }
        string BodyBottomJunction { get; }
        string BodySeparator { get; }
        string BodyBottomRightCorner { get; }
        string BodyRight { get; }
    }
}
