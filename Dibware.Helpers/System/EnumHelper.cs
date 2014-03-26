using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Dibware.Helpers.System
{
    public static partial class EnumHelper
    {
        /// <summary>
        /// Gets all combined items from an enum value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <example>
        /// Displays ValueA and ValueB.
        /// <code>
        /// EnumExample dummy = EnumExample.Combi;
        /// foreach (var item in EnumHelper.GetAllSelectedItems<EnumExample/>(dummy))
        /// {
        ///    Console.WriteLine(item);
        /// }
        /// </code>
        /// </example>
        public static IEnumerable<T> GetAllSelectedItems<T>(Enum value)
        {
            var valueAsInt = Convert.ToInt32(value, CultureInfo.InvariantCulture);

            return from object item
                    in Enum.GetValues(typeof(T))
                   let itemAsInt = Convert.ToInt32(item, CultureInfo.InvariantCulture)
                   where itemAsInt == (valueAsInt & itemAsInt)
                   select (T)item;

            //foreach (object item in Enum.GetValues(typeof(T)))
            //{
            //    int itemAsInt = Convert.ToInt32(item, CultureInfo.InvariantCulture);

            //    if (itemAsInt == (valueAsInt & itemAsInt))
            //    {
            //        yield return (T)item;
            //    }
            //}
        }

        public static String GetName<T>(Enum value)
        {
            return Enum.GetName(typeof(T), value);
        }
    }
}