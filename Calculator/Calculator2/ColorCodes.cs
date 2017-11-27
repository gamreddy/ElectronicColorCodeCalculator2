using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class ColorCodes
    {

        Dictionary<string, ColorCode> colorCodes = new Dictionary<string, ColorCode>();

        public ColorCodes()
        {
            populateColorCodes();
        }

        private void populateColorCodes()
        {
            //colorCodes.Add("", new ColorCode("None", "", null, null, 0.2));
            colorCodes.Add("PK", new ColorCode("Pink", "PK", null, 0.001, null));
            colorCodes.Add("SR", new ColorCode("Silver", "SR", null, 0.01, 0.1));
            colorCodes.Add("GD", new ColorCode("Gold", "GD", null, 0.1, 0.05));
            colorCodes.Add("BK", new ColorCode("Black", "BK", 0, 1, null));
            colorCodes.Add("BN", new ColorCode("Brown", "BN", 1, 10, 0.01));
            colorCodes.Add("RD", new ColorCode("Red", "RD", 2, 100, 0.02));
            colorCodes.Add("OG", new ColorCode("Orange", "OG", 3, 1000, null));
            colorCodes.Add("YE", new ColorCode("Yellow", "YE", 4, 10000, 0.05));
            colorCodes.Add("GN", new ColorCode("Green", "GN", 5, 100000, 0.005));
            colorCodes.Add("BU", new ColorCode("Blue", "BU", 6, 1000000, 0.0025));
            colorCodes.Add("VT", new ColorCode("Violet", "VT", 7, 10000000, 0.001));
            colorCodes.Add("GY", new ColorCode("Gray", "GY", 8, 100000000, 0.0005));
            colorCodes.Add("WH", new ColorCode("White", "WH", 9, 1000000000, null));
        }

        public int getValue(string color)
        {
            int? significantFigures = colorCodes[color].SignificantFigures;
            if (significantFigures.HasValue)
                return significantFigures.Value;
            else
                return -1;
        }

        public double getMultiplier(string color)
        {
            double? multiplier = colorCodes[color].Multiplier;
            if (multiplier.HasValue)
                return multiplier.Value;
            else
                return 1;
        }

        public double getTolerance(string color)
        {

            if (string.IsNullOrEmpty(color))
                return 0.2;

            double? tolerance = colorCodes[color].Tolerance;
            if (tolerance.HasValue)
                return tolerance.Value;
            else
                return 0;
        }

        public IDictionary<string, ColorCode> getColorCodes()
        {
            return colorCodes;
        }

    }


}
