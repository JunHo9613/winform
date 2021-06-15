using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    abstract class Employee
    {
        public string Rank { get; set; } // 직급

        public string Name { get; set; } // 이름

        public string Department { get; set; } // 부서

        public int Salary { get; set; } // 월급

        public Employee(string rank, string name, string department)
        {
            this.Rank = rank;
            this.Name = name;
            this.Department = department;
        }

        public virtual void showEmployeeInfo()
        {
            Console.WriteLine("부서: " + this.Department);
            Console.WriteLine("직급: " + this.Rank);
            Console.WriteLine("이름: " + this.Name);
        }

        public abstract double yearSalary();
    }
}
