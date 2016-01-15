using System;
using Dibware.Helpers.ExceptionHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dibware.Helpers.Tests.Tests.ExceptionHandling
{
    [TestClass]
    public class ThrowTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void If_WhenConditionIsMet_ExceptionIsThrown()
        {
            // ARRANGE

            // ACT
            Throw<ArgumentOutOfRangeException>.If(true, "Validation Failed");

            // ASSERT
        }

        [TestMethod]
        public void If_WhenConditionIsNotMet_ExceptionIsNotThrown()
        {
            // ARRANGE

            // ACT
            Throw<ArgumentOutOfRangeException>.If(false, "Validation Passed");

            // ASSERT
        }
    }
}
