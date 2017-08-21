using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorUsingAString;
namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        CalcFromString myCalcFromString = new CalcFromString();

        [TestMethod]
        public void MultiplyTest()
        {
            string Input = "2*4";
            string Expected = "8";
            string Actual = myCalcFromString.RunCalc(Input);

            Assert.AreEqual(Expected, Actual);

        }

        [TestMethod]
        public void AddTest()
        {
            string Input = "2+4";
            string Expected = "6";
            string Actual = myCalcFromString.RunCalc(Input);

            Assert.AreEqual(Expected, Actual);

        }
    }
}
