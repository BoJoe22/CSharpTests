using FunctionalCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalCSharpTests
{
    [TestClass]
    public class HigherOrderFunTests
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
        public void TestSum1()
        {
            var result = HigherOrderFun.sum(myList, x => x);

            Assert.AreEqual(55, result);
        }

        [TestMethod]
        public void TestSum2()
        {
            var result = HigherOrderFun.sum(myList, x => x * 2);

            Assert.AreEqual(110, result);
        }
    }
}
