using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace LunchMate
{
    class Client
    {
        const string IP = "127.0.0.1";
        const int PORT = 9000;
        static StartView sv = new StartView();
        static Board board = new Board();
        static string[] idArr = new string[2];
        static MainMenu mm = new MainMenu();
        public static string sel = "G";
        static TitleText tt = new TitleText();
        public static ArrayList arr = new ArrayList();
        public static ArrayList title = new ArrayList();
        public static ArrayList text1 = new ArrayList();
        public static ArrayList id = new ArrayList();
        public static string id2;
        public static void mainLoop()
        {
            sel = "G";
            board.board();
            Console.CursorTop = 5;
            tt.showInfo();
            mm.selMainMenu();
        }
        static void threadRead(object sock) 
        {
            Socket clientSocket = (Socket)sock;
            NetworkStream ns = new NetworkStream(clientSocket);
            StreamReader sr = new StreamReader(ns);
            int cnt = 0;
            try
            {
                while (true)
                {
                    string strMsg = sr.ReadLine();
                    if (strMsg == "s")
                    {
                        sel = "G";
                        arr.Clear();
                        title.Clear();
                        text1.Clear();
                        id.Clear();
                        for ( ; ; )
                        {
                            strMsg = sr.ReadLine();
                            if (strMsg == "s") continue;
                            if (strMsg == "abcd")
                            {
                                break;
                            }
                            arr.Add(strMsg);
                        }
                        cnt = 0;
                        foreach (object obj in arr)
                        {
                            if (cnt == 0)
                            {
                                title.Add(obj);
                            }
                            else if (cnt == 1)
                            {
                                text1.Add(obj);
                            }

                            else if (cnt == 2)
                            {
                                id.Add(obj);
                                cnt = -1;
                            }
                            cnt++;
                        }
                        board.board();
                        Console.CursorTop = 5;
                        tt.showInfo();
                        mm.selMainMenu();
                    }
                    else if(strMsg == "d")
                    {
                        sel = "l";
                    }
                    else if(strMsg == "회원가입 성공")
                    {
                        Console.Clear();
                        Console.WriteLine(strMsg);
                        sel = "l";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("[클라이언트] : 서버 접속 종료");
                if (sr != null) sr.Close();
                if (ns != null) ns.Close();
                if (clientSocket != null) clientSocket.Close();
            }
        }
        static void Main(string[] args)
        {

            string[] strArr = { "NAME","ID", "PASS" };

            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), PORT);

            clientSocket.Connect(ipep);

            Thread thread = new Thread(new ParameterizedThreadStart(threadRead));
            thread.Start(clientSocket);

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);
            sv.startView();
            sel = sv.selPlay();
            for (; ; )
            {
                if (sel == "l")
                {
                    sw.WriteLine(sel);
                    sw.Flush();
                    Console.Clear();
                    Console.WriteLine("로그인 창");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write($"{strArr[i + 1]} : ");
                        string data = Console.ReadLine();
                        idArr[i] = data;
                        sw.WriteLine(data);
                        sw.Flush(); // 버퍼의 데이터를 즉시 전송   
                        sel = "";
                    }
                    id2 = idArr[0];
                }
                if(sel == "N")
                {
                    sw.WriteLine(sel);
                    sw.Flush();
                    Console.Clear();
                    Console.WriteLine("회원가입 창");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write($"{strArr[i]} : ");
                        string data = Console.ReadLine();
                        sw.WriteLine(data);
                        sw.Flush(); // 버퍼의 데이터를 즉시 전송
                        sel = "";
                        
                    }
                }
                else if (sel == "G")
                {
                    sw.WriteLine(sel);
                    sw.Flush();
                    sel = "";
                }
                else if(sel == "E")
                {
                    sw.WriteLine(sel);
                    sw.Flush(); 
                    break;
                }
                else if(sel == "U")
                {
                    sw.WriteLine(sel);
                    sw.Flush();

                    sw.WriteLine(id2);
                    sw.WriteLine(Board.title);
                    sw.WriteLine(Board.text);
                    sw.Flush(); // 버퍼의 데이터를 즉시 전송
                    sel = "G";

                }
            }
            clientSocket.Close();
        }
    }
}
