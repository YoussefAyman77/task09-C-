using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Parent
    {
        public virtual double Salary { get; set; }

        public Parent(double _Salary)
        {
            Salary=_Salary;
        }
    }
}
