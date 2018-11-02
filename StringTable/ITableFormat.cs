namespace StringTable
{
    public interface ITableFormat
    {
        string HeadTopLeft { get; }
        string HeadTop { get; }
        string HeadTopJunction { get; }
        string HeadTopRight { get; }

        string HeadLeft { get; }
        string HeadSeparator { get; }
        string HeadRight { get; }

        string HeadBottomLeft { get; }
        string HeadBottom { get; }
        string HeadBottomJunction { get; }
        string HeadBottomRight { get; }


        string BodyLeft { get; }
        string BodyVerticalSeparator { get; }
        string BodyRight { get; }

        string BodyLeftJunction { get; }
        string BodyHorizontalSeparator { get; }
        string BodyJunction { get; }
        string BodyRightJunction { get; }
        
        string BodyBottomLeft { get; }
        string BodyBottom { get; }
        string BodyBottomJunction { get; }
        string BodyBottomRight { get; }
    }
}
