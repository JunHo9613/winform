using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06_01
{
    class Homework_06_01
    {
        //1. 사용자가 0을 입력하기 전까지 정수를 입력해서 출력하는
   //메서드를 정의하고 사용하세요
  // void printInputNums();
        static void printInputNums()

        {
            ArrayList list = new ArrayList();
            int a = 1;
            while (a != 0)
            {
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("입력한 수 : " + a);
                if (a == 0)
                {
                    for (int i = 0; i < list.Count; i++)
                        Console.WriteLine($"{list[i]}");
                    Console.WriteLine("0을입력하였으므로 종료합니다");
                    break;
                }
                list.Add(a); 
            }
        }
        static void Main(string[] adgd)
        {
            printInputNums();
        }
    }
}
