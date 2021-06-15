using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.ICar
{
    class ToyotaCar : ICar
    {
        public void hitBreak()
        {
            Console.WriteLine("토요타 : 안전하게 멈춤");
        }

        public void speedDown()
        {
            Console.WriteLine("토요타 : 속도가 안전하게 줄어듦");
        }

        public void speedUp()
        {
            Console.WriteLine("토요타 : 속도가 안전하게 올라감");
        }

        public void startEngine()
        {
            Console.WriteLine("토요타 : 안전하게 시동 걸림");
        }
    }
}
