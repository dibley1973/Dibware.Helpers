using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace Dibware.Helpers.Validation
{
    public static partial class Guard
    {
        /// <summary>
        /// Checks if the specified arguments the is not null.
        /// If it is throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.IsNotNull(arg1, "arg1");</example>
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
    }
}
