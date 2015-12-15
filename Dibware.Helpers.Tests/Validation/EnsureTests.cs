using Dibware.Helpers.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dibware.Helpers.Tests.Validation
{
    [TestClass]
    public class EnsureTests
    {
        #region ArgumentIsNotNullOrEmpty

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ArgumentIsNotNullOrEmpty_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Ensure.ArgumentIsNotNullOrEmpty(null, "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentIsNotNullOrEmpty_WithOutNullArgument_DoesNothing()
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
        public void Test_ArgumentIsNotNullOrWhiteSpace_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Ensure.ArgumentIsNotNullOrWhiteSpace(null, "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentIsNotNullOrWhiteSpace_WithOutNullArgument_ReturnsOriginalValue()
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