using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace B3_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_n_Equals_0()
        {
            var expected = 1.0;

            var actual = Class1.Power(10, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_n_Greater_Than_0()
        {
            var expected = 10;

            var actual = Class1.Power(10, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_n_Less_Than_0()
        {
            var expected = 0.1;

            var actual = Class1.Power(10, -1);

            Assert.AreEqual(expected, actual);
        }
    }
}
