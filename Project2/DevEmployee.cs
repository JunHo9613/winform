using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class DevEmployee : Employee // 개발직
    {
        double DevSalary = 0;
        public DevEmployee(string rank, string name, string department) : base(rank, name, department)
        {

        }

        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
        }

        public override double yearSalary()
        {
            if(this.Rank == "부장")
            {
                DevSalary = ((Double)5000000 * 12) + ((double)5000000 * 0.3);
            }

            if (this.Rank == "과장")
            {
                DevSalary = ((Double)4000000 * 12) + ((double)4000000 * 0.25);
            }

            if (this.Rank == "대리")
            {
                DevSalary = ((Double)3500000 * 12) + ((double)3500000 * 0.2);
            }

            if (this.Rank == "신입")
            {
                DevSalary = ((Double)3000000 * 12) + ((double)3000000 * 0.1);
            }
            return DevSalary;
        }
    }
}
