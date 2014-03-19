using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionalCSharp;
using System.Collections.Generic;

namespace FunctionalCSharpTests
{
    [TestClass]
    public class FunctionalUtilitiesTests
    {
        List<int> myList;

        [TestInitialize]
        public void Setup()
        {
            myList = new List<int>();
            for (int i = 1; i <= 10; i++)
                myList.Add(i);
        }

        [TestMethod]
        public void TestMap1()
        {
            List<int> newList = new List<int>(FunctionalUtilities.Map(myList, x => x * 2));
            //var newList = FunctionalUtilities.Map(myList, x => x * 2);
            //List<int> anotherList = new List<int>();
            //foreach (var item in newList)
            //    anotherList.Add(item);

            Assert.AreEqual(10, myList.Count);
            Assert.AreEqual(2, newList[0]);
            Assert.AreEqual(4, newList[1]);
            Assert.AreEqual(6, newList[2]);
            Assert.AreEqual(8, newList[3]);
            Assert.AreEqual(10, newList[4]);
            Assert.AreEqual(20, newList[9]);
            //Assert.AreEqual(new List<int>() { 2, 4, 6, 8, 10 }, newList);
        }
    }
}
