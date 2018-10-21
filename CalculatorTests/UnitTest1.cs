using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project4;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestZeroYear15()
        {
            double mort = CalcMortgage.ComputeMonthlyPayment(0, 15, .25);
            Assert.AreEqual(0, mort);

        }
        [TestMethod]
        public void TestZeroYear30()
        {
            double mort = CalcMortgage.ComputeMonthlyPayment(0, 30, 1.25);
            Assert.AreEqual(0, mort);

        }
        [TestMethod]
        public void TestZeroYearOther()
        {
            double mort = CalcMortgage.ComputeMonthlyPayment(0, 45, 2.25);
            Assert.AreEqual(0, mort);

        }
        [TestMethod]
        public void TestThousandYearOther()
        {
            double mort = CalcMortgage.ComputeMonthlyPayment(1000, 15, 1.25);
            double f = (double)mort;
            Assert.AreNotEqual(6.10, mort);

        }
        [TestMethod]
        public void TestThousandYearOtherExact()
        {
            double mort = CalcMortgage.ComputeMonthlyPayment(1000, 15, 1.25);
            mort = Math.Round(mort,2);
            Assert.AreEqual(6.10, mort);
        }
    }
}
