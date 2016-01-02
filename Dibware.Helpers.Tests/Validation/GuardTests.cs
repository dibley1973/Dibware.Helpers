using System;
using Dibware.Helpers.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dibware.Helpers.Tests.Validation
{
    [TestClass]
    public class GuardTests
    {
        #region IsNotNull

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
            var argument = new Object();

            // Action
            Guard.ArgumentIsNotNull(argument, "argument");

            // Assert
        }

        #endregion

        #region ArgumentIsNotNullOrEmpty

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ArgumentIsNotNullOrEmpty_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNotNullOrEmpty(null, "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentIsNotNullOrEmpty_WithOutNullArgument_DoesNothing()
        {
            // Arrange
            const String value = "Yabba-dabba-doo!";

            // Action
            Guard.ArgumentIsNotNullOrEmpty(value, "argument");

            // Assert
        }

        #endregion

        #region ArgumentIsNullOrWhiteSpace

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ArgumentIsNullOrWhiteSpace_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNullOrWhiteSpace(null, "argument");

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ArgumentIsNullOrWhiteSpace_WithemptyArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNullOrWhiteSpace("", "argument");

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ArgumentIsNullOrWhiteSpace_WithWhitespaceArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNullOrWhiteSpace("   ", "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentIsNullOrWhiteSpace_WithOutNullArgument_DoesNothing()
        {
            // Arrange
            const String value = "Yabba-dabba-doo!";

            // Action
            Guard.ArgumentIsNullOrWhiteSpace(value, "argument");

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

        #region InvalidOperation

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_InvalidOperation_WithTrueConditionAndMessage_ThrowsInvalidOperationException()
        {
            // Arrange

            // Action
            Guard.InvalidOperation(true, "Invalid Operation");

            // Assert
        }

        [TestMethod]
        public void Test_InvalidOperation_WithFalseConditionAndMessage_DoesNothing()
        {
            // Arrange

            // Action
            Guard.InvalidOperation(false, "Invalid Operation");

            // Assert
        }

        #endregion
    }
}