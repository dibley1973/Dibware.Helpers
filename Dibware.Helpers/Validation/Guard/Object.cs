using JetBrains.Annotations;
using System;

// ReSharper disable once CheckNamespace
namespace Dibware.Helpers.Validation
{
    /// <summary>
    /// Encapsulates guard clause logic
    /// </summary>
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
        //[DebuggerHidden]    //Does not appear at all in the call stack
        [ContractAnnotation("value: null => halt")]
        public static void ArgumentIsNotNull(object value, [InvokerParameterName] string argumentName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Checks if the specified argument value has the default value for the type.
        /// If it has then a System.ArgumentNullException is thrown.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="ArgumentException">The identity cannot be the type's default value;identity</exception>
        //[DebuggerHidden]    //Does not appear at all in the call stack
        public static void NotEqualsDefaultOfType<T>(T value, [InvokerParameterName] string argumentName)
        {
            if (Equals(value, default(T)))
            {
                throw new ArgumentException("The value cannot be the type's default value", "value");
            }
        }
    }
}