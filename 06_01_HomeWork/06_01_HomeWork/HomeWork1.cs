using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01_HomeWork
{
    class HomeWork1
    {
        /* 1. 2개의 2차원 배열을 생성합니다
           a배열은 아래처럼 초기화 합니다.
           int[,] a = { {1,2,3,4}, {5,6,7,8}};

           b배열은 int[,] b = new int[4, 2]; 로 선언합니다


           반드시 a값을 추출해서 b에 대입을 해서
           b를 출력하면
           1 5
           2 6
           3 7
           4 8
           이렇게 나오도록 담아주세요. */
           
           // int[2,4] a - > int[4,2] b
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            int[,] b = new int[4, 2];

            /*for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }*/

            /* 0,0 0,1 0,2 0,3
               1,0 1,1 1,2 1,3

               0,0 1,0
               0,1 1,1
               0,2 1,2
               0,3 1,3*/

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    b[j, i] = a[i, j];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j]);
                }
                Console.WriteLine();
            }
        }
       
        
            




    }
}
