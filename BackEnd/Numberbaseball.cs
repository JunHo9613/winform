using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Numberbaseball
    {

        public void PlayGame()
        {
            ConsoleColor color = ConsoleColor.Green;
            Console.ForegroundColor = color;
            int n = 0;  //do while n번
            int out0 = 0;

            Random rand = new Random();
            int[] gamenum = new int[3];
            for (int i = 0; i < gamenum.Length; i++)
            {
                gamenum[i] = rand.Next(1, 10);

                for (int j = 0; j < i; j++)
                {
                    if (gamenum[i] == gamenum[j])
                    {
                        i--;
                        break;
                    }
                }

            }

            Console.WriteLine("===================[게임 규칙]=====================");
            Console.WriteLine(" *사용되는 숫자는 1에서 9까지 서로 다른 숫자이다.   ");
            Console.WriteLine(" *숫자는 맞지만 위치가 틀렸을 때는 볼(B)            ");
            Console.WriteLine(" *숫자와 위치가 전부 맞으면 스트라이크(S)           ");
            Console.WriteLine(" *숫자와 위치가 전부 틀리면 아웃                    ");
            Console.WriteLine(" *3회 아웃시 게임 오버                              ");
            Console.WriteLine(" *10회 안에 못 맞추면 게임 오버                     ");
            Console.WriteLine("===================================================");
            Console.WriteLine();
            do
            {
                n++;

                /*for (int i = 0; i < gamenum.Length; i++)
                {
                    Console.Write(gamenum[i]);
                }//난수표출*/

                Console.Write("({0}/10) 1~9까지의 수로 세자리 정수를 입력하세요 (000,게임종료)  : ", n);

                int a = Int32.Parse(Console.ReadLine());
                if (a == 000)
                {
                    Console.WriteLine("게임을 종료 합니다.");
                    break;
                }


                if ((a >= 1000) || (a > 0 && a < 100))
                {
                    Console.WriteLine("잘못 입력하였습니다. 100~999사이의 정수를 입력해주세요");
                    break;
                }

                else
                {
                    Console.WriteLine("입력하신 숫자 : " + a);
                }


                Console.WriteLine();
                int x = a % 100;
                int y = a / 100;

                //  a/100 == gamenum[0] y 100의자리
                //  x / 10 == gamenum[1] 10자리
                //  x % 10 == gamenum[2] 1의 자리
                if ((y == gamenum[0]) && (x / 10 == gamenum[1]) && (x % 10 == gamenum[2]))
                {
                    Console.WriteLine("3S 스트라이크 정답입니다. ");
                    Console.WriteLine("{0} 회 번째에 성공하셨습니다. ", n);
                    break;
                }

                if (((y == gamenum[0]) && (x / 10 != gamenum[1]) && (x % 10 != gamenum[2]))
                    || ((x / 10 == gamenum[1]) && (y != gamenum[0]) && (x % 10 != gamenum[2]))
                        || ((x % 10 == gamenum[2]) && (y % 10 != gamenum[0]) && (x / 10 != gamenum[1])))
                {
                    Console.Write("1S ");
                }
                if (((y == gamenum[0]) && (x / 10 == gamenum[1]) && (x % 10 != gamenum[2])) ||
                        ((y != gamenum[0]) && (x / 10 == gamenum[1]) && (x % 10 == gamenum[2])) ||
                        ((y == gamenum[0]) && (x / 10 != gamenum[1]) && (x % 10 == gamenum[2])))
                {
                    Console.Write("2S ");
                }

                if (((y == gamenum[1] && ((x / 10 != gamenum[2]) && (x % 10 != gamenum[0]))) ||
                    (y == gamenum[2] && ((x / 10 != gamenum[0]) && (x % 10 != gamenum[1]))) ||
                    (x / 10 == gamenum[0] && ((y != gamenum[2]) && (x % 10 != gamenum[1]))) ||
                    (x / 10 == gamenum[2] && ((y != gamenum[1]) && (x % 10 != gamenum[0]))) ||
                    (x % 10 == gamenum[0] && ((y != gamenum[1]) && (x / 10 != gamenum[2]))) ||
                    (x % 10 == gamenum[1] && ((y != gamenum[2]) && (x / 10 != gamenum[0])))))
                {
                    Console.Write("1B ");
                }

                if (((y == gamenum[1] && x / 10 == gamenum[2] && x % 10 != gamenum[0])) ||
                    ((y == gamenum[1] && x / 10 == gamenum[0] && x % 10 != gamenum[2])) ||
                    ((y == gamenum[2] && x / 10 == gamenum[0] && x % 10 != gamenum[2])) ||
                    ((y != gamenum[1] && x / 10 == gamenum[0] && x % 10 == gamenum[1])) ||
                    ((y != gamenum[1] && x / 10 == gamenum[2] && x % 10 == gamenum[0])) ||
                    ((y != gamenum[0] && x / 10 == gamenum[2] && x % 10 == gamenum[1])) ||
                    ((y == gamenum[2] && x / 10 != gamenum[0] && x % 10 == gamenum[1])) ||
                    ((y == gamenum[2] && x / 10 != gamenum[1] && x % 10 == gamenum[0])) ||
                    ((y == gamenum[1] && x / 10 != gamenum[2] && x % 10 == gamenum[0])))
                {
                    Console.Write("2B ");
                }


                if (((y == gamenum[1] && x / 10 == gamenum[2] && x % 10 == gamenum[0])) ||
                    (y == gamenum[2] && x / 10 == gamenum[0] && x % 10 == gamenum[1]))
                {
                    Console.Write("3B ");
                }

                if (((y != gamenum[0]) && (y != gamenum[1]) && (y != gamenum[2])) &&
                    ((x / 10 != gamenum[1]) && (x / 10 != gamenum[0]) && (x / 10 != gamenum[2])) &&
                    ((x % 10 != gamenum[2]) && (x % 10 != gamenum[0]) && (x % 10 != gamenum[1])))
                {
                    out0++;
                    Console.WriteLine("{0}아웃입니다.", out0);

                    if (out0 == 3)
                    {

                        Console.WriteLine("게임 오버 ");
                        Console.Write("정답은 ");
                        for (int i = 0; i < gamenum.Length; i++)
                        {
                            Console.Write(gamenum[i]);
                        }
                        Console.WriteLine();
                        break;
                    }

                }

                if (n == 10)
                {
                    Console.WriteLine("10회 종료 게임오버.");
                    Console.WriteLine("정답은");
                    for(int i = 0; i < gamenum.Length; i++)
                    {
                        Console.Write(gamenum[i]);
                    }          
                
                }
                Console.WriteLine();
                Console.WriteLine("==============================================================================\n");
            } while (n < 10);
        }
    }
}

