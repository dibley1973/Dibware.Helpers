using Dibware.Helpers.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dibware.Helpers.Tests.Validation
{
    [TestClass]
    public class EnsureofTTests
    {
        #region IsNotNull

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_ArgumentIsNotNull_WithNullArgument_ThrowsNullReferenceException()
        {
            // Arrange

            // Action
            Ensure<string>.IsNotNull(null, "argument");

            // Assert
        }

        [TestMethod]
        public void Test_ArgumentIsNotNull_WithOutNullArgument_ReturnsOriginalValue()
        {
            // Arrange
            const string argument = "TestValue";

            // Action
            var actual = Ensure<string>.IsNotNull(argument, "argument");

            // Assert
            Assert.AreEqual(argument, actual);
        }

        #endregion
    }
}