using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.Calculation
{
    class calculate
    {
        public void start()
        {
            Calc[] calc = { new Add(), new Sub() , new Mul(), new Div() };

            for(int i = 0; i < calc.Length; i++)
            {
                calc[i].setValue(10, 5);
                Console.WriteLine("입력 값: 10, 5");
                Console.WriteLine(calc[i].calculation());
            }
        }
    }
}
