using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01_HomeWork
{
    class Child
    {
        private int Marble1, Marble2;

        public Child(int marble1, int marble2)
        {
            this.Marble1 = marble1;
            this.Marble2 = marble2;
        }

        public void Play1(int num)
        {
            this.Marble1 += num;
            this.Marble2 -= num;

            Console.WriteLine("1차 놀이");
            Console.WriteLine("어린이1의 보유자산 - > 구슬 {0}개", this.Marble1);
            Console.WriteLine("어린이2의 보유자산 - > 구슬 {0}개", this.Marble2);
        }

        public void Play2(int num)
        {
            this.Marble1 -= num;
            this.Marble2 += num;

            Console.WriteLine("2차 놀이");
            Console.WriteLine("어린이1의 보유자산 - > 구슬 {0}개", this.Marble1);
            Console.WriteLine("어린이2의 보유자산 - > 구슬 {0}개", this.Marble2);
        }

        public void Num()
        {
            Console.WriteLine("어린이 1의 최종 보유자산: {0}개", this.Marble1);
            Console.WriteLine("어린이 2의 최종 보유자산: {0}개", this.Marble2);
        }
    }

    class HomeWork3
    {
        static void Main(string[] args)
        {
            /*1.다음 클래스를 정의하세요
            1) 어린아이가 가지고 있는 구슬 개수 정보를 담을 수 있다
            2) 놀이를 통한 구슬의 주고받음을 표현하는 메소드가 존재한다
            3) 어린이의 현재 구슬 개수를 출력하는 메소드가 존재한다.


               main에서는 객체를 이렇게 만듭니다
               어린이1의 보유자산 -> 구슬 15개
               어린이2의 보유자산 -> 구슬 9개
               1차 놀이에서 어린이1은 어린이2의 구슬 2개를 획득한다
               2차 놀이에서 어린이2는 어린이 1의 구슬 7개를 획득한다
               마지막으로 각각의 어린이가 보유하고 있는 구슬의 수를 출력한다
               프로그램을 종료한다.*/

                Child ch = new Child(15, 9);
                ch.Play1(2);
                Console.WriteLine();
                ch.Play2(7);
                Console.WriteLine();
                ch.Num();

        }
    }
}
