using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IOhmValueCalculator
    {
        double CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor);
        OhmRange CalculateOhmValueRange(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
    }

    public struct OhmRange{
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public OhmRange(double minValue, double maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
