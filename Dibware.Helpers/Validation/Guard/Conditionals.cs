using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace Dibware.Helpers.Validation
{
    public static partial class Guard
    {
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
