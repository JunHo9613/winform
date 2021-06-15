using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace _118_MultiThreadChattingPlusServer
{
    class Program
    {
        static object keyObj = new object();// 임계영역 동기화 객체
        static List<Socket> socketList = new List<Socket>();
        const int PORT = 9000;
        static void Main(string[] args)
        {
            Socket serverSocket =
                new Socket(AddressFamily.InterNetwork,
                           SocketType.Stream,
                           ProtocolType.Tcp);

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, PORT);

            serverSocket.Bind(ipep);
            serverSocket.Listen(100); // 이통사와 연결            
            while (true)
            {
                Console.WriteLine("[서버] 접속 대기중...");
                Socket connSocket = serverSocket.Accept();

                // 임계영역 동기화
                Monitor.Enter(keyObj);
                // 리스트에 소켓객체를 등록
                socketList.Add(connSocket);
                Monitor.Exit(keyObj);

                Console.WriteLine("[서버] 클라이언트 접속 연결~");
                Thread thread =
                    new Thread(new ParameterizedThreadStart(threadRead));
                thread.Start(connSocket);
                Console.WriteLine("[서버] 클라이언트 스레드 담당~");
            }
        }

        static void threadRead(object sock)
        {
            Socket connSocket = (Socket)sock;
            NetworkStream ns = new NetworkStream(connSocket);
            StreamReader sr = new StreamReader(ns);// ReadLine()
            StreamWriter sw = new StreamWriter(ns);// WriteLine()

            try  // 정상 실행을 시도
            {
                while (true)
                {
                    String strMsg = sr.ReadLine();
                    Console.WriteLine("[서버] : 수신 : " + strMsg);

                    // 메시지 전송자를 제외한 나머지 모든
                    // 연결 소켓에 데이터 전송
                    sendAllMsg(strMsg, connSocket);

                    sw.WriteLine(strMsg);   // echo
                    sw.Flush();             // 즉시전송
                    Console.WriteLine("[서버] : echo : " + strMsg);
                    if (strMsg == null || strMsg == "exit")
                        break;
                }
            }
            catch (Exception e) // 예외 발생이 여기로 점프
            {
                Console.WriteLine(e.Message);
            }
            finally // 정상,예외 모두 무조건 최종 실행되는 구문
            {
                Monitor.Enter(keyObj);
                // 연결이 종료된 소켓을 리스트에서 제거
                socketList.Remove(connSocket);
                Monitor.Exit(keyObj);

                Console.WriteLine("[서버] 클라이언트 접속 종료...");
                if (sr != null) sr.Close();
                if (ns != null) ns.Close();
                if (connSocket != null) connSocket.Close();
            }
        }

        static void sendAllMsg(String strMsg, Socket exceptionSocket)
        {
            Monitor.Enter(keyObj);
            foreach (Socket socket in socketList)
            {
                if (socket != exceptionSocket)
                {
                    NetworkStream ns = new NetworkStream(socket);
                    StreamWriter sw = new StreamWriter(ns);
                    sw.WriteLine(strMsg);
                    sw.Flush();
                }
            }
            Monitor.Exit(keyObj);
        }
    }
}
