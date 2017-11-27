using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class OhmValueCalcuator : IOhmValueCalculator
    {

        ColorCodes colorCodes;

        public OhmValueCalcuator(ColorCodes colorCodes)
        {
            this.colorCodes = colorCodes;
        }

        public double CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor)
        {

            if (string.IsNullOrWhiteSpace(bandAColor) || string.IsNullOrWhiteSpace(bandBColor) || string.IsNullOrWhiteSpace(bandCColor))
            {
                throw new Exception("BandA, BandB and BandC are required to calculate Ohm value.");
            }
            int aValue = colorCodes.getValue(bandAColor);
            int bValue = colorCodes.getValue(bandBColor);
            double cValue = colorCodes.getMultiplier(bandCColor);

            return  ((aValue * 10 + bValue) * cValue);
      
        }

        public OhmRange CalculateOhmValueRange(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            if(string.IsNullOrWhiteSpace(bandAColor) || string.IsNullOrWhiteSpace(bandBColor) || string.IsNullOrWhiteSpace(bandCColor))
            {
                throw new Exception("BandA, BandB and BandC are required to calculate Ohm value.");
            }
            double ohmValue = CalculateOhmValue(bandAColor, bandBColor, bandCColor);
            double tolerance = colorCodes.getTolerance(bandDColor);
            return new OhmRange((ohmValue - ohmValue * tolerance), (ohmValue + ohmValue * tolerance));
            
        }




    }


}
