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
            customMadeList.Remove(1);
            actual = customMadeList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_RemovesCorrectItem()
        {
            //arange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            customMadeList.Add(2);
            customMadeList.Add(3);
            int expected = 3;
            int actual;
            //act
            customMadeList.Remove(2);
            actual = customMadeList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_CapacityDoesNotShrink()
        {
            //arange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            for(int i = 0; i <= 5; i++)
            {
                customMadeList.Add(1);
            }
            int expected = 8;
            int actual;
            //act
            customMadeList.Remove(1);
            actual = customMadeList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_RemovesFirstInstance()
        {
            //arange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            customMadeList.Add(1);
            customMadeList.Add(2);
            customMadeList.Add(1);
            int expected = 2;
            int actual;
            //act
            customMadeList.Remove(1);
            actual = customMadeList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
