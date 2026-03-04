using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Utility
    {
        public static double CalculateRectanglePreimeter(double lenght, double width)
        {
            return (lenght + width) * 2;
        }
        public static double ConvertTempreture(double temp, bool sel)
        {
            return sel ? temp * (9.0 / 5.0) + 32 : (temp - 32) * (5.0 / 9.0);
        }

    }
}
