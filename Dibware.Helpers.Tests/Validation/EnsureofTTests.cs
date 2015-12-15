using Dibware.Helpers.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dibware.Helpers.Tests.Validation
{
    [TestClass]
    public class EnsureofTTests
    {
        #region ArgumentIsNotNull

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ArgumentIsNotNull_WithNullArgument_ThrowsArgumentNullException()
        {
            // Arrange

            // Action
            Ensure<string>.ArgumentIsNotNull(null, "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentIsNotNull_WithOutNullArgument_ReturnsOriginalValue()
        {
            // Arrange
            const string argument = "TestValue";

            // Action
            var actual = Ensure<string>.ArgumentIsNotNull(argument, "argument");

            // Assert
            Assert.AreEqual(argument, actual);
        }

        #endregion
    }
}