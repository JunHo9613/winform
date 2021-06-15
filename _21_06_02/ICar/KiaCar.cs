using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.ICar
{
    class KiaCar : ICar
    {
        public void hitBreak()
        {
            Console.WriteLine("기아 : 부드럽게 멈춤");
        }

        public void speedDown()
        {
            Console.WriteLine("기아 : 속도가 부드럽게 줄어듦");
        }

        public void speedUp()
        {
            Console.WriteLine("기아 : 속도가 부드럽게 올라감");
        }

        public void startEngine()
        {
            Console.WriteLine("기아 : 부드럽게 시동 걸림");
        }
    }
}
