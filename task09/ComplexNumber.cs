using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public ComplexNumber(int _Real,int _Imag)
        {
            Real = _Real;
            Imag = _Imag;
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber Ans = new ComplexNumber(0,0);
            Ans.Real = a.Real*b.Real - a.Imag*b.Imag;
            Ans.Imag = a.Real * b.Imag + a.Imag * b.Real;
            return Ans;
        }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
