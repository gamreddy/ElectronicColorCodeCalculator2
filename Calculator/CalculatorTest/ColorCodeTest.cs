using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class ColorCodeTest
    {
        [TestMethod]
        public void YellowColorTest()
        {
            ColorCode colorCode = new ColorCode("Yellow", "YE", 4, 10000, 0.05);
            Assert.AreEqual(colorCode.Code, "YE");
            Assert.AreEqual(colorCode.Name, "Yellow");
            Assert.AreEqual(colorCode.SignificantFigures.Value, 4);
            Assert.AreEqual(colorCode.Multiplier.Value, 10000);
            Assert.AreEqual(colorCode.Tolerance, 0.05);
        }

        [TestMethod]
        public void GreenColorTest()
        {
            ColorCode colorCode = new ColorCode("Green", "GN", 5, 100000, 0.005);
            Assert.AreEqual(colorCode.Code, "GN");
            Assert.AreEqual(colorCode.Name, "Green");
            Assert.AreEqual(colorCode.SignificantFigures.Value, 5);
            Assert.AreEqual(colorCode.Multiplier.Value, 100000);
            Assert.AreEqual(colorCode.Tolerance, 0.005);
        }
    }
}
