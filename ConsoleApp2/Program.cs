using System;
using System.Collections.Generic;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawCalendar(2021, 06);
        }

        public static void DrawCalendar(int year, int month)
        {
            Console.WriteLine($"     {year}년 {month.ToString().PadLeft(2, ' ')}월        ");
            Console.WriteLine("일 월 화 수 목 금 토");
            int endDay = _monthDaysList[month - 1];
            int dayOfWeek = DayOfWeek(year, month, 1); // 1일이 무슨 요일인지 확인
            for (int i = 1; i < endDay; i++)
            {
                // 첫행 공백 출력
                if (i == 1)
                {
                    for (int m = 0; m < dayOfWeek; m++)
                    {
                        Console.Write("   ");
                    }
                }

                // 날짜 출력
                Console.Write(i.ToString().PadRight(3, ' '));

                // 개행처리
                if ((i + dayOfWeek) % 7 == 0)
                {
                    Console.WriteLine();  // 개행
                }
            }
        }

        static List<int> _monthDaysList = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int DayOfWeek(int year, int month, int day)
        {
            int preMonthtotalDays = 0;

            // 전달까지 총일 수를 구한다.
            preMonthtotalDays = PreMonthTotalDays(year, month);

            // 구하는 달 1일의 요일을 구한다.
            // => 요일 = (전달까지 총 일수 + 1일(이번달 1일이 무슨 요일인지 확인하기 위해)) % 일주일(7일)
            int dayOfWeek = (preMonthtotalDays + day) % 7;

            return dayOfWeek;
        }

        public static int PreMonthTotalDays(int year, int month)
        {
            int totalDays = 0;
            // 이전 년도까지 전체 날짜 수를 구한다.
            // ex) 만약 400년도까지 있었던 윤년으로 추가된 일수를 모두 더하면
            //  400/4 = 100 => 4년 마다 윤년이다.
            //  400/400 = 1 => 400년 마다 윤년이다.
            //  400/100 = 4 => 100년 마다 평년이다
            //  => 100 + 1 - 4 = 97  ** 400년 동안 97년이 윤년이며 때문에 97일이 총 일수에 추가된다.
            // 이 그레고리오력에서는 400년간에 97년이 윤년이 된다. 
            // 한국에서는 1896년(건양 1)부터 태양력이 쓰였는데 이 역법은 그레고리오력이다. 
            // 그레고리오력이 현행의 태양력이다. 그레고리오력의 1년 1월 1일은 월요일이다.
            // 전체일수 = (이전년도) * 365 + (이전년도 윤년의 합); 
            int preYear = year - 1;
            totalDays = preYear * 365 + (preYear / 4 + preYear / 400 - preYear / 100);

            // 대상 년도의 이전 달까지 날짜 수를 구한다.
            for (int i = 0; i < month - 1; i++) // 전달까지만 합계에 넣는다.
            {
                // 1월(인덱스(i = 0))부터 전달까지 날짜를 더한다
                totalDays += _monthDaysList[i];
            }

            // 이번 년도가 윤년 여부 확인해 1일 추가 한다.
            if (month >= 3 && IsLeafYear(year))
            {
                totalDays += 1;
            }
            return totalDays;
        }

        /// <summary>
        /// 윤년을 확인합니다.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool IsLeafYear(int year)
        {
            /************************************************
             * 윤년이란
             * 4로 나누어 지는 해 또는 400으로 나누어 지는 해마다 2월이 29일이 되고 100으로 나누어 지는 해
             ************************************************/
            if ((year % 4 == 0 || year % 400 == 0) && year % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
