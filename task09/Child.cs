using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Child : Parent
    {
        public override sealed double Salary{  get; set; }
        public Child(double _Salary) : base(_Salary)
        {
            Salary = _Salary;
        }
        
        public void DisplaySalary()
        {
            Console.WriteLine($"Salary is {Salary}");
        }
    }
}
