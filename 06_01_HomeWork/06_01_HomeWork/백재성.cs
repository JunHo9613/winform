using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01_HomeWork
{
    
    class 백재성
    {
        static int[] getInputNums()
        {
            int[] num = new int[1000];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("정수를 입력하시오: ");
                num[i] = Int32.Parse(Console.ReadLine());

                if (num[i] == 0)
                    break;
            }
            return num;
        }

        static void Main(string[] args)
        {
           /* 사용자가 0을 입력하기 전까지 정수를 입력해서 반환하는
           메서드를 정의하고 사용하세요
           int[] getInputNums(); */

           getInputNums();
        }
    }
}
