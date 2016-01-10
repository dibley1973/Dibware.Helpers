﻿using Dibware.Helpers.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dibware.Helpers.Tests.Validation
{
    [TestClass]
    public class GuardTests
    {
        #region IsNotNull

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentIsNotNull_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNotNull(null, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentIsNotNull_WithOutNullArgument_DoesNothing()
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
        public void ArgumentIsNotNullOrEmpty_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNotNullOrEmpty(null, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentIsNotNullOrEmpty_WithOutNullArgument_DoesNothing()
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
        public void ArgumentIsNullOrWhiteSpace_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNullOrWhiteSpace(null, "argument");

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentIsNullOrWhiteSpace_WithemptyArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNullOrWhiteSpace("", "argument");

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentIsNullOrWhiteSpace_WithWhitespaceArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Guard.ArgumentIsNullOrWhiteSpace("   ", "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentIsNullOrWhiteSpace_WithOutNullArgument_DoesNothing()
        {
            // Arrange
            const String value = "Yabba-dabba-doo!";

            // Action
            Guard.ArgumentIsNullOrWhiteSpace(value, "argument");

            // Assert
        }

        #endregion

        #region ArgumentIsAlphaNumeric

        [TestMethod]
        public void ArgumentIsAlphaNumeric_WithAlphabeticalCharacters_DoesNothing()
        {
            // Arrange
            const String value = "Hello";

            // Action
            Guard.ArgumentIsAlphaNumeric(value, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentIsAlphaNumeric_WithNumericCharacters_DoesNothing()
        {
            // Arrange
            const String value = "123";

            // Action
            Guard.ArgumentIsAlphaNumeric(value, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentIsAlphaNumeric_WithAlphaNumericCharacters_DoesNothing()
        {
            // Arrange
            const String value = "Hello123";

            // Action
            Guard.ArgumentIsAlphaNumeric(value, "argument");

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentIsAlphaNumeric_WithNonAlphaNumericCharachter_ThrowsException()
        {
            // Arrange
            const String value = " ";

            // Action
            Guard.ArgumentIsAlphaNumeric(value, "argument");

            // Assert
        }

        #endregion

        #region ArgumentOutOfRange

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRange_WithTrueCondition_ThrowsArgumentOutOfRange()
        {
            // Arrange

            // Action
            Guard.ArgumentOutOfRange(true, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentOutOfRange_WithFalseCondition_DoesNothing()
        {
            // Arrange

            // Action
            Guard.ArgumentOutOfRange(false, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentOutOfRange_WithTrueConditionAndMessage_ThrowsArgumentOutOfRangeAndCorrectMessage()
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
        public void ArgumentOutOfRange_WithFalseConditionAndMessage_DoesNothing()
        {
            // Arrange
            const String errorMessage = "Test Message";

            // Action
            Guard.ArgumentOutOfRange(false, "argument", errorMessage);

            // Assert
        }

        #endregion

        #region ArgumentConformsToRegex

        [TestMethod]
        public void ArgumentConformsToRegex_WhenMatchesPattern_DoesNothing()
        {
            // Arrange
            const String value = "Hello 123";
            const string pattern = @"^[a-zA-Z0-9\s]*$";

            // Action
            Guard.ArgumentConformsToRegex(value, pattern, "argument");

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentConformsToRegex_WithDoesNotMatchPattern_ThrowsException()
        {
            // Arrange
            const String value = "Hello, 123";
            const string pattern = @"^[a-zA-Z0-9\s]*$";

            // Action
            Guard.ArgumentConformsToRegex(value, pattern, "argument");

            // Assert
        }


        #endregion

        #region InvalidOperation

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidOperation_WithTrueConditionAndMessage_ThrowsInvalidOperationException()
        {
            // Arrange

            // Action
            Guard.InvalidOperation(true, "Invalid Operation");

            // Assert
        }

        [TestMethod]
        public void InvalidOperation_WithFalseConditionAndMessage_DoesNothing()
        {
            // Arrange

            // Action
            Guard.InvalidOperation(false, "Invalid Operation");

            // Assert
        }

        #endregion
    }
}