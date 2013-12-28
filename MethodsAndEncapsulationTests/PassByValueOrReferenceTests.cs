using MethodsAndEncapsulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodsAndEncapsulationTests
{
    [TestClass]
    public class PassByValueOrReferenceTests
    {
        [TestMethod]
        public void PassingObjectsToMethodsShouldBeByReference()
        {
            Person person1 = new Person("John");
            
            resetValueOfMemberVariable(person1);

            Assert.AreEqual("Rodriguez", person1.Name);
        }

        private void resetValueOfMemberVariable(Person p1)
        {
            p1.Name = "Rodriguez";
        }

        [TestMethod]
        public void PassingPrimitivesToMethodsShouldBeByValue()
        {
            int num = 2;

            incrementInt(num);

            Assert.AreEqual(2, num);
        }

        private void incrementInt(int num)
        {
            num = num + 1;
        }
    }
}
