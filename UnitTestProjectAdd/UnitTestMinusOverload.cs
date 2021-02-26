using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace UnitTestProjectAdd
{
    [TestClass]
    public class UnitTestMinusOverload
    {
        [TestMethod]
        public void MinusOverload_Item_CountChanges()
        {
            //arrange
            CustomMadeList<int> customMadeList1 = new CustomMadeList<int>();
            customMadeList1.Add(1);
            customMadeList1.Add(2);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            int expected = 1;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList3.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_Item_OnlySubtractsOne()
        {
            //arrange
            CustomMadeList<int> customMadeList1 = new CustomMadeList<int>();
            customMadeList1.Add(2);
            customMadeList1.Add(2);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            int expected = 1;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList3.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_Item_ListOneUnchanged()
        {
            //arrange
            CustomMadeList<int> customMadeList1 = new CustomMadeList<int>();
            customMadeList1.Add(1);
            customMadeList1.Add(2);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            int expected = 2;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_Item_CorrectCapacity()
        {
            //arrange
            CustomMadeList<int> customMadeList1 = new CustomMadeList<int>();
            customMadeList1.Add(1);
            customMadeList1.Add(2);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            int expected = 4;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList3.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_Item_WroksWithString()
        {
            //arrange
            CustomMadeList<string> customMadeList1 = new CustomMadeList<string>();
            customMadeList1.Add("1");
            customMadeList1.Add("2");
            CustomMadeList<string> customMadeList2 = new CustomMadeList<string>();
            customMadeList2.Add("2");
            int expected = 1;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList3.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_Item_ListOneIsSmaller()
        {
            //arrange
            CustomMadeList<int> customMadeList1 = new CustomMadeList<int>();
            customMadeList1.Add(1);
            customMadeList1.Add(2);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            customMadeList2.Add(3);
            customMadeList2.Add(2);
            customMadeList2.Add(4);
            int expected = 1;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList3.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_Item_ListOneWillBeZero()
        {
            //arrange
            CustomMadeList<int> customMadeList1 = new CustomMadeList<int>();
            customMadeList1.Add(1);
            customMadeList1.Add(2);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            customMadeList2.Add(1);
            customMadeList2.Add(2);
            customMadeList2.Add(4);
            int expected = 0;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList3.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_Item_ListTwoIsEmpty()
        {
            //arrange
            CustomMadeList<int> customMadeList1 = new CustomMadeList<int>();
            customMadeList1.Add(1);
            customMadeList1.Add(2);
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            int expected = 2;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList3.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_Item_ListOneIsEmpty()
        {
            //arrange
            CustomMadeList<int> customMadeList1 = new CustomMadeList<int>();
            CustomMadeList<int> customMadeList2 = new CustomMadeList<int>();
            customMadeList2.Add(2);
            customMadeList2.Add(3);
            customMadeList2.Add(2);
            customMadeList2.Add(4);
            int expected = 0;
            int actual;
            //act
            CustomMadeList<int> customMadeList3 = customMadeList1 - customMadeList2;
            actual = customMadeList3.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
