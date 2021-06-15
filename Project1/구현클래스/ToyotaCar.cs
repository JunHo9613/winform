using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 20210602.구현클래스
{
    class ToyotaCar : ICar
    {
        public void play()
        {
            Console.WriteLine("ToyotaCar");
        }

        public void startEngine()
        {
            Console.WriteLine("ToyotaCar - 시자쿠");
        }

        public void speedDown()
        {
            Console.WriteLine("ToyotaCar - 오소이");
        }

        public void speedUp()
        {
            Console.WriteLine("ToyotaCar - 하야크");
        }


        public void hitbreak()
        {
            Console.WriteLine("ToyotaCar - 시마이");
        }

    }
}
