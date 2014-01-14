using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace MethodsAndEncapsulationTests
{
    [TestClass]
    public class ArrayReferenceTests
    {
        /// <summary>
        /// Be aware of object references in collections.  Potential side effects...
        /// </summary>
        [TestMethod]
        public void ReferenceObjectsInArrays()
        {
            StringBuilder one = new StringBuilder("one");
            StringBuilder two = new StringBuilder("two");

            StringBuilder[] arr1 = { one, two };
            StringBuilder[] arr2 = new StringBuilder[2];
            arr1.CopyTo(arr2, 0);

            one.Replace("one", "not one");

            Assert.AreEqual("not one", arr1[0].ToString());
            Assert.AreEqual("not one", arr2[0].ToString());
        }
    }
}
