using mini_project;
using PinPongGame;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TeamProject
{
    class TeamProjectManager
    {
     
        public  void MenuLoop()
        {

            //System.Console.WindowHeight = 40; System.Console.WindowWidth = 100;
            ConsoleColor color = ConsoleColor.Green;
            Console.ForegroundColor = color;
            int sel = 0;
            while (true)
            {
                Numberbaseball n = new Numberbaseball();
                bingo b = new bingo();
                IntroGame intro = new IntroGame();
                
                Console.WriteLine("  ================================[게임 메뉴]=================================");
                Console.WriteLine(" l                                                                            l");
                Console.WriteLine(" l                               1. 숫자 야구                                 l");
                Console.WriteLine(" l                               2. 빙고 게임                                 l");
                Console.WriteLine(" l                               3. 핑퐁 게임                                 l");
                Console.WriteLine(" l                               4. 프로그램 종료                             l");
                Console.WriteLine(" l                                                                            l");
                Console.WriteLine("  ============================================================================");
                //int sel = 0;
                Console.Write("게임 선택 >> ");
                sel = Int32.Parse(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        ClearScreen();
                        n.PlayGame();
                        break;
                    case 2:
                        ClearScreen();
                        //Console.WriteLine("2번게임 실행");
                        b.Bingo();
                        break;
                    case 3:
                        ClearScreen();
                        //Console.WriteLine("3번게임 실행");
                        intro.Menu();
                        break;
                   case 4:
                        break;
                        
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                if(sel == 4)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }
                ClearScreen();
            }
        }
        static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}

