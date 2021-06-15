using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03.추상_메서드
{
    class WorkerManager
    {
        ArrayList arrList = new ArrayList();
        SaveLoad sl = new SaveLoad();
        public void insertWorker(int sel)
        {
            string num, name;
            double pay, bonus, year, day;
            Worker work;
            Console.Write("사번>>");
            num = Console.ReadLine();
            Console.Write("이름>>");
            name = Console.ReadLine();

            if(sel == 1)
            {
                work = new Regular();

                Console.Write("연봉>>");
                pay = double.Parse(Console.ReadLine());
                Console.Write("보너스>>");
                bonus = double.Parse(Console.ReadLine());

                work.emNum = num;
                work.emName = name;
                work.Pay = pay;
                ((Regular)work).bonus = bonus;
                arrList.Add(work);
            }
            else if (sel == 2)
            {
                work = new Temporary();

                Console.Write("계약금>>");
                pay = double.Parse(Console.ReadLine());
                Console.Write("고용날>>");
                year = double.Parse(Console.ReadLine());

                //((Temporary)work).emNum = num;
                work.emNum = num;
                work.emName = name;
                work.Pay = pay;
                ((Temporary)work).hireYear = year;
                arrList.Add(work);
            }
            else if(sel == 3)
            {
                work = new Contract_Worker();

                Console.Write("일당>>");
                pay = double.Parse(Console.ReadLine());
                Console.Write("일 수>>");
                day = double.Parse(Console.ReadLine());

                work.emNum = num;
                work.emName = name;
                work.Pay = pay;
                ((Contract_Worker)work).workDay = day;
                arrList.Add(work);
            }
        }
        public void PrintAllInfo()
        {
            Worker work;
            for (int i = 0; i < arrList.Count; i++)
            {
                work = (Worker)arrList[i];
                Console.WriteLine("* * * * * * * * * * * * * * * * * *");
                work.showEmployeeInfo();
            }
            Console.ReadLine();
        }
        public void PrintMonthDay()
        {
            Worker work;
           for (int i = 0; i < arrList.Count; i++)
            {
                work = (Worker)arrList[i];
                Console.WriteLine("\n* * * * * * * * * * * * * * * * * *\n");
                Console.WriteLine(work.emName+"의 월급: "+work.getMonthDay()+"만원");
            }
            Console.ReadLine();
        }
        public void ProgramExit()
        {
            Console.WriteLine("프로그램 종료.");
            sl.SaveFile(arrList);
        }
    }
}
