using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework0601_4
{
    class Guseul
    {
        private int gu;

        public Guseul(int ch1)
        {
            this.gu = ch1;
        }


        public void game(int gu1, Guseul guseul)
        {
            gu += gu1;
            guseul.game1(gu1);
        }

        public void game1(int gu1)
        {
            gu -= gu1;
        }

        public void show()
        {
            Console.WriteLine("현재 구슬의 수: "+ gu);
        }

    }
    class homework4
    {
        static void Main(string[] args)
        {
            Guseul chile1 = new Guseul(15);
            Guseul chile2 = new Guseul(9);

            chile1.game(2, chile2);
            chile2.game(7, chile1);

            Console.WriteLine("어린이1 시합결과 : ");
            chile1.show();
            Console.WriteLine("어린이2 시합결과 : ");
            chile2.show();

        }
    }
}
