using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public virtual string Department { get; set; }

        public Person(int _Age, string _Name, string _Department)
        {
            Age = _Age;
            Name = _Name;
            Department = _Department;
        }

        public override string ToString()
        {
            return $"Name is {Name}, Age is {Age}, Department is {Department}";
        }
    }
}
