using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Team1_Gali
{
    class Gali
    {



        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.WriteLine("갈리기 = 갈리기 + 달리기");
            int x = 10, y = 12;
            int CNT = 0;

            int start = 5; // 시작점 변수
            int end = 80; // 끝 지점 변수
          

            Console.CursorLeft = x;
            Console.CursorTop = start;
            Console.WriteLine(":시작점");

            for (; start < 20; start++)
            {
            Console.CursorLeft = x;
            Console.CursorTop = start;
            Console.WriteLine(":");
            }

            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write("#");

            while (x < 80)
            {
                cki = Console.ReadKey(true);


                if (CNT % 2 == 0)
                {
                    if (cki.Key == ConsoleKey.RightArrow)
                    {
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write(" ");
                        x++;
                        CNT++;
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("#");
                    }
                    else
                    {
                        CNT++;
                        break;
                    }
                }
                else if (CNT % 2 != 0)
                {
                    if (cki.Key == ConsoleKey.LeftArrow)
                    {
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write(" ");
                        x++;
                        CNT++;
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("#");
                    }
                    else
                    {
                        CNT++;
                        break;
                    }

                }




                if (x == 80)
                {
                    x = 30;
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.WriteLine("끝!");
                    Console.ReadLine();
                }



            }

        }
    }
}
