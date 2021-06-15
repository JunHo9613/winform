using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mini_project
{
    class bingo
    {
        public void Bingo()
        {
            //배열을 이용해서 만든 3*3 빙고 게임 

            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            int player = 1; //플레이어는 1로 설정  

            int choice; //사용자가 표시할 위치를 선택 

            int flag = 0; //승리, 패배, 무승부 값을 받기 위함         


            do
            {
                Console.Clear();// 화면을 한번 지우고 새로운 화면을 출력하기 위함   
                Console.WriteLine("Player 1 = X    Player 2 = O"); // 플레이어 표시 
                Console.WriteLine("\n");

                if (player % 2 == 0) //값이 바뀔때마다 플레이어 순서가 바뀜   
                {
                    Console.WriteLine("Player 2 차례");
                }
                else
                {
                    Console.WriteLine("Player 1 차례");
                }

                Console.WriteLine("\n");

                Board();// 아래의 보드 호출 

                choice = int.Parse(Console.ReadLine());//번호를 선택하세요 

                // 플레이어가 원하는 위치를 선택, 선택된 부분은 X 나 O로 위치로 표시  
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //만약 플레이어2가 선택하면 O 표시 
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else//반대값이 주어지면 즉 플레이어1가 선택하면 X 표시 
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }

                else // 만약 플레이어가 이미 선택한 위치를 선택한다면 아래 문구 호출 후 2초뒤 보드 재생성                
                {
                    Console.WriteLine("해당 위치 {0} 는 다른 플레이어가 선택 했습니다. 상대 플레이어 표시 는 {1} \n", choice, arr[choice]);
                    Console.WriteLine("2초 뒤 보드가 다시 생성되면 선택해주세요");
                    Thread.Sleep(2000);
                }

                flag = CheckWin();

            } while (flag != 1 && flag != -1);// flag가 1,-1,0 의 값이 주어질 때 까지 반복            

            Console.Clear();

            Board();// 보드 호출 


            if (flag == 1) // 만약 플래그 값이 1이면, 누군가가 이겼거나, 마지막에 표시되었던 사람이 이겼던 것을 의미한다.
            {
                Console.WriteLine("플레이어 {0} 승리!", (player % 2) + 1);
            }

            else// 플래그 값이 -1이면 승자가 결정되지 않았다고 판단하기에 무승부 표시 

            {
                Console.WriteLine("무승부");
            }
            Console.ReadLine();


            // 보드그림  

            void Board()

            {
                Console.WriteLine(" _________________ ");
                Console.WriteLine("|     |     |     |");
                Console.WriteLine("|  {0}  |  {1}  |  {2}  |", arr[1], arr[2], arr[3]);
                Console.WriteLine("|_____|_____|_____|");
                Console.WriteLine("|     |     |     |");
                Console.WriteLine("|  {0}  |  {1}  |  {2}  |", arr[4], arr[5], arr[6]);
                Console.WriteLine("|_____|_____|_____|");
                Console.WriteLine("|     |     |     |");
                Console.WriteLine("|  {0}  |  {1}  |  {2}  |", arr[7], arr[8], arr[9]);
                Console.WriteLine("|     |     |     |");
                Console.WriteLine(" ----------------- ");
            }

            //플레이어의 조건 : 각 줄의 승리 조건 설정
            //return문은 해당 문이 나타나는 메서드의 실행을 종료하고 제어를 호출 메서들 반환합니다.
            //return 1 : 값을 반환하라는 의미 한줄이 완성이 될때까지 계속 값을 반환해야하기에 사용,
            //           반환된값이 승리 조건을 만족시키면 승리.
            //return -1 : 에러발생 = 무승부 표시
            //return 0 : 함수 종료 = 게임패배 
            int CheckWin()
            {
                //가로줄열의 승리 조건   
                if (arr[1] == arr[2] && arr[2] == arr[3])
                {
                    return 1;
                }
                else if (arr[4] == arr[5] && arr[5] == arr[6])
                {
                    return 1;
                }
                else if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    return 1;
                }

                //세로줄 열의 승리 조건 
                else if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    return 1;
                }
                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    return 1;
                }
                else if (arr[3] == arr[6] && arr[6] == arr[9])
                {
                    return 1;
                }

                // 대각선 열의 이기는 조건 
                else if (arr[1] == arr[5] && arr[5] == arr[9])
                {
                    return 1;
                }
                else if (arr[3] == arr[5] && arr[5] == arr[7])
                {
                    return 1;
                }

                // 만약 승부가 안난다 즉, 한줄이 안만들어진다면 무승부가 된다.  
                else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            Console.Clear();
        }
        static void ClearScreen()
        {
            Console.WriteLine();
            Console.Clear();
        }
    }
}