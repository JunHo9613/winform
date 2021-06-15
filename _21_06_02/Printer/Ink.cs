using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.Printer
{
    class Ink : Printer
    {
        private int printN, printP,ink = 100;
        public override void manufacturer()
        {
            Console.WriteLine("제조사 : 잉크젯");
        }

        public override void modelName()
        {
            Console.WriteLine("모델명 : Ink-jet Printer");
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
                ink--;
                Console.WriteLine("남은 잉크 수 : " + ink);
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
