using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 20210602.구현클래스
{
    class KiaCar : ICar
    {
        public void play()
        {
            Console.WriteLine("KiaCar");
        }

        public void startEngine()
        {
            Console.WriteLine("KiaCar - 출발이 좋다");
        }

        public void speedDown()
        {
            Console.WriteLine("KiaCar - 천천히 느려진다.");
        }

        public void speedUp()
        {
            Console.WriteLine("KiaCar - 바로 빨라진다");
        }

        public void hitbreak()
        {
            Console.WriteLine("KiaCar - 천천히 꺼진다.");
        }
    }
}
