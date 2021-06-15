using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210604_solve
{
    class ContractEmployee : Employee
    {
        public int WorkDay { get; set; }

        public ContractEmployee(string companyNum, string name, int pay) : base(companyNum, name, pay)
        {
            this.WorkDay = WorkDay;
        }

        public override double getMonthDay()
        {
            return (double)this.Pay * this.WorkDay;
        }

        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
            Console.WriteLine("일한일수 : " + this.WorkDay);
            Console.WriteLine("월급 : " + getMonthDay());
        }

       
    }
}
