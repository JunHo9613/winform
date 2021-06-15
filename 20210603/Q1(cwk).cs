using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03__mySol
{
    class Q1
    {
        /*        

        1. 
        (1차원 String배열)
        3명 학생의 이름을 입력받고 배열에 저장

        (2차원 double배열)
        3명 학생의 국, 영, 수 점수를 입력받고 배열에 저장
        하세요

        2. 1번을 토대로 학생별 총점과 학생별 평균을 출력하세요(이름도 함께 출력하세요)

        3. 국어과목 평균, 영어과목 평균, 수학과목 평균을 출력하세요

        */



        static void Main(string[] args)
        {
            string[] nameArr = new string[3];       // 이름 1차원 배열
            double[,] scoreArr = new double[3, 3];  // 점수 2차원 배열

            double[] stTotal = new double[3];       // 학생 점수 총점 배열
            double[] stAvg = new double[3];         // 학생 점수 평균 배열

            double[] scTotal = new double[3];    // 과목 점수 총점 배열
            double[] scAvg = new double[3];      // 과목 점수 평균 배열

            for (int i = 0; i < nameArr.Length; i++)  // 이름 입력(1차원 배열)
            {
                Console.Write("{0}번째 이름 입력 >> ", i + 1);
                nameArr[i] = Console.ReadLine();
            }


            for (int x = 0; x < 3; x++)                 // 각 학생에 대한 국영수 점수 입력(2차원 배열)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (y == 0)
                    {
                        Console.Write("{0} 학생 국어점수 입력 >> ", nameArr[x]);
                        scoreArr[x, y] = int.Parse(Console.ReadLine());
                    }

                    else if (y == 1)
                    {
                        Console.Write("{0} 학생 영어점수 입력 >> ", nameArr[x]);
                        scoreArr[x, y] = int.Parse(Console.ReadLine());
                    }

                    else if (y == 2)
                    {
                        Console.Write("{0} 학생 수학점수 입력 >> ", nameArr[x]);
                        scoreArr[x, y] = int.Parse(Console.ReadLine());
                    }

                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++) // 학생별 총점, 평균 구하기
            {
                for (int j = 0; j < 3; j++)
                {
                    stTotal[i] += scoreArr[i, j];
                    
                }
                stAvg[i] = stTotal[i] / 3;      
            }

            for (int i = 0; i < 3; i++) // 과목별 총점, 평균 구하기
            {
                for (int j = 0; j < 3; j++)
                {
                    scTotal[i] += scoreArr[j, i];
                }
                scAvg[i] = scTotal[i] / 3;
            }

            for (int x = 0; x < 3; x++) // 학생 성적표 전체 출력
            {
                Console.WriteLine("{0}:\t{1}\t{2}\t{3}\t총점:{4:0.#0}\t평균:{5:0.#0}", nameArr[x], scoreArr[x, 0], scoreArr[x, 1], scoreArr[x, 2], stTotal[x], stAvg[x]);
            }

            Console.WriteLine();
            Console.WriteLine("국어 총점: {0}\t영어 총점: {1}\t수학 총점: {2}", scTotal[0], scTotal[1], scTotal[2]); // 과목별 총점 출력
            Console.WriteLine();
            Console.WriteLine("국어 평균: {0:0.#0}\t영어 평균: {1:0.#0}\t수학 평균: {2:0.#0}", scAvg[0], scAvg[1], scAvg[2]); // 과목별 평균 출력



        }


    }
}
