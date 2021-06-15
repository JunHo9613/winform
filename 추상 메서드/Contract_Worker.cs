using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03.추상_메서드
{
    class Contract_Worker : Worker
    {
        public double workDay { get; set; }
        public override double getMonthDay()
        {
            return this.Pay * workDay;
        }
        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
            Console.WriteLine("일당 : " + this.Pay);
            Console.WriteLine("일 수 : " + this.workDay);
        }
    }
}
