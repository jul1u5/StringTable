using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace StringTable.Utilities
{
    static class TableExtensions
    {
        public static int TablePropertyOrder(this PropertyInfo propInfo) => propInfo
            .GetCustomAttribute<TableColumnAttribute>(inherit: true)
            ?.Order ?? int.MaxValue;

        public static bool? TablePropertyIncluded(this PropertyInfo propInfo)
        {
            var attribute = propInfo.GetCustomAttribute<TableColumnAttribute>(inherit: true);

            return !attribute?.Exclude ?? attribute?.Include;
        }

        public static bool TableDefaultIncluded(this Type type) => !type
            .GetCustomAttribute<TableAttribute>()
            ?.ExcludeByDefault ?? true;

        public static IEnumerable<PropertyInfo> GetPropertiesForTable(this Type type) => type
            .GetProperties()
            .Where(prop => prop.TablePropertyIncluded() ?? type.TableDefaultIncluded())
            .OrderBy(prop => prop.TablePropertyOrder());
    }
}
