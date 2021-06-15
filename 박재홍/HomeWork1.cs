using System;
using System.Collections.Generic;
using System.Text;

namespace _005_Homework_0601
{
//1. 2개의 2차원 배열을 생성합니다
//   a배열은 아래처럼 초기화 합니다.
//   int[,] a = {
//    {1,2,3,4},
//    {5,6,7,8}
//   };

//    b배열은 int[,] b = new int[4, 2]; 로 선언합니다


//   반드시 a값을 추출해서 b에 대입을 해서
//   b를 출력하면
//   1 5
//   2 6
//   3 7
//   4 8
//   이렇게 나오도록 담아주세요.

 // 1. 2개의 2차원 배열을 생성합니다
 //a배열은 아래처럼 초기화 합니다.
 //int[,] a = {
 // {1,2,3,4},
 // {5,6,7,8}
 //};

 // b배열은 int[,] b = new int[4, 2]; 로 선언합니다


 //반드시 a값을 추출해서 b에 대입을 해서
 //b를 출력하면
 //1 2
 //3 4
 //5 6
 //7 8
 //이렇게 나오도록 담아주세요.
    class HomeWork1
    {
        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
        private static void SelectQestion()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 (나가기는 0 입력) : ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");

                if (sel == 0)
                    break;
                switch (sel)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
        }
        static void Q1()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\t1. 2개의 2차원 배열을 생성  \n\t  int[,] a = {{1,2,3,4},{5,6,7,8}}");
            Console.WriteLine("\n\t  int[,] b = new int[4, 2]");
            Console.WriteLine("\n\t  a배열 값 ->  b배열 대입 시켜 아래와 같이 출력");
            Console.Write("\n\t     1 5");
            Console.Write("\n\t     2 6");
            Console.Write("\n\t     3 7");
            Console.WriteLine("\n\t     4 8");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int[,] a = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            int[,] b = new int[4, 2];
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    b[i, j] = a[j, i];
                }
            }
            Console.WriteLine("[정답]");

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Q2()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\t2. 2개의 2차원 배열을 생성  \n\t  int[,] a = {{1,2,3,4},{5,6,7,8}}");
            Console.WriteLine("\n\t  int[,] b = new int[4, 2]");
            Console.WriteLine("\n\t  a배열 값 ->  b배열 대입 시켜 아래와 같이 출력");
            Console.Write("\n\t     1 2");
            Console.Write("\n\t     3 4");
            Console.Write("\n\t     5 6");
            Console.WriteLine("\n\t     7 8");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int[,] a = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            int[,] b = new int[4, 2];
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    b[i, j] = a[j, i];
                }
            }
            Console.WriteLine("[정답]");

            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    Console.Write(b[j, i] + " ");
                    if(j == 1)
                        Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            SelectQestion();
        }
    }
}
