using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03.추상_메서드
{
    class WorkerMenu
    {
        WorkerManager wm = new WorkerManager();
        public void Menu()
        {
            bool isRun = true;
            while (isRun)
            {
                ClearS();
                printMenu();
                Console.Write("메뉴 선택>");
                int sel = Int32.Parse(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        ClearS();
                        wm.insertWorker(sel);
                        break;
                    case 2:
                        ClearS();
                        wm.insertWorker(sel);
                        break;
                    case 3:
                        ClearS();
                        wm.insertWorker(sel);
                        break;
                    case 4:
                        ClearS();
                        wm.PrintAllInfo();
                        break;
                    case 5:
                        ClearS();
                        wm.PrintMonthDay();
                        break;
                    case 6:
                        wm.ProgramExit();
                        isRun = false;
                        break;
                    default:
                        break;
                }
            }
        }
        public void printMenu()
        {
            Console.WriteLine("* * * 메뉴 선택 * * *");
            Console.WriteLine("1. 정규직 저장");
            Console.WriteLine("2. 임시직 저장");
            Console.WriteLine("3. 계약직 저장");
            Console.WriteLine("4 전체 정보 출력");
            Console.WriteLine("5. 월급 계산 출력");
            Console.WriteLine("6. 프로그램 종료");
            Console.WriteLine("* * * * * * * * * *");
        }
        public void ClearS()
        {
            Console.Clear();
        }
    }
}
