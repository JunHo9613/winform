using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework0601_2
{
   // 1. 2개의 2차원 배열을 생성합니다
   //a배열은 아래처럼 초기화 합니다.
   //int[,] a = {
   // {1,2,3,4},
   // {5,6,7,8}
   //};

   // b배열은 int[,] b = new int[4, 2]; 로 선언합니다

   //반드시 a값을 추출해서 b에 대입을 해서
   //b를 출력하면
   //1 5
   //2 6
   //3 7
   //4 8
   //이렇게 나오도록 담아주세요.
    class Homework2
    {
        static void Main(string[] args)
        {
            int[,] a = {{1,2,3,4},
                        {5,6,7,8}}; //[2,4];
            int[,] b = new int[4, 2];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++) // 주소값은 0부터 시작하기때문에
                {
                    b[i, j] = a[j, i];
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
