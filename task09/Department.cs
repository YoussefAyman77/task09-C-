using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
        }

        public override string ToString()
        {
            return $"Department Id = {Id}, Name = {Name}";
        }

        public override bool Equals(object obj)
        {
            Department temp = (Department)obj;
            return temp.Id == this.Id && temp.Name == this.Name;
        }
    }
}
