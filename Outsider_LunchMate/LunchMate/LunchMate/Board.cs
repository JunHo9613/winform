using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchMate
{
    class Board
    {

        public static string title { get; set; }
        public static string text { get; set; }
        MainMenu mm = new MainMenu();
        Food f = new Food();
        TitleText tt = new TitleText();

        public void board_Regis()
        {
            Console.Clear();
            int x = 47;
            int y = 1;
            Console.WriteLine("================================================");
            Console.Write("| 제목 : ");
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.WriteLine("|");
            Console.WriteLine("================================================");
            Console.Write("| 본문 : ");
            y = 3;
            for (int i = 0; i <= 20; i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.WriteLine("|");
                y++;
            }
            y = 3;
            x = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.WriteLine("|");
                y++;
            }
            Console.WriteLine("================================================");
            x = 9;
            y = 1;
            Console.CursorLeft = x;
            Console.CursorTop = y;
            title = Console.ReadLine();
            y = 3;
            Console.CursorLeft = x;
            Console.CursorTop = y;
            string text1 = "";
            for (; ; )
            {
                int yy = Console.CursorTop;
                text1 += Console.ReadLine();
                if (yy == 23) break;
                Console.Write("| ");
                text1 += "\n              |";
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                    break;
            }
            text = text1;
            Client.sel = "U";
            board();
        }
        public void board()
        {
            int y = 2;
            Console.Clear();
            Console.CursorTop = y;
            Console.CursorLeft = 48;
            Console.CursorTop = y;
            Console.WriteLine("안녕하세요");
            Console.CursorLeft = 50;
            Console.CursorTop = 4;
            Console.WriteLine("게시판");
            y = 2;
            Console.CursorLeft = 14;
            Console.CursorTop = y + 1;
            Console.WriteLine("=============================================================================");
            for (int i = 0; i <= 1000; i++)
            {
                Console.CursorLeft = 14;
                Console.CursorTop = y + 2;
                Console.WriteLine("|");
                y++;
            }
            y = 4;
            for (int i = 0; i <= 1000; i++)
            {
                Console.CursorLeft = 90;
                Console.CursorTop = y;
                Console.WriteLine("|");
                y++;
            }
            mm.printMainMenu();
        }
        
            public void insertFood()
        {
            Console.Clear();
            Console.Write("음식 이름 입력>>");
            string food = Console.ReadLine();
            f.food = food;
        }
        public void food()
        {
            insertFood();
            f.printAllFood();
            Console.ReadLine();
        }
    }
}
