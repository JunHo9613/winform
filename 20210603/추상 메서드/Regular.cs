using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03.추상_메서드
{
    class Regular : Worker
    {
        public double bonus { get; set; }
        public override double getMonthDay()
        {
            return this.Pay / 12 + bonus / 12;
        }
        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
            Console.WriteLine("연 봉 : " + this.Pay);
            Console.WriteLine("보너스 : " + this.bonus);
        }
    }
}
