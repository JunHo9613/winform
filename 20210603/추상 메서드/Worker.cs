using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03.추상_메서드
{
    abstract class Worker
    {
        public string emNum { get; set; }
        public string emName { get; set; }
        public double Pay { get; set; }

        public abstract double getMonthDay();
        public  virtual void showEmployeeInfo()
        {
            Console.WriteLine("사번 : " + this.emNum);
            Console.WriteLine("이름 : " + this.emName);
        }
    }
}
