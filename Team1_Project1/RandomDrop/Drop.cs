using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDrop
{
    class Drop

    {
        static void Main(string[] args)
        {
            int stonex;

            while (true)
            {
                Random randrop = new Random();
                stonex = randrop.Next(6, 29) * 2; // stonex 랜덤값

                for (int i = 6; i < 20; i++)
                {
                    Console.CursorLeft = stonex;
                    Console.CursorTop = i;
                    Console.Write("♨");
                    System.Threading.Thread.Sleep(100);
                    Console.CursorLeft = stonex;
                    Console.CursorTop = i;
                    Console.Write("  ");

                }
            }
        }
    }
}
 

