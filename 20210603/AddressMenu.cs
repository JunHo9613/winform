using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressMenu
    {
        AddressManager addrManager =
            new AddressManager();

        public void mainLoop()
        {
            addrManager.initAddress();

            bool isRun = true;
            while (isRun)
            {
                clearScreen();
                printMenu();
                int sel = selectMenu();

                clearScreen();
                switch (sel)
                {
                    case 1:
                        addrManager.insertAddress();
                        break;
                    case 2:
                        addrManager.searchAddress();
                        break;
                    case 3:
                        addrManager.updateAddress();
                        break;
                    case 4:
                        addrManager.printAllAddress();
                        break;
                    case 5:
                        addrManager.deleteAddress();
                        break;
                    case 6:
                        addrManager.programExit();
                        isRun = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public void printMenu()
        {
            Console.WriteLine("=================");
            Console.WriteLine("1. 정규직 저장");
            Console.WriteLine("2. 임시직 저장");
            Console.WriteLine("3. 계약직 저장");
            Console.WriteLine("4. 전체 정보 출력");
            Console.WriteLine("5. 월급 계산 출력");
            Console.WriteLine("6. 프로그램 종료");
            Console.WriteLine("=================");
        }

        public int selectMenu()
        {
            int sel = 0;

            Console.Write("메뉴 선택 >> ");
            sel = Int32.Parse(Console.ReadLine());

            return sel;
        }

        public static void clearScreen()
        {
            Console.Clear();
        }
    }
}
