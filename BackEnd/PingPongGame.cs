using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Collections;

namespace PinPongGame
{
    class IntroGame
    {
        PlayGame play = new PlayGame();
        int[] playerNum = new int[2];
        bool isrun = true;

        public void Menu()
        {
            play.initRecord();
            while (isrun)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\t\t-------------------------------");
                Console.WriteLine("\t\t핑퐁게임에 오신것을 환영합니다.");
                Console.WriteLine("\t\t-------------------------------");

                Console.WriteLine("\n\t\t[메뉴]");
                Console.WriteLine("\n\t\t1. 게임 실행");
                Console.WriteLine("\n\t\t2. Tutorial");
                Console.WriteLine("\n\t\t3. 게임 기록");
                Console.WriteLine("\n\t\t4. 게임 종료");

                Console.Write("\n\t\t입력:");
                int sel = 0;
                sel = Int32.Parse(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        RegisterGame();
                        play.DrawPlayer();
                        break;
                    case 2:
                        Tutorial();
                        break;
                    case 3:
                        play.printAllRecord();
                        Thread.Sleep(100);
                        break;
                    case 4:
                        play.programExit();
                        isrun = false;
                        break;
                    default:
                        Console.WriteLine("\n\t\t잘못 입력하셨습니다.");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        void RegisterGame()
        {
            Console.Clear();
            Console.WriteLine("\t\t-------------------------------");
            Console.WriteLine("\t\t핑퐁게임에 오신것을 환영합니다.");
            Console.WriteLine("\t\t-------------------------------");

            for (int i = 0; i < playerNum.Length; i++)
            {
                Console.Write($"\t\t{i + 1}번째 플레이어 이름: ");
                if (i == 0)
                    play.playerName = Console.ReadLine();
                if (i == 1)
                    play.playerName1 = Console.ReadLine();
            }
        }

        void Tutorial()
        {
            Console.Clear();
            Console.WriteLine("\t\t------------[Tutorial]------------\n");
            Console.WriteLine("\n\t  2P 오른쪽:Alt 왼쪽:Ctr   1P 오른쪽:→ 왼쪽:← ");
            Console.WriteLine("\t\n  1. 움직임은 좌우만 가능합니다.");
            Console.WriteLine("\t\n\n  2. 상대방의 바를 넘어갈 수 없습니다. ");
            Console.WriteLine("      따라서 상대방의 움직임을 막을 수도 있습니다. ");
            Console.WriteLine("\t\n\n  3. 공이 장애물 '^' / '+' 과 부딪히면 아래로 반사됩니다. ");
            Console.WriteLine("\t\n\n  4. 시간 흐름에 따라 난이도가 올라갑니다. ");
            Console.WriteLine("\t\n\n  5. 점수 계산은 공을 직접 바를 이용해 반사시킨 횟수에 따라 증가됩니다. ");
            Console.WriteLine("\t\n\n  6. 공이 바닥에 닿으면 게임이 종료 됩니다. ");
            Console.WriteLine("      점수에 따라 승 / 패 / 공동우승을 가립니다. ");
            Console.ReadKey();
            Console.Clear();
        }
    }

    class PlayGame
    {
        Record recordGame = new Record();
        ArrayList arrList = new ArrayList();
        Stopwatch stopwatch = new Stopwatch();
        Random r = new Random();

        const int GRID_W = 80;
        const int GRID_H = 20;
        const int X_WALL = 77;
        const int Y_WALL = 19;
        const int VK_LEFT_2 = 0x11;
        const int VK_RIGHT_2 = 0x12;
        const int VK_LEFT_1 = 0x25;
        const int VK_RIGHT_1 = 0x27;

        static int count = 0, count1 = 0;

        public string playerName { get; set; }
        public string playerName1 { get; set; }
        public string tm1 { get; set; }
        public string countS { get; set; }
        public string countS1 { get; set; }
        public string winner { get; set; }

        [DllImport("user32")]

        public static extern UInt16 GetAsyncKeyState(Int32 vKey);
        static char[,] map = new char[GRID_H, GRID_W];

        public void PrintMap(int obstacle = 1, int obstacle1 = 30)
        {

            for (int y = 0; y < GRID_H; y++)
            {
                for (int x = 0; x < GRID_W; x++)
                {
                    if (x == 0 || x == GRID_W - 1)
                        map[y, x] = '*';
                    else if (y == 0 || y == GRID_H - 1)
                        map[y, x] = '-';
                    else if (x == r.Next(1, obstacle1) || y == r.Next(1, obstacle1))
                        map[y, x] = '^';
                    else if (x == r.Next(1, obstacle1) || y == r.Next(1, obstacle1))
                        map[y, x] = '+';
                    else
                        map[y, x] = ' ';
                }
            }

            for (int col = 0; col < GRID_H; col++)
            {
                for (int row = 0; row < GRID_W; row++)
                {
                    if (map[0, row] == map[col, row])
                        Console.Write(map[col, row]);
                    else
                        Console.Write(map[col, row]);
                }
            }
            Console.WriteLine();
        }

        public void DrawPlayer()
        {
            bool xDirection = true;
            bool yDirection = true;
            int x = 60, y = 17, x1 = 20, y1 = 17;
            int x2 = 2, y2 = 2, s = 100;

            Console.Clear();
            PrintMap(1, 100);
            stopwatch = Stopwatch.StartNew();
            long cnt = 0;
            while (true)
            {
                Console.SetCursorPosition(60, 20);
                stopwatch.Start();
                if (cnt % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.CursorLeft = x2;
                    Console.CursorTop = y2;
                    Console.Write("o");
                    System.Threading.Thread.Sleep(s);
                    Console.CursorLeft = x2;
                    Console.CursorTop = y2;
                    Console.Write(" ");

                    if (x2 == X_WALL)
                        xDirection = false;
                    if (x2 == 2)
                        xDirection = true;
                    if (xDirection == true)
                        x2 += 1;
                    if (xDirection == false)
                        x2 -= 1;

                    if (y2 == Y_WALL)
                        yDirection = false;
                    if (y2 == 1)
                        yDirection = true;
                    if (yDirection == true)
                        y2 += 1;
                    if (yDirection == false)
                        y2 -= 1;

                    if (y2 == y - 1 && x2 >= (x) && x2 <= (x + 10))
                    {
                        yDirection = false;
                        count += 1;
                    }
                    if (y2 == y1 - 1 && x2 >= (x1) && x2 <= (x1 + 10))
                    {
                        yDirection = false;
                        count1 += 1;
                    }

                    for (int i = 0; i < GRID_H; i++)
                    {
                        for (int j = 0; j < GRID_W; j++)
                        {
                            if (map[i, j] == '^' || map[i, j] == '+')
                            {
                                if (x2 == j && y2 == i)
                                    yDirection = true;
                            }
                        }
                    }
                    if (y2 == Y_WALL)
                        break;
                }

                if (cnt % 1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(x, y);
                    Console.Write(" 1□□□ "); // 1p
                    Thread.Sleep(1);
                    Console.SetCursorPosition(x, y);
                    Console.Write(" "); // 1p 

                    if ((GetAsyncKeyState((int)VK_LEFT_1) & 0x8000) != 0)
                    {
                        if (x > x1 + 7)
                            x -= 1;
                    }
                    if ((GetAsyncKeyState((int)VK_RIGHT_1) & 0x8000) != 0)
                    {
                        if (x < X_WALL - 7)
                            x += 1;
                    }
                }
                if (cnt % 1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(x1, y1);
                    Console.Write(" 2□□□ "); // 2p
                    Thread.Sleep(1);
                    Console.SetCursorPosition(x1, y1);
                    Console.Write(" "); // 1p 
                    
                    if ((GetAsyncKeyState((int)VK_LEFT_2) & 0x8000) != 0)
                    {
                        if (x1 > 1)
                            x1 -= 1;
                    }
                    if ((GetAsyncKeyState((int)VK_RIGHT_2) & 0x8000) != 0)
                    {
                        if (x1 < x - 7)
                            x1 += 1;
                    }
                }
                cnt++;
                stopwatch.Stop();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(5, 21);
                double tm = stopwatch.ElapsedMilliseconds * 0.001;
                tm1 = Convert.ToString(tm);
                tm1 = string.Format("{0:0.0##} ", double.Parse(tm1));

                System.Console.WriteLine("게임 시간 : " + "{0:D0.0}", tm1);
                Console.SetCursorPosition(30, 21);
                Console.WriteLine($" 2p[{playerName1}] 점수: {count1}   1P[{playerName}] 점수: {count}");

                if (tm >= 5.5 && tm <= 6)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    s = 50;
                    PrintMap(1, 100);
                }
                if (tm >= 8 && tm <= 8.5)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    s = 20;
                    PrintMap(1, 70);
                }
                if (tm >= 10 && tm <= 10.5)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Green;
                    s = 10;
                    PrintMap(1, 50);
                }
                if (tm >= 15 && tm <= 15.5)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    s = 10;
                    PrintMap(1, 30);
                }
                if (tm >= 20 && tm <= 20.5)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    s = 5;
                    PrintMap(1, 20);
                }
                if (tm >= 25 && tm <= 25.5)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    s = 1;
                    PrintMap(1, 10);
                }
            }
            Result(tm1, count, count1);
            Thread.Sleep(2000);
        }
        public void Result(string _time, int _count1, int _count2)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t-------------------------------");
            Console.WriteLine("\t\t          [게임 결과]");
            Console.WriteLine("\t\t-------------------------------");
            Console.WriteLine($"\n\t\t게임 시간: {_time} 초");
            Console.WriteLine($"\n\t\t게임 점수: {playerName}: {_count1}  {playerName1}: {_count2}");

            if (_count1 > _count2)
                winner = playerName;
            else if (_count1 < _count2)
                winner = playerName1;
            else if (_count1 == _count2)
                winner = "공동 승리";
            Console.WriteLine($"\n\t\t승자는: {winner}");

            countS = _count1.ToString();
            countS1 = _count2.ToString();

            recordGame.tm1 = tm1;
            recordGame.playerName = playerName;
            recordGame.count = countS;
            recordGame.playerName1 = playerName1;
            recordGame.count1 = countS1;
            recordGame.winner = winner;
            arrList.Add(recordGame);
            recordGame.loadFileRecord(arrList);
        }
        public void initRecord()
        {
            recordGame.loadFileRecord(arrList);
        }

        public void printAllRecord()
        {
            Record record = new Record();

            if (record != null)
            {
                for (int i = 0; i < arrList.Count; i++)
                {
                    record = (Record)arrList[i];
                    record.showInfo(i + 1);
                }
                Console.ReadLine();
            }
            else
                Console.WriteLine("검색 대상이 없습니다...");
        }
        public void programExit()
        {
            recordGame.saveFileRecord(arrList);
            Console.Write("프로그램 종료!!");
            Console.ReadLine();
        }
    }
    class Record
    {
        public string playerName { get; set; }
        public string playerName1 { get; set; }
        public string count { get; set; }
        public string count1 { get; set; }
        public string tm1 { get; set; }
        public string winner { get; set; }

        public void showInfo(int order)
        {
            Console.WriteLine("\n\t\t----------{0}----------", order);
            Console.WriteLine($"\n\t\t게임 시간: {this.tm1} 초");
            Console.WriteLine($"\n\t\t게임 점수: {this.playerName} = {this.count}  {this.playerName1} = {this.count1}");
            Console.WriteLine("\t\t승자 : " + this.winner);
        }
        public void showInfo()
        {
            Console.WriteLine($"\n\t\t게임 시간: {this.tm1} 초");
            Console.WriteLine($"\n\t\t게임 점수: {this.playerName} = {this.count}  {this.playerName1} = {this.count1}");
            Console.WriteLine("\t\ta★승자★ : " + this.winner);
        }
        public void loadFileRecord(ArrayList arrList)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Record.txt");
                Record record = null;
                int step = 0;
                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine();
                    if (step == 0)
                    {
                        record = new Record();
                        record.tm1 = str;
                        step++;
                    }
                    else if (step == 1)
                    {
                        record.playerName = str;
                        step++;
                    }
                    else if (step == 2)
                    {
                        record.count = str;
                        step++;
                    }
                    else if (step == 3)
                    {
                        record.playerName1 = str;
                        step++;
                    }
                    else if (step == 4)
                    {
                        record.count1 = str;
                        step++;
                    }
                    else if (step == 5)
                    {
                        record.winner = str;
                        step++;
                    }
                    else 
                    {
                        step = 0;
                        arrList.Add(record);
                    }
                }
            }
            catch (Exception e)  
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally 
            {
                if (sr != null)
                    sr.Close();
            }
        }
        public void saveFileRecord(ArrayList arrList)
        {
            StreamWriter sw = new StreamWriter("Record.txt");
            for (int i = 0; i < arrList.Count; i++)
            {
                Record record = (Record)arrList[i];
                sw.WriteLine(record.tm1);
                sw.WriteLine(record.playerName);
                sw.WriteLine(record.count);
                sw.WriteLine(record.playerName1);
                sw.WriteLine(record.count1);
                sw.WriteLine(record.winner);
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
