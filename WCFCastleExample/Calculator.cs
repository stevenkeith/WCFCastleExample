using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCFCastleExample
{
    public class Calculator : ICalculator
    {
        public double Sum(string x, string y)
        {
            return Convert.ToDouble(x) + Convert.ToDouble(y);
        }

        public double Difference(string x, string y)
        {
            return Convert.ToDouble(x) - Convert.ToDouble(y);
        }
    }
}
