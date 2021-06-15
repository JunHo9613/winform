using System;
using System.Collections.Generic;
using System.Text;

namespace _005_Homework_0601
{
//1. 다음 클래스를 정의하세요
//   1) 어린아이가 가지고 있는 구슬 개수 정보를 담을 수 있다
//   2) 놀이를 통한 구슬의 주고받음을 표현하는 메소드가 존재한다
//   3) 어린이의 현재 구슬 개수를 출력하는 메소드가 존재한다.

//   main에서는 객체를 이렇게 만듭니다
//     어린이1의 보유자산 -> 구슬 15개
//     어린이2의 보유자산 -> 구슬 9개
//     1차 놀이에서 어린이1은 어린이2의 구슬 2개를 획득한다
//     2차 놀이에서 어린이2는 어린이 1의 구슬 7개를 획득한다
//     마지막으로 각각의 어린이가 보유하고 있는 구슬의 수를 출력한다
//     프로그램을 종료한다.

    class Marble
    {
        public int marbleNum { get; set; }
        public int marbleNum1 { get; set; }

        public void MarblePlay(int marbleNum, int marbleNum1)
        {
            int temp = 2;
            int temp1 = 7;

            marbleNum = marbleNum + temp;
            temp = marbleNum1 - temp;
            marbleNum1 = temp;

            marbleNum1 = marbleNum1 + temp1;
            temp1 = marbleNum - temp1;
            marbleNum = temp1;

            this.marbleNum = marbleNum;
            this.marbleNum1 = marbleNum1;
        }
        public void PrintMarbleNum()
        {
            Console.WriteLine("첫번째 아이의 구슬 갯수는:" + marbleNum + "\n두번째 아이의 구슬 갯수는:" + marbleNum1);
        }
    }
    class HomeWork2
    {
        static void Main()
        {
            Marble marble = new Marble();

            marble.MarblePlay(15, 9);
            marble.PrintMarbleNum();
        }
    }
}
