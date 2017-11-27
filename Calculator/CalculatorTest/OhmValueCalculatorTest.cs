using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class OhmValueCalculatorTest
    {

        IOhmValueCalculator calculator = new OhmValueCalcuator(new ColorCodes());

        [TestMethod]
        public void CalculateOhmValueTest()
        {
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "RD"), 4700);
        }

        [TestMethod]
        public void CalculateOhmValueRangeTest()
        {
            OhmRange range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "GD");
            Assert.AreEqual(range.MinValue, 4465);
            Assert.AreEqual(range.MaxValue, 4935);
        }

        [TestMethod]
        public void CalculateOhmValueExceptionTest()
        {
            Assert.ThrowsException<Exception>(() => calculator.CalculateOhmValue("", "", ""));
            Assert.ThrowsException<Exception>(() => calculator.CalculateOhmValue("", "VT", "RD"));
            Assert.ThrowsException<Exception>(() => calculator.CalculateOhmValue("YE", "", "RD"));
            Assert.ThrowsException<Exception>(() => calculator.CalculateOhmValue("YE", "VT", ""));
        }

        [TestMethod]
        public void CalculateOhmValueRangeExceptionTest()
        {
            Assert.ThrowsException<Exception>(() => calculator.CalculateOhmValueRange("","","",""));
            Assert.ThrowsException<Exception>(() => calculator.CalculateOhmValueRange("", "VT", "RD", ""));
            Assert.ThrowsException<Exception>(() => calculator.CalculateOhmValueRange("YE", "", "RD", ""));
            Assert.ThrowsException<Exception>(() => calculator.CalculateOhmValueRange("YE", "VT", "", ""));
        }

        [TestMethod]
        public void FirstSignificantValueTest()
        {
            Assert.AreEqual(calculator.CalculateOhmValue("BK", "VT", "RD"), 0700);
            Assert.AreEqual(calculator.CalculateOhmValue("BN", "VT", "RD"), 1700);
            Assert.AreEqual(calculator.CalculateOhmValue("RD", "VT", "RD"), 2700);
            Assert.AreEqual(calculator.CalculateOhmValue("OG", "VT", "RD"), 3700);

            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "RD"), 4700);

            Assert.AreEqual(calculator.CalculateOhmValue("GN", "VT", "RD"), 5700);
            Assert.AreEqual(calculator.CalculateOhmValue("BU", "VT", "RD"), 6700);
            Assert.AreEqual(calculator.CalculateOhmValue("VT", "VT", "RD"), 7700);
            Assert.AreEqual(calculator.CalculateOhmValue("GY", "VT", "RD"), 8700);
            Assert.AreEqual(calculator.CalculateOhmValue("WH", "VT", "RD"), 9700);

        }

        [TestMethod]
        public void SecondSignificantValueTest()
        {
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "BK", "RD"), 4000);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "BN", "RD"), 4100);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "RD", "RD"), 4200);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "OG", "RD"), 4300);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "YE", "RD"), 4400);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "GN", "RD"), 4500);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "BU", "RD"), 4600);

            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "RD"), 4700);

            Assert.AreEqual(calculator.CalculateOhmValue("YE", "GY", "RD"), 4800);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "WH", "RD"), 4900);
        }

        [TestMethod]
        public void MultiplierTest()
        {
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "PK"), 0.047);
            //Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "SR"), 0.47);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "GD"), 4.7);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "BK"), 47);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "BN"), 470);

            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "RD"), 4700);

            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "OG"), 47000);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "YE"), 470000);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "GN"), 4700000);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "BU"), 47000000);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "VT"), 470000000);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "GY"), 4700000000);
            Assert.AreEqual(calculator.CalculateOhmValue("YE", "VT", "WH"), 47000000000);

        }

        [TestMethod]
        public void ToleranceTest()
        {

            OhmRange range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "SR");
            Assert.AreEqual(range.MinValue, 4230);
            Assert.AreEqual(range.MaxValue, 5170);

            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "GD");
            Assert.AreEqual(range.MinValue, 4465);
            Assert.AreEqual(range.MaxValue, 4935);

            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "BK");
            Assert.AreEqual(range.MinValue, 4700);
            Assert.AreEqual(range.MaxValue, 4700);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "BN");
            Assert.AreEqual(range.MinValue, 4653);
            Assert.AreEqual(range.MaxValue, 4747);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "RD");
            Assert.AreEqual(range.MinValue, 4606);
            Assert.AreEqual(range.MaxValue, 4794);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "OG");
            Assert.AreEqual(range.MinValue, 4700);
            Assert.AreEqual(range.MaxValue, 4700);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "YE");
            Assert.AreEqual(range.MinValue, 4465);
            Assert.AreEqual(range.MaxValue, 4935);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "GN");
            Assert.AreEqual(range.MinValue, 4676.5);
            Assert.AreEqual(range.MaxValue, 4723.5);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "BU");
            Assert.AreEqual(range.MinValue, 4688.25);
            Assert.AreEqual(range.MaxValue, 4711.75);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "VT");
            Assert.AreEqual(range.MinValue, 4695.3);
            Assert.AreEqual(range.MaxValue, 4704.7);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "GY");
            Assert.AreEqual(range.MinValue, 4697.65);
            Assert.AreEqual(range.MaxValue, 4702.35);
            range = calculator.CalculateOhmValueRange("YE", "VT", "RD", "WH");
            Assert.AreEqual(range.MinValue, 4700);
            Assert.AreEqual(range.MaxValue, 4700);

        }

    }
}
