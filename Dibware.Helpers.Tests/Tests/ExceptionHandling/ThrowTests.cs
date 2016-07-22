//using Dibware.Helpers.ExceptionHandling;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace Dibware.Helpers.UnitTests.Tests.ExceptionHandling
//{
//    [TestClass]
//    public class ThrowTests
//    {
//        [TestMethod]
//        public void If_WhenConditionIsNotMet_ExceptionIsNotThrown()
//        {
//            // ARRANGE

//            // ACT
//            Throw<ArgumentOutOfRangeException>.If(false, "Exception Thrown");

//            // ASSERT
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void If_WhenConditionIsMetAndMessageSupplied_ExceptionIsThrown()
//        {
//            // ARRANGE

//            // ACT
//            Throw<InvalidOperationException>.If(true, "Exception Thrown");

//            // ASSERT
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void If_WhenConditionIsMetAndParameterAndMessageIsSupplied_ExceptionIsThrown()
//        {
//            // ARRANGE

//            // ACT
//            Throw<ArgumentOutOfRangeException>.If(true, "parameter1", "Exception Thrown");

//            // ASSERT
//        }

//        [TestMethod]
//        public void If_WhenConditionIsMet_ExceptionHasCorrectMessage()
//        {
//            // ARRANGE
//            string expectedMessage = "Exception Thrown";
//            string actual = "";

//            // ACT
//            try
//            {
//                Throw<InvalidOperationException>.If(true, expectedMessage);
//            }
//            catch (Exception ex)
//            {
//                actual = ex.Message;
//            }

//            // ASSERT
//            Assert.AreEqual(expectedMessage, actual);
//        }

//        [TestMethod]
//        public void If_WhenConditionIsMetAndParameterAndMessageSupplied_ExceptionHasCorrectMessage()
//        {
//            // ARRANGE
//            string expectedParameter = "Parameter1";
//            string expectedMessage = "Exception Thrown";
//            string actual = "";

//            // ACT
//            try
//            {
//                Throw<ArgumentNullException>.If(true, expectedMessage, expectedParameter);
//            }
//            catch (Exception ex)
//            {
//                actual = ex.Message;
//            }

//            // ASSERT
//            Assert.AreEqual(expectedMessage, actual);
//        }


//        [TestMethod]
//        public void If_WhenConditionIsMetAndOneParametersSupplied_ExceptionHasCorrectMessage()
//        {
//            // ARRANGE
//            string expectedMessage = "Exception Thrown";
//            var arguments = new {expectedMessage};
//            string actual = "";

//            // ACT
//            try
//            {
//                Throw<InvalidOperationException>.If(true, expectedMessage, arguments);
//            }
//            catch (Exception ex)
//            {
//                actual = ex.Message;
//            }

//            // ASSERT
//            Assert.AreEqual(expectedMessage, actual);
//        }


//        [TestMethod]
//        public void If_WhenConditionIsMetAndTwoParametersSupplied_ExceptionHasCorrectMessage()
//        {
//            // ARRANGE
//            string expectedParameter = "Parameter1";
//            string expectedMessage = "Exception Thrown";
//            string actual = "";

//            // ACT
//            try
//            {
//                Throw<ArgumentNullException>.If(true, expectedMessage, expectedParameter);
//            }
//            catch (Exception ex)
//            {
//                actual = ex.Message;
//            }

//            // ASSERT
//            Assert.AreEqual(expectedMessage, actual);
//        }



//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void If_WhenCallbackReturnsTrueAfterInvoke_ExceptionIsThrown()
//        {
//            // ARRANGE
//            Func<bool> callback = GetCallbackTrueResult;

//            // ACT
//            Throw<ArgumentOutOfRangeException>.If(callback, "Exception Thrown");

//            // ASSERT

//        }

//        [TestMethod]
//        public void If_WhenCallbackReturnsFalse_ExceptionIsNotThrown()
//        {
//            // ARRANGE
//            Func<bool> callback = GetCallbackFalseResult;

//            // ACT
//            Throw<ArgumentOutOfRangeException>.If(callback, "Exception Thrown");

//            // ASSERT
//        }

//        private bool GetCallbackFalseResult()
//        {
//            return false;
//        }

//        private bool GetCallbackTrueResult()
//        {
//            return true;
//        }
//    }
//}
