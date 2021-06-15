using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.Printer
{
    class PrinterMain
    {
        Printer[] print = { new Ink(), new Laser()};

        public void Start()
        {
            for (int i = 0; i <print.Length; i++)
            {
                print[i].manufacturer();
                print[i].modelName();
                print[i].interfaceEx();
                print[i].printNum(3);
                print[i].printPaper(50);
                print[i].print();
            }
        }


    }
}
