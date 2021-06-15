using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.Printer
{
    abstract class Printer
    {
        public abstract void modelName();
        public abstract void manufacturer();
        public void interfaceEx()
        {
            Console.WriteLine("인터페이스 종류 : USB, paraller port");
        }
        public abstract void print();
        public abstract void printPaper(int printPaper);
        public abstract void printNum(int printNum);

    }
}
