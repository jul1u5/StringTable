using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using StringTable.Utilities;

namespace StringTable
{
    public static class Extensions
    {
        public static StringTable ToTable<T>(this IEnumerable<T> enumerable, bool derived = true)
        {
            var properties = enumerable.Select(item => typeof(T)
                    .GetPropertiesForTable()
                    .Concat(derived
                        ? item.GetType().GetPropertiesForTable()
                        : Enumerable.Empty<PropertyInfo>()
                    ).Distinct()
                );

            return new StringTable(
                properties.Transpose().Select(col => string.Join("/", col
                    .Distinct()
                    .Select(prop => prop.Name))
                ),
                properties
                    .Zip(enumerable, (props, obj) =>
                        new { Properties = props, Object = obj }
                    ).Select(item => item.Properties
                        .Select(prop => prop?.GetValue(item.Object))
                    )
            );
        }
    }
}
