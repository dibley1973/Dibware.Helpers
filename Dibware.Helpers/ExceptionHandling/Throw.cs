using System;

namespace Dibware.Helpers.ExceptionHandling
{
    public static class Throw<TException> where TException : Exception
    {
        /// <summary>
        /// If the specified condition is met then throw a new instance of the 
        /// exception specified by the classes .
        /// </summary>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <param name="message">The message.</param>
        public static void If(bool condition, string message)
        {
            if (condition)
            {
                throw (TException)Activator.CreateInstance(typeof(TException), message);
            }
        }
    }
}