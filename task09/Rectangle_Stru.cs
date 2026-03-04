using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Rectangle_Stru
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle_Stru(double _Length, double _Width)
        { Length = _Length; Width = _Width; }

        public override string ToString()
        {
            return $"Lenght is {Length}, Width is {Width}";
        }
    }
}
