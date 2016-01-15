using Dibware.Helpers.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Dibware.Helpers.Tests.System
{
    [TestClass]
    public class EnumHelperTests
    {
        #region Declarations

        [Flags]
        private enum Fruit
        {
            Apple,
            Banana,
            Orange,
            Pear,
            Plum
        }

        #endregion

        #region Tests

        [TestMethod]
        public void GetAllSelectedItems_ReturnsSelectedItems()
        {
            // Arrange 
            const Fruit myFruits = Fruit.Apple | Fruit.Orange;
            const Int32 expectedCount = 2;

            // Act
            var selectedFruitNames =
                EnumHelper.GetAllSelectedItems<Fruit>(myFruits)
                    .Select(item => item.ToString())
                    .ToList();

            // Assert
            Assert.AreEqual(expectedCount, selectedFruitNames.Count);
            Assert.IsTrue(selectedFruitNames.Contains("Apple"));
            Assert.IsTrue(selectedFruitNames.Contains("Orange"));
        }

        [TestMethod]
        public void GetName_ReturnsCorrectName()
        {
            // Arrange 
            const Fruit myFruit = Fruit.Pear;

            // Act
            var result = EnumHelper.GetName<Fruit>(myFruit);

            // Assert
            Assert.AreEqual("Pear", result);
        }

        #endregion
    }
}