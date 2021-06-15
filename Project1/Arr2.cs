using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. 2개의 2차원 배열을 생성합니다
   a배열은 아래처럼 초기화 합니다.
   int[,] a = 
   {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12}
   };

        b배열은 int[,] b = new int[4, 3]; 로 선언합니다


   반드시 a값을 추출해서 b에 대입을 해서
   b를 출력하면
   1   2   3
   4   5   6
   7   8   9
   10  11  12
   이렇게 나오도록 담아주세요.*/
namespace Project1
{
    class Arr2
    {        
        static void Main(string[] args)
        {            /*
            int[,] a = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9,10,11,12 } };
            int[,] b = new int[4, 3];
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    b[i, j] = a[j, i];
                }
            }
            Console.WriteLine("[정답]");

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            int[,] a = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] b = new int[4, 3];

            int idx = 0;

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    idx = i * 4 + j;
                    
                    b[idx / 3, idx % 3] = a[i, j];
                }
            }

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write(b[j, i] + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}

