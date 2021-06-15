using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMate
{
    class MainMenu
    {
        public void selMainMenu()
        {
            Board board = new Board();
            Console.CursorTop = 12;
            Console.CursorLeft = 100;
            int sel = Int32.Parse(Console.ReadLine());

            switch (sel)
            {
                case 1:
                    board.board_Regis();
                    break;
                case 2:
                    board.food();
                    break;
                case 3:
                    GameManager.Menu();
                    break;
                case 4:
                    Client.sel = "G";
                    board.board();
                    break;
                case 5:
                    Client.sel = "E";
                    break;
                default:
                    break;
            }
        }
        public void printMainMenu()
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
            Console.WriteLine("| 1. 게시판 작성   |");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 2. 음식투표      |");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 3. 미니게임      |");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 4. 새로고침      |");
            Console.CursorLeft = x + 1;
            Console.WriteLine("| 5. 프로그램 종료 |");
            Console.CursorLeft = x + 1;
            Console.Write("| 입력: ");
            Console.CursorLeft = 112;
            Console.WriteLine("|");
            Console.CursorLeft = x;
            Console.WriteLine("----------------------");
        }
    }
}
