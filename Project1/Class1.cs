using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A 네임스페이스 아래 있는 요소를 바로 접근할께
using A;
using B.My;

namespace A
{
    class Calc
    {
        public int add(int a, int b) { return a + b; }
        public int sub(int a, int b) { return a - b; }
        public int mul(int a, int b) { return a * b; }
        public int div(int a, int b) { return a / b; }
    }
}

namespace B
{
    namespace My
    {
        class MyClass
        {
            public int i = 100;
        }
    }
}

namespace _62_namespace
{
    class NamespaceEx
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine(calc.add(10, 20));
            Console.WriteLine(calc.sub(10, 20));
            Console.WriteLine(calc.mul(10, 20));
            Console.WriteLine(calc.div(10, 20));

            MyClass objMy = new MyClass();
            Console.WriteLine(objMy);
            Console.WriteLine(objMy.i);
        }
    }
}
