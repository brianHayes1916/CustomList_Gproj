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
            int count = customMadeList.Count;
            int expectedResult = count + 1;
            int actualResult;
            //act
            customMadeList.Add(1);
            actualResult = customMadeList.Count;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void Add_Item_IndexSameAsCount()
        {
        }
    }
}
