using System;
using System.Diagnostics;

namespace Dibware.Helpers.Validation
{
    /// <summary>
    /// encapsualtes logic to ensures arguments pass specific validation.
    /// </summary>
    public static class Ensure<T>
        where T : class
    {
        /// <summary>
        /// Checks if the specified arguments the is not null.
        /// If it is throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.ArgumentIsNotNull(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">The argument name.</param>
        /// <returns>The argument being checked if argument was not null.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static T ArgumentIsNotNull(T value, String argumentName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(argumentName);
            }
            return value;
        }
    }
}