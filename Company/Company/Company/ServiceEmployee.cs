using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class ServiceEmployee : Employee // 서비스 관리직
    {
        double ServiceSalary = 0;
        public ServiceEmployee(string rank, string name, string department) : base(rank, name, department)
        {

        }

        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
        }

        public override double yearSalary()
        {
            if (this.Rank == "부장")
            {
                ServiceSalary = ((Double)4500000 * 12) + ((double)4500000 * 0.3);
            }

            else if (this.Rank == "과장")
            {
                ServiceSalary = ((Double)3800000 * 12) + ((double)3800000 * 0.25);
            }

            else if (this.Rank == "대리")
            {
                ServiceSalary = ((Double)3200000 * 12) + ((double)3200000 * 0.2);
            }

            else if (this.Rank == "신입")
            {
                ServiceSalary = ((Double)2800000 * 12) + ((double)2800000 * 0.1);
            }
            return ServiceSalary;
        }
    }
}
