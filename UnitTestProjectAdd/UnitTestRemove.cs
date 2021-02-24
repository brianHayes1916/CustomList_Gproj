using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace UnitTestProjectAdd
{
    [TestClass]
    public class UnitTestRemove
    {
        [TestMethod]
        public void Remove_Item_CountDecreaseByOne()
        {
            //Arange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            customMadeList.Add(1);
            int expected = 0;
            int actual;
            //Act
            actual = customMadeList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_RemovesCorrectIndex()
        {

        }
    }
}
