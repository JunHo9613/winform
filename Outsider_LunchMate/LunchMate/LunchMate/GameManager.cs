using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMate
{
    class GameManager
    {
        public const int ROCKSCISSORSPAPER = 1;
        public const int DRAWLOT = 2;
        public const int MEMORYGAME = 3;
        public const int WITS_GAME = 4;
        public const int BACK = 5;

        public static void Menu()
        {
            RockScissorsPaper rsp = new RockScissorsPaper();
            DrawLot drawLot = new DrawLot();
            MakeAPair map = new MakeAPair();
            Wits_Game wg = new Wits_Game();
            MainMenu mm = new MainMenu();
            
            bool isRun = true;
            

            while(isRun)
            {
                PrintMenu();
                Console.CursorTop = 12;
                Console.CursorLeft = 100;
                int sel = Int32.Parse(Console.ReadLine());
                switch (sel)
                {
                    case ROCKSCISSORSPAPER:
                        isRun = false;
                        rsp.PlayGame();
                        Console.ReadKey();
                        break;
                    case DRAWLOT:
                        isRun = false;
                        drawLot.Manager();
                        break;
                    case MEMORYGAME:
                        isRun = false;
                        map.MemoryGame();
                        break;
                    case WITS_GAME:
                        isRun = false;
                        wg.gameStartView();
                        break;
                    case BACK:
                        isRun = false;
                        mm.printMainMenu();
                        mm.selMainMenu();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            int x = 92;
            Console.CursorTop = 4;
            Console.CursorLeft = x;
            Console.WriteLine("----------------------");
            Console.CursorLeft = x;
            Console.WriteLine("---------메뉴---------");
            Console.CursorLeft = x;
            Console.WriteLine("----------------------");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 1. 가위바위보    |");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 2. 제비뽑기      |");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 3. 짝맞추기      |");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 4. 눈치게임      |");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 5. 돌아가기      |");  
            Console.CursorLeft = x + 1;
            Console.Write("| 입력: ");
            Console.CursorLeft = 112;
            Console.WriteLine("|");
            Console.CursorLeft = x;
            Console.WriteLine("----------------------");

        }
    }
}
