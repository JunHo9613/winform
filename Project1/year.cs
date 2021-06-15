using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.연도를 입력받으세요
  윤년인지 아닌지를 판별하세요
   4로 나누어 떨어지는 해는 일단 윤년에 포함시킵니다
   하지만 윤년중에 100으로 나누어떨어지는 해는 평년으로 하되
   평년중에 400으로 나누어 떨어지는 해는 윤년에 해당합니다
   프로그래밍을 완성하세요*/


namespace Project1
{
    class year
    {
        static void Main(string[] args)
        {
            bool isrun = true;
            while (isrun)
            {
                Console.WriteLine("윤년 판독기 ");
                int year = int.Parse(Console.ReadLine());

                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine("윤년 입니다.\n");
                }
                else 
                {
                    Console.WriteLine("평년 입니다.\n");
                }
            }
            
        }
    }
}
