using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace UnitTestProjectAdd
{
    [TestClass]
    public class UnitTestToString
    {
        [TestMethod]
        public void ToString_Item_AllItemsAreAString()
        {
            //arrange
            CustomMadeList<int> customMadeList = new CustomMadeList<int>();
            customMadeList.Add(1);
            string expected = "1";
            string actual;
            //act
            actual = customMadeList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }[TestMethod]
        public void ToString_Item_StringToString()
        {
            //arrange
            CustomMadeList<string> customMadeList = new CustomMadeList<string>();
            customMadeList.Add("1");
            customMadeList.Add("2");
            string expected = "1 2 ";
            string actual;
            //act
            actual = customMadeList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
