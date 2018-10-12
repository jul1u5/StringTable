namespace StringTable
{
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    sealed class TableAttribute : System.Attribute
    {
        public bool ExcludeByDefault { get; set; }
    }

    [System.AttributeUsage(System.AttributeTargets.Enum |
                           System.AttributeTargets.Field |
                           System.AttributeTargets.Property,
                           Inherited = true,
                           AllowMultiple = false)]
    sealed class TableColumnAttribute : System.Attribute
    {
        public int Order { get; set; }
        public bool Include { get; set; }
        public bool Exclude { get; set; }

        public TableColumnAttribute() { }
    }
}
