using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210604_solve
{
    abstract class Employee
    {
        public string CompanyNum { get; set; }
        public string Name { get; set; }
        public int Pay { get; set; }

        public Employee(string companyNum, String name, int pay)
        {
            this.CompanyNum = companyNum;
            this.Name = name;
            this.Pay = pay;
        }
        public virtual void  showEmployeeInfo()
        {
            Console.WriteLine("사번 : " + this.CompanyNum);
            Console.WriteLine("이름 : " + this.Name);
            Console.WriteLine("급여 : " + this.Pay);

        }

        public abstract double getMonthDay();
    }
}
