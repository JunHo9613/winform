using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.ICar
{
    class HyundaiCar : ICar
    {
        public void hitBreak()
        {
            Console.WriteLine("현대 : 즉시 멈춤");
        }

        public void speedDown()
        {
            Console.WriteLine("현대 : 속도가 빠르게 줄어듦");
        }

        public void speedUp()
        {
            Console.WriteLine("현대 : 속도가 빠르게 올라감");
        }

        public void startEngine()
        {
            Console.WriteLine("현대 : 바로 시동 걸림");
        }
    }
}
