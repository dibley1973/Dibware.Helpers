using System;
using System.Diagnostics;
using JetBrains.Annotations;

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
        public static void ArgumentIsNotNull(object value, [InvokerParameterName] string argumentName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Equalses the default type of the of.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="ArgumentException">The identity cannot be the type's default value;identity</exception>
        [DebuggerHidden]    //Does not appear at all in the call stack
        public static void EqualsDefaultOfType<T>(T value, [InvokerParameterName] string argumentName)
        {
            if (Equals(value, default(T)))
            {
                throw new ArgumentException("The value cannot be the type's default value", "value");
            }
        }
    }
}
