using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dibware.Helpers.Validation
{
    [TestClass]
    public class GuardTests
    {
        #region ArgumentIsNotNull

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ArgumentIsNotNull_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNotNull(null, "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentIsNotNull_WithOutNullArgument_DoesNothing()
        {

            // Arrange
            Object argument = new Object();

            // Action
            Guard.ArgumentIsNotNull(argument, "argument");

            // Assert
        }

        #endregion

        #region ArgumentOutOfRange

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_ArgumentOutOfRange_WithTrueCondition_ThrowsArgumentOutOfRange()
        {
            // Arrange

            // Action
            Guard.ArgumentOutOfRange(true, "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentOutOfRange_WithFalseCondition_DoesNothing()
        {
            // Arrange

            // Action
            Guard.ArgumentOutOfRange(false, "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentOutOfRange_WithTrueConditionAndMessage_ThrowsArgumentOutOfRangeAndCorrectMessage()
        {
            // Arrange
            const String errorMessage = "Test Message";
            const String expectedMessage = errorMessage + "\r\nParameter name: argument";

            try
            {
                // Action
                Guard.ArgumentOutOfRange(true, "argument", errorMessage);

                // Assert
            }
            catch (Exception ex)
            {
                // Assert
                Assert.AreEqual(typeof(ArgumentOutOfRangeException), ex.GetType());
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }

        [TestMethod]
        public void Test_ArgumentOutOfRange_WithFalseConditionAndMessage_DoesNothing()
        {
            // Arrange
            const String errorMessage = "Test Message";

            // Action
            Guard.ArgumentOutOfRange(false, "argument", errorMessage);

            // Assert
        }

        #endregion
    }
}