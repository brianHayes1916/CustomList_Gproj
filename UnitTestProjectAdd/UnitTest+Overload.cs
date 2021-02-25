using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace UnitTestProjectAdd
{
    [TestClass]
    public class UnitTest_Overload
    {
        [TestMethod]
        public void PlusOverload_Item_CorrectCount()
        {
            //arrange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            customMadeList.Add(1);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            int expected = 2;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList2 + customMadeList;
            actual = customMadeList3.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_Item_CorrectCapacity()
        {
            //arrange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            customMadeList.Add(1);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            int expected = 4;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList2 + customMadeList;
            actual = customMadeList3.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_Item_InCorrectOrder()
        {
            //arrange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            customMadeList.Add(1);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            int expected = 1;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList2 + customMadeList;
            actual = customMadeList3[1];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_Item_ListOneUnchanged()
        {
            //arrange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            customMadeList.Add(1);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            int expected = 1;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList2 + customMadeList;
            actual = customMadeList[0];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_Item_
    }
}
