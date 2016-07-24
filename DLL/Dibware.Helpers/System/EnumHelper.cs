using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Dibware.Helpers.System
{
    public static class EnumHelper
    {
        /// <summary>
        /// Gets all combined items from an enum value where the enum is expressed as bitwise flags.
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

            var result = 
                from object item
                in Enum.GetValues(typeof(T))
                let itemAsInt = Convert.ToInt32(item, CultureInfo.InvariantCulture)
                where itemAsInt == (valueAsInt & itemAsInt)
                select (T)item;

            return result;
        }

        /// <summary>
        /// Retrieves the name of the constant in the specified enumeration that has the specified value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <example>
        /// var result = EnumHelper.GetName<Fruit>(myFruit);
        /// </example>
        public static String GetName<T>(Enum value)
        {
            return Enum.GetName(typeof(T), value);
        }

        ///// <summary>
        ///// Gets the enum.
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="value">The value.</param>
        ///// <returns></returns>
        ///// <exception cref="System.ArgumentOutOfRangeException">value</exception>
        //public static T GetEnum<T>(Int32 value)
        //{
        //    if (typeof(T).IsEnumDefined(value))
        //    {
        //        return (T)value;
        //    }
        //    var enumTypeName =typeof(T).ToString();
        //    var messageFormat = "{0} is not a valid value for enum of type {1} ";
        //    var message = String.Format(messageFormat, value, enumTypeName);
        //    throw new ArgumentOutOfRangeException("value", value, message);
        //}
    }
}