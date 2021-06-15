using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03
{
    class ArrayWork
    {
        public void ArrayHomework()
        {
            /*
            1.
            (1차원 String배열)
            3명 학생의 이름을 입력받고 배열에 저장
            (2차원 double배열)
            3명 학생의 국, 영, 수 점수를 입력받고 배열에 저장
            하세요

            2. 1번을 토대로 학생별 총점과 학생별 평균을 출력하세요(이름도 함께 출력하세요)

            3.국어과목 평균, 영어과목 평균, 수학과목 평균을 출력하세요
            */

            string[] NameArr = new string[3];
            double[,] ScoreArr = new double[3, 3];
            double num, kor = 0, eng = 0, math = 0;
            for(int i = 0; i < 3; i++)
            {
                num = 0;
                Console.Write("이름 입력: ");
                NameArr[i] = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("점수 입력");
                    ScoreArr[i, j] = double.Parse(Console.ReadLine());
                    num += ScoreArr[i, j];
                    
                }
                kor += ScoreArr[i, 0];
                eng += ScoreArr[i, 1];
                math += ScoreArr[i, 2];
                Console.WriteLine(NameArr[i] + "의 총점수: " + num + "의 평균: " + num / 3);
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
            }
            Console.WriteLine("국어 평균 : " + kor/3 + " 영어 평균: " + eng/3 + " 수학 평균 : " + math/3);
        }
    }
}
