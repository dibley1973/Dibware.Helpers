using System;
using System.Diagnostics;

namespace Dibware.Helpers.Validation
{
    /// <summary>
    /// Encapsulates guard-clause logic to allow a neat and tidy single line call
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Checks if the specified arguments the is not null.
        /// If it is throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.ArgumentIsNotNull(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">The argument name.</param>
        /// <exception cref="ArgumentNullException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static void ArgumentIsNotNull(object value, String argumentName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Checks if the specified string is not null or empty.
        /// If it is throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.ArgumentIsNotNull(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">The argument name.</param>
        /// <exception cref="ArgumentNullException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static void ArgumentIsNotNullOrEmpty(String value, String argumentName)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Checks if the specified condition is true. If it is 
        /// a System.ArgumentOutOfRangeException is thrown with the 
        /// argument name
        /// </summary>
        /// <example>
        /// Guard.ArgumentOutOfRange((collection.Count == 1), "arg1");
        /// </example>
        /// <param name="condition">if set to <c>true</c> the ArgumentOutOfRangeException is thrown.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static void ArgumentOutOfRange(Boolean condition, String argumentName)
        {
            if (condition)
            {
                throw new ArgumentOutOfRangeException(argumentName);
            }
        }

        /// <summary>
        /// Checks if the specified condition is true. If it is 
        /// a System.ArgumentOutOfRangeException is thrown with the 
        /// argument name
        /// </summary>
        /// <example>
        /// Guard.ArgumentOutOfRange((collection.Count > 0), "arg1", "collection must have items");
        /// </example>
        /// <param name="condition">if set to <c>true</c> the ArgumentOutOfRangeException is thrown.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static void ArgumentOutOfRange(Boolean condition,
            String argumentName, String message)
        {
            if (condition)
            {
                throw new ArgumentOutOfRangeException(argumentName, message);
            }
        }

        /// <summary>
        /// Invalids the operation.
        /// </summary>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <param name="message">The message.</param>
        /// <exception cref="InvalidOperationException"></exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static void InvalidOperation(Boolean condition, String message)
        {
            if (condition)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}