using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.Printer
{
    class Laser : Printer

    {
        private int printN, printP, toner = 100;
        public override void manufacturer()
        {
            Console.WriteLine("제조사 : 레이저");
        }

        public override void modelName()
        {
            Console.WriteLine("모델명 : Laser Printer");
        }

        public override void print()
        {
            if (printN == 0)
            {
                Console.WriteLine("인쇄 완료");
                return;
            }
            else
            {
                Console.WriteLine("인쇄 매수 : " + printN);
                printP--;
                Console.WriteLine("남은 종이 수 : " + printP);
                toner--;
                Console.WriteLine("남은 토너 수 : " + toner);
                printN--;
                print();
            }
        }

        public override void printNum(int printNum)
        {
            printN = printNum;
        }

        public override void printPaper(int printPaper)
        {
            printP = printPaper;
        }

    }
}
