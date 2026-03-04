using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class CircleC
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleC(double _Radius, string _Color)
        {
            Radius = _Radius; Color = _Color;
        }
        public override string ToString()
        {
            return $"Radius = {Radius}, Color = {Color}";
        }
    }
}
