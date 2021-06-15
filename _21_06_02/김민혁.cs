using _21_06_02.Calculation;
using _21_06_02.ICar;
using _21_06_02.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02
{
    class 김민혁
    {
        static void Clear()
        {
            Console.ReadLine();
            Console.Clear();
        }

        static void Q(int a)
        {
            switch (a)
            {
                case 1:
                    Q1();
                    break;
                default:
                    Console.WriteLine("다시 입력해주세요.");
                    break;
            }
        }
        static void Q1()
        {
            Console.Write("문제 번호 입력: ");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    Q1_1();
                    break;
                case 2:
                    Q1_2();
                    break;
                case 3:
                    Q1_3();
                    break;
                case 4:
                    Q1_4();
                    break;
                case 5:
                    Q1_5();
                    break;
                case 6:
                    Q1_6();
                    break;
                default:
                    Console.WriteLine("처음부터 다시 입력해주세요.");
                    break;
            }
            Console.Clear();
        }

        static void Q1_1()
        {
            Console.WriteLine("상속문제 - 1번 : 다음 상속구조를 설계하세요"); // 이경록

            PrinterMain print = new PrinterMain();

            print.Start();

            Clear();
        }
        static void Q1_2()
        {
            Console.WriteLine("윤년 - 1번 : 연도를 입력받으세요. 윤년인지 아닌지를 판별하세요"); // 박영진

            Console.Write("년도를 입력해주세요: ");
            int year = Int32.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    Console.WriteLine("윤년입니다.");
                }
                else if(year % 100 == 0 && year % 400 != 0)
                {
                    Console.WriteLine("평년입니다.");
                }
                else
                {
                    Console.WriteLine("윤년입니다.");
                }
            }
            else
            {
                Console.WriteLine("평년입니다.");
            }
            Clear();
        }
        static void Q1_3()
        {
            Console.WriteLine("이차원배열 - 1번 : 2개의 2차원 배열을 생성합니다"); // 오경빈
            int[,] a = { {1,2,3,4},{5,6,7,8},{9,10,11,12} };
            int[,] b = new int[4, 3];

            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    b[i, j] = a[j, i];
                }
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.ReadLine();
            }

            Clear();
        }
        static void Q1_4()
        {
            Console.WriteLine("이차원배열 - 2번 : 2개의 2차원 배열을 생성합니다"); // 김상재

            int[,] a = { {1,2,3,4}, {5,6,7,8}, {9,10,11,12} };
            int[,] b = new int[4, 3];
            int c = 0;
            int d = 0;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = a[c, d];
                    if (d == 3)
                    {
                        d = 0;
                        c++;
                    }
                    else
                    {
                        d++;
                    }
                }
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.ReadLine();
            }

            Clear();
        }
        static void Q1_5()
        {
            Console.WriteLine("인터페이스 - 1번 : ICar 인터페이스를 제작"); 

            TestMain test = new TestMain();
            test.Start();

            Clear();
        }
        static void Q1_6()
        {
            Console.WriteLine("추상클래스 - 1번 : 더하기, 빼기 곱하기 나누기를 수행하는 각 클래스 Add, Sub, Mul, Div를 만드세요"); // 엄준호

            calculate calc = new calculate();
            calc.start();
            Console.ReadLine();

            Clear();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("문제 번호 입력: ");
                Q(Int32.Parse(Console.ReadLine()));

                Console.Write("종료하시겠습니까? (yes/no): ");
                string b = Console.ReadLine();

                if (b == "yes")
                {
                    Console.WriteLine("종료하겠습니다.");
                    break;
                }

                Console.Clear();
            }
        }
    }
}
