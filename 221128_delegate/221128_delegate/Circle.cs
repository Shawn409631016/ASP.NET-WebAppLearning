using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _221128_delegate
{
    public class Circle
    {
        public int radius { get; set; }
        public double Area (Func<int, double> area)
        {
            double result;
            result = area(radius);
            return result;
        }
    }
}