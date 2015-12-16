using System;
using System.Diagnostics;

namespace Dibware.Helpers.Validation
{
    /// <summary>
    /// Encapsualtes logic to ensures arguments pass specific validation.
    /// </summary>
    public static class Ensure<T>
        where T : class
    {
        /// <summary>
        /// Checks if the specified item is not null.
        /// If it is throws a System.NullReferenceException
        /// </summary>
        /// <example>Ensure.IsNotNull(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="itemName">The item name.</param>
        /// <returns>The item being checked if argument was not null.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static T IsNotNull(T value, String itemName)
        {
            if (value == null)
            {
                throw new NullReferenceException(itemName);
            }
            return value;
        }
    }
}