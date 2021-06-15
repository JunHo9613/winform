using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkStreamServer
{
    class NetworkStreamServerEX
    /*
    주소
    IP   : Host의 주소(강원랜드)
    Port : Host내의 여러 통신 프로세스중에 1개를 선택(포커방403호)
          0 ~ 65535 (0 ~ 1023 예약포트), 1024이상을 임의의 포트 선택
    */

    // IP 주소는 이 프로세스가 동작하는 Host의 IP를
    // 자동으로 가져와서 설정한다
    {
        const int PORT = 9000;
        static void Main(string[] args)
        {
            // 1. 소켓 생성(휴대폰)
            Socket serverSocket =
                new Socket(AddressFamily.InterNetwork,
                            SocketType.Stream,
                            ProtocolType.Tcp);

            // 2. 서버의 주소 정보
            IPEndPoint ipep =
                new IPEndPoint(IPAddress.Any, PORT);

            // 3. 소켓에 주소를 부여(휴대폰에 번호를 부여)
            serverSocket.Bind(ipep);
            // 4. 서버소켓이 클라이언트가 동시 접속시
            //    대기시켜놓는 내부 Queue를 100개 생성
            serverSocket.Listen(100);
            Console.WriteLine("[서버] 클라이언트 접속 대기중...");

            // 5. 클라이언트 접속 대기(Accept가 리턴하지 않고 있다가)
            //    내부적으로 연결되면 메서드가 리턴함
            //    리턴하면 상대방과 연결된 소켓을 리턴함
            //    connSocket을 통해 클라이언트와 통신함
            Socket connSocket = serverSocket.Accept();

            // 6. 클라이언트가 보내는 데이터를 수신
            //    아래는 마치 키보드에서 입력받는 것처럼 처리하기 위해서
            //    Wrapper클래스를 이용해서 수신한다.
            NetworkStream ns = new NetworkStream(connSocket);
            StreamReader sr = new StreamReader(ns);
            string receiveData = sr.ReadLine();

            // 7. 수신 데이터 출력
            Console.WriteLine("[서버] 수신 : " + receiveData);

            // 8. 통신 종료
            connSocket.Close();
            serverSocket.Close();
        }
    }
}
