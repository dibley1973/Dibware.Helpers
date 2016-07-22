//using System;

//namespace Dibware.Helpers.ExceptionHandling
//{
//    public static class Throw<TException> where TException : Exception
//    {
//        /// <summary>
//        /// If the specified condition is met then throw a new instance of the exception
//        /// specified by the class type parameter along with the specified message.
//        /// </summary>
//        /// <param name="condition">if set to <c>true</c> then the exception is thrown.</param>
//        /// <param name="args">
//        /// The arguments needed to construct the exception specified by the type param.
//        /// </param>
//        public static void If(bool condition, params object[] args)
//        {
//            if (condition)
//            {
//                throw (TException)Activator.CreateInstance(typeof(TException), args);
//            }
//        }

//        /// <summary>
//        /// If the specified condition is met then throw a new instance of the exception
//        /// specified by the class type parameter along with the specified message.
//        /// </summary>
//        /// <param name="condition">if set to <c>true</c> then the exception is thrown.</param>
//        /// <param name="message">The message.</param>
//        public static void If(bool condition, string message)
//        {
//            if (condition)
//            {
//                throw (TException)Activator.CreateInstance(typeof(TException), message);
//            }
//        }

//        /// <summary>
//        /// If the specified condition is met then throw a new instance of the exception
//        /// specified by the class type parameter along with the specified parameter and message.
//        /// </summary>
//        /// <param name="condition">if set to <c>true</c> then the exception is thrown.</param>
//        /// <param name="parameter"></param>
//        /// <param name="message">The message.</param>
//        public static void If(bool condition, string parameter, string message)
//        {
//            if (condition)
//            {
//                throw (TException)Activator.CreateInstance(typeof(TException), parameter, message);
//            }
//        }

//        /// <summary>
//        /// If the specified callback returns true then throw anew instance of the exception
//        /// specified by the class type parameter along with the specified message.
//        /// </summary>
//        /// <param name="callback">The callback.</param>
//        /// <param name="message">The message.</param>
//        public static void If(Func<bool> callback, string message)
//        {
//            if (callback.Invoke())
//            {
//                throw (TException)Activator.CreateInstance(typeof(TException), message);
//            }
//        }
//    }
//}