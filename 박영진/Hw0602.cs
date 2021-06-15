using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05
{
    class Hw0602
    {
        static void Main(string[] args)
        {
            /*1.
             int[,] a = {{1,2,3,4},
                         {5,6,7,8},
                         {9,10,11,12} };
             int[,] b = new int[4, 3];

             for(int i = 0; i<3; i++)
             {
                 for(int j=0; j<4; j++)
                 {
                     b[j, i] = a[i,j];
                 }     
             }
             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 3; j++)

                     Console.Write(b[i, j] + " ");
                     Console.WriteLine();           
            }*/

            /* int[,] a = {{1,2,3,4},
                          {5,6,7,8},
                          {9,10,11,12} };
             int[,] b = new int[4, 3];

             int idx = 0;
             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 4; j++)
                 {
                     idx = i * 4 + j;
                     b[idx / 3, idx % 3] = a[i, j];
                 }
             }

             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.Write(b[i, j] + " ");
                 }
                 Console.WriteLine();
             }*/

           /* 1.연도를 입력받으세요
  윤년인지 아닌지를 판별하세요
   4로 나누어 떨어지는 해는 일단 윤년에 포함시킵니다
   하지만 윤년중에 100으로 나누어떨어지는 해는 평년으로 하되
   평년중에 400으로 나누어 떨어지는 해는 윤년에 해당합니다
   프로그래밍을 완성하세요*/

            Console.Write("연도를 입력하세요 : ");
            int year = Int32.Parse(Console.ReadLine());

            if (year % 4 == 0 )
                if(year % 400 == 0)
                {
                    Console.WriteLine(year + "년은 윤년입니다.");
                }
                else if(year % 100 == 0)
                {
                    Console.WriteLine(year + "년은 평년입니다.");
                }
            else
                    Console.WriteLine(year + "년은 평년입니다.");

        }
    }
}

