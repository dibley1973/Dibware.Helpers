using System;
using System.Diagnostics;

namespace Dibware.Helpers.Validation
{
    /// <summary>
    /// encapsualtes logic to ensures arguments pass specific validation.
    /// </summary>
    public static class Ensure
    {
        /// <summary>
        /// Checks if the specified string is not null or empty.
        /// If it is throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.IsNotNull(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">The argument name.</param>
        /// <returns>The argument being checked if argument was not null or empty.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static string ArgumentIsNotNullOrEmpty(String value, String argumentName)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(argumentName);
            }
            return value;
        }

        /// <summary>
        /// Checks if the specified string is not null, empty or whitespace.
        /// If it is throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.ArgumentIsNotNullOrWhiteSpace(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">The argument name.</param>
        /// <returns>The argument being checked if argument was not null, empty or whitespace.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static string ArgumentIsNotNullOrWhiteSpace(String value, String argumentName)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(argumentName);
            }
            return value;
        }
    }
}
