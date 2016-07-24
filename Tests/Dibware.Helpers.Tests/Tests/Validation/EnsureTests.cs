using System;
using Dibware.Helpers.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dibware.Helpers.UnitTests.Tests.Validation
{
    [TestClass]
    public class EnsureTests
    {
        #region ArgumentIsNotNullOrEmpty

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentIsNotNullOrEmpty_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Ensure.ArgumentIsNotNullOrEmpty(null, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentIsNotNullOrEmpty_WithOutNullArgument_DoesNothing()
        {
            // Arrange
            const String argument = "Yabba-dabba-doo!";

            // Action
            var actual = Ensure.ArgumentIsNotNullOrEmpty(argument, "argument");

            // Assert
            Assert.AreEqual(argument, actual);
        }

        #endregion

        #region ArgumentIsNotNullOrWhitespace

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentIsNotNullOrWhiteSpace_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Ensure.ArgumentIsNotNullOrWhiteSpace(null, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentIsNotNullOrWhiteSpace_WithOutNullArgument_ReturnsOriginalValue()
        {
            // Arrange
            const String argument = "Yabba-dabba-doo!";

            // Action
            var actual = Ensure.ArgumentIsNotNullOrWhiteSpace(argument, "argument");

            // Assert
            Assert.AreEqual(argument, actual);
        }

        #endregion
    }
}