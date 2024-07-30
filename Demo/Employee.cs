using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;

            return string.Compare(x.Name, y.Name);
        }
    }
    class Employee :IComparable<Employee> 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal salary { get; set; }

        public Employee()
        {
            
        }
        public  Employee(int id,string Name ,decimal salary) {
            this.Id = id;
            this.Name = Name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Id :{Id} , Name :{Name} ,Salary :{salary}";
        }

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1 ;
     
           return this.salary.CompareTo(other.salary) ;
        }
    }
}
