namespace StringTable
{
    public class TableFormat
    {
        public string HeadTopLeft { get; }
        public string HeadTop { get; }
        public string HeadTopJunction { get; }
        public string HeadTopRight { get; }

        public string HeadLeft { get; }
        public string HeadSeparator { get; }
        public string HeadRight { get; }

        public string HeadBottomLeft { get; }
        public string HeadBottom { get; }
        public string HeadBottomJunction { get; }
        public string HeadBottomRight { get; }

        public string BodyLeft { get; }
        public string BodyVerticalSeparator { get; }
        public string BodyRight { get; }

        public string BodyLeftJunction { get; }
        public string BodyHorizontalSeparator { get; }
        public string BodyJunction { get; }
        public string BodyRightJunction { get; }

        public string BodyBottomLeft { get; }
        public string BodyBottom { get; }
        public string BodyBottomJunction { get; }
        public string BodyBottomRight { get; }

        public TableFormat(
            string headTopLeft,
            string headTop,
            string headTopJunction,
            string headTopRight,
            string headLeft,
            string headSeparator,
            string headRight,
            string headBottomLeft,
            string headBottom,
            string headBottomJunction,
            string headBottomRight,
            string bodyLeft,
            string bodyVerticalSeparator,
            string bodyRight,
            string bodyLeftJunction,
            string bodyHorizontalSeparator,
            string bodyJunction,
            string bodyRightJunction,
            string bodyBottomLeft,
            string bodyBottom,
            string bodyBottomJunction,
            string bodyBottomRight)
        {
            HeadTopLeft = headTopLeft;
            HeadTop = headTop;
            HeadTopJunction = headTopJunction;
            HeadTopRight = headTopRight;
            HeadLeft = headLeft;
            HeadSeparator = headSeparator;
            HeadRight = headRight;
            HeadBottomLeft = headBottomLeft;
            HeadBottom = headBottom;
            HeadBottomJunction = headBottomJunction;
            HeadBottomRight = headBottomRight;

            BodyLeft = bodyLeft;
            BodyVerticalSeparator = bodyVerticalSeparator;
            BodyRight = bodyRight;
            BodyLeftJunction = bodyLeftJunction;
            BodyHorizontalSeparator = bodyHorizontalSeparator;
            BodyJunction = bodyJunction;
            BodyRightJunction = bodyRightJunction;
            BodyBottomLeft = bodyBottomLeft;
            BodyBottom = bodyBottom;
            BodyBottomJunction = bodyBottomJunction;
            BodyBottomRight = bodyBottomRight;
        }
    }
}
