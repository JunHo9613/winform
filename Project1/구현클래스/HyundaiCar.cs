using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 20210602.구현클래스
{
    class HyundaiCar : ICar
    {
        public void play()
        {
            Console.WriteLine("HyundaiCar");
        }

        public void startEngine()
        {
            Console.WriteLine("HyundaiCar - 출발이 안좋다");
        }

        public void speedDown()
        {
            Console.WriteLine("HyundaiCar - 바로 느려진다.");
        }

        public void speedUp()
        {
            Console.WriteLine("HyundaiCar - 천천히 빨라진다");
        }

        public void hitbreak()
        {
            Console.WriteLine("HyundaiCar - 바로 꺼진다.");

        }
    }
}
