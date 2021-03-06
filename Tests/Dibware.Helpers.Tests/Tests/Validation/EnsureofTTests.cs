﻿using System;
using Dibware.Helpers.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dibware.Helpers.UnitTests.Tests.Validation
{
    [TestClass]
    public class EnsureofTTests
    {
        #region IsNotNull

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ArgumentIsNotNull_WithNullArgument_ThrowsNullReferenceException()
        {
            // Arrange

            // Action
            Ensure<string>.IsNotNull(null, "argument");

            // Assert
        }

        [TestMethod]
        public void ArgumentIsNotNull_WithOutNullArgument_ReturnsOriginalValue()
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