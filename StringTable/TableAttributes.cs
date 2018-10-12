namespace StringTable
{
    public enum Alignment
    {
        Right,
        Center,
        Left
    }

    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public sealed class TableAttribute : System.Attribute
    {
        public Alignment HeadAlign { get; set; } = Alignment.Center;
        public Alignment BodyAlign { get; set; } = Alignment.Right;
        public bool ExcludeByDefault { get; set; }
    }

    [System.AttributeUsage(System.AttributeTargets.Enum |
                           System.AttributeTargets.Field |
                           System.AttributeTargets.Property,
                           Inherited = true,
                           AllowMultiple = false)]
    public sealed class TableColumnAttribute : System.Attribute
    {
        public Alignment HeadAlign { get; set; }
        public Alignment BodyAlign { get; set; }

        public int Order { get; set; }
        public bool Include { get; set; }
        public bool Exclude { get; set; }

        public TableColumnAttribute() { }
    }
}
