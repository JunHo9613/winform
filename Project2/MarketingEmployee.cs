using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class MarketingEmployee : Employee // 영업 마케팅직 
    {
        double MarketingSalary = 0;
        public MarketingEmployee(string rank, string name, string department) : base(rank, name, department)
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
                MarketingSalary = ((Double)4200000 * 12) + ((double)4200000 * 0.3);
            }

            else if (this.Rank == "과장")
            {
                MarketingSalary = ((Double)3600000 * 12) + ((double)3600000 * 0.25);
            }

            else if (this.Rank == "대리")
            {
                MarketingSalary = ((Double)3000000 * 12) + ((double)3000000 * 0.2);
            }

            else if (this.Rank == "신입")
            {
                MarketingSalary = ((Double)2500000 * 12) + ((double)2500000 * 0.1);
            }
            return MarketingSalary;
        }
    }
}
