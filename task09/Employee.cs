using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Department Department { get; set; }

        public Employee(int _Id, string _Name,double _Salary,int _DeptId,string _DeptName)
        {
            Id = _Id; 
            Name = _Name;
            Salary = _Salary;
            Department = new Department(_DeptId, _DeptName);
        }

        //public override bool Equals(object obj)
        //{
        //    Employee temp = (Employee)obj;
        //    return this.Name==temp.Name && this.Salary==temp.Salary && this.Id==temp.Id;
        //}
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            return this.Department.Equals(temp.Department);
        }
        public override string ToString()
        {
            return $"{Name}, {Id},{Salary} ,{Department.Id},{Department.Name}";
        }
    }
}
