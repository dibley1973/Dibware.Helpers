using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Dibware.Helpers.System
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
        public void Test_GetAllSelectedItems_ReturnsSelectedItems()
        {
            // Arrange 
            var myFruits = Fruit.Apple | Fruit.Orange;
            var selectedFruitNames = new List<String>();

            // Act

            foreach (var item in EnumHelper.GetAllSelectedItems<Fruit>(myFruits))
            {
                selectedFruitNames.Add(item.ToString());
            }

            // Assert
            Assert.IsTrue(selectedFruitNames.Contains("Apple"));
            Assert.IsTrue(selectedFruitNames.Contains("Orange"));
        }

        [TestMethod]
        public void Test_GetName_ReturnsCorrectName()
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