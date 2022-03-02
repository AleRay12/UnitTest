using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Function;

namespace UnitTestFunction
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        public void IsfunTest1()
        {
            //arrange
            double c = -2;
            double b = 2;
            double a = 1;
            double x = 3;
            double expected = 21;

            //ast
            Systems s = new Systems();
            double actual = s.fun(a, b, c, x);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsfunTest2()
        {
            //arrange
            double c = 2;
            double b = 0;
            double a = 3;
            double x = 2;
            double expected = 1.25;

            //ast
            Systems s = new Systems();
            double actual = s.fun(a, b, c, x);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsfunTest3()
        {
            //arrange
            double c = 5;
            double b = 2;
            double a = 3;
            double x = 2;
            double expected = 0.3;

            //ast
            Systems s = new Systems();
            double actual = s.fun(a, b, c, x);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsfunTest4()
        {
            //arrange
            double c = 2;
            double b = 0;
            double a = 1;
            double x = 2;
            double expected = 0.3;

            //ast
            Systems s = new Systems();
            double actual = s.fun(a, b, c, x);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsfunTest5()
        {
            //arrange
            double c = -2;
            double b = 2;
            double a = 1;
            double x = 3;
            double expected = 21.3;

            //ast
            Systems s = new Systems();
            double actual = s.fun(a, b, c, x);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
