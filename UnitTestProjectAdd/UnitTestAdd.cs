using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace UnitTestProjectAdd
{
    [TestClass]
    public class UnitTestAdd
        // Check the count of the list
        // Check the index of the item
        // Check if the item exists
    {
        [TestMethod]
        public void Add_Item_CountIncreaseByOne()
        {
            //arange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            int expectedResult = 1;
            int actualResult;
            //act
            customMadeList.Add(1);
            actualResult = customMadeList.Count;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Add_Item_CapacityOfFour()
        {
            //arange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            int expectedResult = 4;
            int actualResult;
            //act
            customMadeList.Add(1);
            actualResult = customMadeList.Capacity;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_Item_CapasityGrows()
        {
            //arange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            int expacted = 8;
            int actual;
            //act
            customMadeList.Add(1);
            customMadeList.Add(1);
            customMadeList.Add(1);
            customMadeList.Add(1);
            customMadeList.Add(1);
            actual = customMadeList.Capacity;
            //assert
            Assert.AreEqual(expacted, actual);
        }

        //[TestMethod]
        //public void Add_Item_ItemExists()
        //{
        //    CustomMadeList<int> customMadeList = new CustomMadeList<int>();
        //    bool expected = true;
        //    bool actual = false;
        //    //act
        //    customMadeList.Add(1);
        //    foreach(int num in customMadeList)
        //    {
        //        if(num == 1)
        //        {
        //            actual = true;
        //            break;
        //        }
        //    }
        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Add_Item_CorrectIndex()
        //{
        //    CustomMadeList<int> customMadeList = new CustomMadeList<int>();
        //    int expected = 2;
        //    int actual;
        //    // act
        //    customMadeList.Add(0);
        //    customMadeList.Add(2);
        //    actual = customMadeList[1];
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
