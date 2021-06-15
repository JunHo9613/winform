using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03.추상_메서드
{
    class Temporary : Worker
    {
        public double hireYear { get; set; }
        public override double getMonthDay()
        {
            this.hireYear = this.Pay / 12;
            return this.hireYear;
        }
        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
            Console.WriteLine("계약금 : " + this.Pay);
            Console.WriteLine("고용 기간 : " + this.hireYear);
        }
    }
}
