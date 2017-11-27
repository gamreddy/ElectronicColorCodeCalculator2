using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class ColorCodesTest
    {
        ColorCodes colorCodes = new ColorCodes();

        [TestMethod]
        public void getColorCodesTest()
        {
            Assert.IsNotNull(colorCodes.getColorCodes());
            Assert.IsTrue(colorCodes.getColorCodes().Count > 0);
        }

        //[TestMethod]
        //public void NoneTest()
        //{
        //    Assert.AreEqual(colorCodes.getValue(""), -1);
        //    Assert.AreEqual(colorCodes.getMultiplier(""), 1);
        //    Assert.AreEqual(colorCodes.getTolerance(""), 0.2);
        //}

        [TestMethod]
        public void PinkTest()
        {
            Assert.AreEqual(colorCodes.getValue("PK"), -1);
            Assert.AreEqual(colorCodes.getMultiplier("PK"), 0.001);
            Assert.AreEqual(colorCodes.getTolerance("PK"), 0);
        }

        [TestMethod]
        public void SilverTest()
        {
            Assert.AreEqual(colorCodes.getValue("SR"), -1);
            Assert.AreEqual(colorCodes.getMultiplier("SR"), 0.01);
            Assert.AreEqual(colorCodes.getTolerance("SR"), 0.1);
        }

        [TestMethod]
        public void GoldTest()
        {
            Assert.AreEqual(colorCodes.getValue("GD"), -1);
            Assert.AreEqual(colorCodes.getMultiplier("GD"), 0.1);
            Assert.AreEqual(colorCodes.getTolerance("GD"), 0.05);
        }

        [TestMethod]
        public void BlackTest()
        {
            Assert.AreEqual(colorCodes.getValue("BK"), 0);
            Assert.AreEqual(colorCodes.getMultiplier("BK"), 1);
            Assert.AreEqual(colorCodes.getTolerance("BK"), 0);
        }

        [TestMethod]
        public void BrownTest()
        {
            Assert.AreEqual(colorCodes.getValue("BN"), 1);
            Assert.AreEqual(colorCodes.getMultiplier("BN"), 10);
            Assert.AreEqual(colorCodes.getTolerance("BN"), 0.01);
        }

        [TestMethod]
        public void RedTest()
        {
            Assert.AreEqual(colorCodes.getValue("RD"), 2);
            Assert.AreEqual(colorCodes.getMultiplier("RD"), 100);
            Assert.AreEqual(colorCodes.getTolerance("RD"), 0.02);
        }

        [TestMethod]
        public void OrangeTest()
        {
            Assert.AreEqual(colorCodes.getValue("OG"), 3);
            Assert.AreEqual(colorCodes.getMultiplier("OG"), 1000);
            Assert.AreEqual(colorCodes.getTolerance("OG"), 0);
        }

        [TestMethod]
        public void YellowTest()
        {
            Assert.AreEqual(colorCodes.getValue("YE"), 4);
            Assert.AreEqual(colorCodes.getMultiplier("YE"), 10000);
            Assert.AreEqual(colorCodes.getTolerance("YE"), 0.05);
        }

        [TestMethod]
        public void GreenTest()
        {
            Assert.AreEqual(colorCodes.getValue("GN"), 5);
            Assert.AreEqual(colorCodes.getMultiplier("GN"), 100000);
            Assert.AreEqual(colorCodes.getTolerance("GN"), 0.005);
        }

        [TestMethod]
        public void BlueTest()
        {
            Assert.AreEqual(colorCodes.getValue("BU"), 6);
            Assert.AreEqual(colorCodes.getMultiplier("BU"), 1000000);
            Assert.AreEqual(colorCodes.getTolerance("BU"), 0.0025);
        }

        [TestMethod]
        public void VioletTest()
        {
            Assert.AreEqual(colorCodes.getValue("VT"), 7);
            Assert.AreEqual(colorCodes.getMultiplier("VT"), 10000000);
            Assert.AreEqual(colorCodes.getTolerance("VT"), 0.001);
        }

        [TestMethod]
        public void GrayTest()
        {
            Assert.AreEqual(colorCodes.getValue("GY"), 8);
            Assert.AreEqual(colorCodes.getMultiplier("GY"), 100000000);
            Assert.AreEqual(colorCodes.getTolerance("GY"), 0.0005);
        }

        [TestMethod]
        public void WhiteTest()
        {
            Assert.AreEqual(colorCodes.getValue("WH"), 9);
            Assert.AreEqual(colorCodes.getMultiplier("WH"), 1000000000);
            Assert.AreEqual(colorCodes.getTolerance("WH"), 0);
        }

    }
}
