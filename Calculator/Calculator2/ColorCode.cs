using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class ColorCode
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public int? SignificantFigures { get; private set; }
        public double? Multiplier { get; private set; }
        public double? Tolerance { get; private set; }

        public ColorCode(string name, string code, int? significantFigures, double? multiplier, double? tolerance)
        {
            Name = name;
            Code = code;
            SignificantFigures = significantFigures;
            Multiplier = multiplier;
            Tolerance = tolerance;
        }
    }
}
