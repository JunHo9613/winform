using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.Calculation
{
    class Div : Calc
    {
        private int a, b;
        public override int calculation()
        {
            return a / b;
        }

        public override void setValue(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
