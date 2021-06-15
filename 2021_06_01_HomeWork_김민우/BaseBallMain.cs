using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_01
{
    class GeneratorThreeNum
    {
        public void Rand()
        {
            int[] abc = new int[3];
            Random rand = new Random();
            for (int i = 0; i < abc.Length; i++)
            {
                abc[i] = rand.Next(0, 9);
                for (int j = 0; j < i; j++)
                {
                    if (abc[i] == abc[j])
                    {
                        i--;
                    }
                }
            }
        }
    }
    class BaseBallMenu
    {
        public int PrintMenu()
        {
            Console.WriteLine("0~9 사이 값 입력>>");
            int a = Int32.Parse(Console.ReadLine());
            return a;
        }
    }
    class DecisionBall
    {  
    }
    class BaseBallMain
    {
    }
}
