using JetBrains.Annotations;
using System;
using System.Text.RegularExpressions;

// ReSharper disable once CheckNamespace
namespace Dibware.Helpers.Validation
{
    /// <summary>
    /// Encapsulates guard clause logic
    /// </summary>
    public static partial class Guard
    {
        /// <summary>
        /// Checks if the specified string is not null or empty.
        /// If it is throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.IsNotNull(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">The argument name.</param>
        /// <exception cref="ArgumentNullException"></exception>
        //[DebuggerHidden]    //Does not appear at all in the call stack
        [ContractAnnotation("value: null => halt")]
        public static void ArgumentIsNotNullOrEmpty(string value, [InvokerParameterName] string argumentName)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Checks if the specified string is not null, empty, or white space.
        /// If it is throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.IsNotNull(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">The argument name.</param>
        /// <exception cref="ArgumentNullException"></exception>
        //[DebuggerHidden]    //Does not appear at all in the call stack
        [ContractAnnotation("value: null => halt")]
        public static void ArgumentIsNullOrWhiteSpace(string value, [InvokerParameterName] string argumentName)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// Checks if the specified string only has alphabetical or numeric charaters.
        /// If it does not, then throws a System.ArgumentNullException
        /// </summary>
        /// <example>Guard.ArgumentIsAlphaNumeric(arg1, "arg1");</example>
        /// <param name="value">The value.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        //[DebuggerHidden]    //Does not appear at all in the call stack
        public static void ArgumentIsAlphaNumeric(string value, [InvokerParameterName] string argumentName)
        {
            const string pattern = @"^[a-zA-Z0-9]*$";
            ArgumentConformsToRegex(value, pattern, argumentName);
        }

        /// <summary>
        /// Checks if the specified string only conforms to the specified regular expression
        /// If it does not, then throws a System.ArgumentNullException
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="regularExpressionPattern">The regular expression pattern.</param>
        /// <param name="argumentName">Name of the argument.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <example>Guard.ArgumentIsAlphaNumeric(arg1, "arg1");</example>
        //[DebuggerHidden]    //Does not appear at all in the call stack
        public static void ArgumentConformsToRegex(string value, string regularExpressionPattern, [InvokerParameterName] string argumentName)
        {
            Regex expression = new Regex(regularExpressionPattern);
            var conforms = expression.IsMatch(value);
            if (!conforms)
            {
                throw new ArgumentOutOfRangeException(argumentName);
            }
        }
    }
}
